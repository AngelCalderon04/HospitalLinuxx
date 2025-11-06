// AuthService.cs
using System;
using System.Data;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;
using CapaDatos;

namespace CapaNegocios
{
    public class Usuario
    {
        public int IDUsuario { get; set; }
        public int IDPersona { get; set; }
        public string NombreUsuario { get; set; }
        public string Rol { get; set; }
        public bool Activo { get; set; }
    }

    public class AuthService
    {
        private readonly ConexionDatos _conexion;
        private const int SaltSize = 16; // bytes
        private const int HashSize = 32; // bytes
        private const int Iterations = 100_000;

        public AuthService()
        {
            _conexion = new ConexionDatos();
        }

        // Genera hash y salt con PBKDF2
        public void GenerarHash(string password, out byte[] hash, out byte[] salt)
        {
            using (var rng = RandomNumberGenerator.Create())
            {
                salt = new byte[SaltSize];
                rng.GetBytes(salt);
            }

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
            {
                hash = pbkdf2.GetBytes(HashSize);
            }
        }

        // Verifica password contra hash+salt
        public bool VerificarPassword(string password, byte[] storedHash, byte[] storedSalt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, storedSalt, Iterations, HashAlgorithmName.SHA256))
            {
                var testHash = pbkdf2.GetBytes(HashSize);
                return CryptographicOperations.FixedTimeEquals(testHash, storedHash);
            }
        }

        // Crear usuario (vincula a persona existente IDPersona)
        public int CrearUsuario(int idPersona, string nombreUsuario, string password, string rol)
        {
            try
            {
                GenerarHash(password, out byte[] hash, out byte[] salt);

                var conn = _conexion.AbrirConexion();
                string sql = "INSERT INTO Usuarios (IDPersona, NombreUsuario, PasswordHash, PasswordSalt, Rol, Activo) " +
                             "VALUES (@IDPersona, @NombreUsuario, @PasswordHash, @PasswordSalt, @Rol, 1); SELECT CAST(SCOPE_IDENTITY() AS INT);";
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDPersona", idPersona);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@PasswordHash", hash);
                cmd.Parameters.AddWithValue("@PasswordSalt", salt);
                cmd.Parameters.AddWithValue("@Rol", rol ?? (object)DBNull.Value);

                int id = (int)cmd.ExecuteScalar();
                return id;
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                throw new Exception("El nombre de usuario ya existe.");
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear usuario: " + ex.Message);
            }
            finally
            {
                _conexion.CerrarConexion();
            }
        }

        // Login: devuelve Usuario si ok, null si falla
        public Usuario Login(string nombreUsuario, string password)
        {
            try
            {
                var conn = _conexion.AbrirConexion();
                string sql = "SELECT IDUsuario, IDPersona, PasswordHash, PasswordSalt, Rol, Activo FROM Usuarios WHERE NombreUsuario = @NombreUsuario";
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read()) return null;
                    int idUsuario = reader.GetInt32(0);
                    int idPersona = reader.GetInt32(1);
                    byte[] passwordHash = (byte[])reader["PasswordHash"];
                    byte[] passwordSalt = (byte[])reader["PasswordSalt"];
                    string rol = reader.IsDBNull(4) ? null : reader.GetString(4);
                    bool activo = reader.GetBoolean(5);

                    if (!activo) return null;

                    if (!VerificarPassword(password, passwordHash, passwordSalt)) return null;

                    return new Usuario
                    {
                        IDUsuario = idUsuario,
                        IDPersona = idPersona,
                        NombreUsuario = nombreUsuario,
                        Rol = rol,
                        Activo = activo
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en login: " + ex.Message);
            }
            finally
            {
                _conexion.CerrarConexion();
            }
        }

        // Listar usuarios (DataTable para binding en UI)
        public DataTable ListarUsuarios()
        {
            try
            {
                var conn = _conexion.AbrirConexion();
                string sql = "SELECT u.IDUsuario, u.IDPersona, u.NombreUsuario, u.Rol, u.Activo, p.Nombre AS NombrePersona " +
                             "FROM Usuarios u INNER JOIN Personas p ON u.IDPersona = p.IDPersona";
                var cmd = new SqlCommand(sql, conn);
                var dt = new DataTable();
                using (var da = new SqlDataAdapter(cmd))
                    da.Fill(dt);
                return dt;
            }
            finally
            {
                _conexion.CerrarConexion();
            }
        }

        public bool DesactivarUsuario(int idUsuario)
        {
            try
            {
                var conn = _conexion.AbrirConexion();
                string sql = "UPDATE Usuarios SET Activo = 0 WHERE IDUsuario = @IDUsuario";
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDUsuario", idUsuario);
                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                _conexion.CerrarConexion();
            }
        }

        public bool CambiarPassword(int idUsuario, string nuevaPassword)
        {
            try
            {
                GenerarHash(nuevaPassword, out byte[] hash, out byte[] salt);
                var conn = _conexion.AbrirConexion();
                string sql = "UPDATE Usuarios SET PasswordHash = @PasswordHash, PasswordSalt = @PasswordSalt WHERE IDUsuario = @IDUsuario";
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PasswordHash", hash);
                cmd.Parameters.AddWithValue("@PasswordSalt", salt);
                cmd.Parameters.AddWithValue("@IDUsuario", idUsuario);
                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                _conexion.CerrarConexion();
            }
        }
    }
}
