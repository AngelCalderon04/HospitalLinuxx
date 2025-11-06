
using System;
using Microsoft.Data.SqlClient;
using Personas;

namespace Pacientes

{
    public class Paciente : Persona

    {

        public int IDPaciente { get; set; }
        public string NumeroSeguro { get; set; }
        public string GrupoSanguinio { get; set; }
        public string Alergias { get; set; }
        public string ContactoEmergencia { get; set; }

        //constructor vacio para consultar a la base de Datos 

        public Paciente() : base()
        {
        }

        public Paciente(string Nombre, string Cedula, string Telefono, String Email, int IDPaciente, string NumeroSeguro, string GrupoSanguineo, String alergias, string ContactoEmergencia)
            : base(Nombre, Cedula, Telefono, Email, "Paciente")

        {

            this.NumeroSeguro = NumeroSeguro;
            this.GrupoSanguinio = GrupoSanguinio;
            this.ContactoEmergencia = ContactoEmergencia;
            this.Alergias = alergias;

        }

        public override string GenerarDiagnostico()
        {
            return $"El paciente {this.Nombre} no puede generar diagnósticos. Solo los recibe del doctor.";
        }

        // Sobrescritura del método virtual CalcularHonorarios
        // Los pacientes no cobran, pagan
        public override decimal CalcularHonorarios()
        {
            return 0; // Los pacientes no cobran
        }

        // Método adicional para obtener información médica básica
        public string ObtenerInformacionMedica()
        {
            return $"Paciente: {this.Nombre}\n" +
                   $"Tipo de Sangre: {this.GrupoSanguinio}\n" +
                   $"Alergias: {(string.IsNullOrEmpty(this.Alergias) ? "Ninguna" : this.Alergias)}\n" +
                   $"Contacto de Emergencia: {this.ContactoEmergencia} ";
        }

        // Método para insertar un nuevo Paciente
        // Primero inserta en Personas, luego en Paciente Lo e repetido 10 veces YA, ENTIENDO PATRON
        public new int Insertar()
        {
            try
            {
                // Insertar en la tabla Personas (llama al método de la clase padre)
                int IDPersona = base.Insertar();

                // Abrir conexión
                SqlConnection conn = Conexion.AbrirConexion();

                // SQL para insertar en tabla Paciente
                string sql = "INSERT INTO Paciente (IDPersona, NumeroSeguro, TipoSangre, Alergias, ContactoEmergencia, TelefonoEmergencia) " +
                             "VALUES (@IDPersona, @NumeroSeguro, @TipoSangre, @Alergias, @ContactoEmergencia, @TelefonoEmergencia); " +
                             "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                //  Crear comando paragrear Pacientes
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDPersona", IDPersona);
                cmd.Parameters.AddWithValue("@NumeroSeguro", this.NumeroSeguro ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TipoSangre", this.GrupoSanguinio ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Alergias", this.Alergias ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ContactoEmergencia", this.ContactoEmergencia ?? (object)DBNull.Value);


                // obtener el ID generado
                this.IDPaciente = (int)cmd.ExecuteScalar();

                // Cerrar conexión
                Conexion.CerrarConexion();

                return this.IDPaciente;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR AL INSERTAR PACIENTE: " + ex.Message);
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

        // Metodo para actualizar datos del paciente
        public bool Actualizar()
        {
            try
            {
                SqlConnection conn = Conexion.AbrirConexion();

                string sql = "UPDATE Paciente SET " +
                             "NumeroSeguro = @NumeroSeguro, " +
                             "GrupoSanguineo = @GrupoSanguineo, " +
                             "Alergias = @Alergias, " +
                             "ContactoEmergencia = @ContactoEmergencia, " +
                             "TelefonoEmergencia = @TelefonoEmergencia " +
                             "WHERE IDPaciente = @IDPaciente";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDPaciente", this.IDPaciente);
                cmd.Parameters.AddWithValue("@NumeroSeguro", this.NumeroSeguro ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GrupoSanguineo", this.GrupoSanguinio ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Alergias", this.Alergias ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ContactoEmergencia", this.ContactoEmergencia ?? (object)DBNull.Value);


                cmd.ExecuteNonQuery();
                Conexion.CerrarConexion();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR AL ACTUALIZAR PACIENTE: " + ex.Message);
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
    }
}

