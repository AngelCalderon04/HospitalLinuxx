using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_PersonalAdministrativo
    {
        private ConexionDatos conexion = new ConexionDatos();

        //  REGISTRAR 
        public void RegistrarAdministrativo(
            string nombre, string cedula, string telefono, string email,
            string departamento, string cargo, decimal salario)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    int idPersonaGenerado = 0;

                    //INSERTAR EN PERSONAS
                    string queryPersona = "INSERT INTO Personas (Nombre, Cedula, Telefono, Email, Rol) " +
                                          "VALUES (@Nombre, @Cedula, @Telefono, @Email, 'Administrativo'); " +
                                          "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    SqlCommand cmdPersona = new SqlCommand(queryPersona, conn, transaction);
                    cmdPersona.Parameters.AddWithValue("@Nombre", nombre);
                    cmdPersona.Parameters.AddWithValue("@Cedula", cedula);
                    cmdPersona.Parameters.AddWithValue("@Telefono", telefono);
                    cmdPersona.Parameters.AddWithValue("@Email", email ?? (object)DBNull.Value);

                    idPersonaGenerado = (int)cmdPersona.ExecuteScalar();

                    //INSERTAR EN PERSONAL ADMINISTRATIVO
                    
                    string queryAdmin = "INSERT INTO PersonalAdministrativo (IDPersona, Departamento, Cargo, Salario) " +
                                        "VALUES (@IDPersona, @Departamento, @Cargo, @Salario)";

                    SqlCommand cmdAdmin = new SqlCommand(queryAdmin, conn, transaction);
                    cmdAdmin.Parameters.AddWithValue("@IDPersona", idPersonaGenerado);
                    cmdAdmin.Parameters.AddWithValue("@Departamento", departamento);
                    cmdAdmin.Parameters.AddWithValue("@Cargo", cargo);
                    cmdAdmin.Parameters.AddWithValue("@Salario", salario);

                    cmdAdmin.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (SqlException sqlEx)
                {
                    transaction.Rollback();
                    if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                        throw new Exception("Error: Ya existe un empleado con esa Cédula.");
                    else
                        throw new Exception("Error SQL: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al guardar: " + ex.Message);
                }
            }
        }

        // ACTUALIZAR 
        public void ActualizarAdministrativo(int idAdministrativo, string departamento, string cargo, decimal salario)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                try
                {
                    string sql = "UPDATE PersonalAdministrativo SET " +
                                 "Departamento = @Departamento, " +
                                 "Cargo = @Cargo, " +
                                 "Salario = @Salario " +
                                 "WHERE IDAdministrativo = @IDAdministrativo";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@IDAdministrativo", idAdministrativo);
                    cmd.Parameters.AddWithValue("@Departamento", departamento);
                    cmd.Parameters.AddWithValue("@Cargo", cargo);
                    cmd.Parameters.AddWithValue("@Salario", salario);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar: " + ex.Message);
                }
            }
        }

        //  OBTENER LISTA Para el DataGridView
        public DataTable ObtenerTodoPersonalAdmin()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                try
                {
                    string sql = @"SELECT 
                                     PA.IDAdministrativo,
                                     Per.Nombre, 
                                     Per.Cedula,
                                     Per.Telefono,
                                     Per.Email,
                                     PA.Cargo,
                                     PA.Departamento,
                                     PA.Salario
                                   FROM PersonalAdministrativo PA
                                   INNER JOIN Personas Per ON PA.IDPersona = Per.IDpersona
                                   WHERE Per.Rol = 'Administrativo'
                                   ORDER BY Per.Nombre";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar personal: " + ex.Message);
                }
            }
            return dt;
        }
    }
}