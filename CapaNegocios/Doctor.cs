using System;
using Microsoft.Data.SqlClient;
using Personas;

namespace Doctor
{
    public class Doctor : Persona
    {
        public int IDDoctor { get; set; }
        public string Exequatur { get; set; }
        public decimal TarifaConsulta { get; set; }
        public string Especialidad { get; set; }

        public Doctor() : base()
        {
        }

        // Constructor para leer desde BD (incluye IDDoctor)
        public Doctor(int idDoctor, int idPersona, string especialidad, string exequatur, decimal tarifaConsulta)
            : base()
        {
            IDDoctor = idDoctor;
            IDpersona = idPersona;
            Especialidad = especialidad;
            Exequatur = exequatur;
            TarifaConsulta = tarifaConsulta;
        }

        // Constructor para crear nuevo doctor  Doctor)
        public Doctor(string nombre, string cedula, string telefono, string email,
                      string especialidad, string exequatur, decimal tarifaConsulta)
            : base(nombre, cedula, telefono, email, "Doctor")
        {
            Especialidad = especialidad;
            Exequatur = exequatur;
            TarifaConsulta = tarifaConsulta;
        }

        public override string GenerarDiagnostico()
        {
            return $"Diagnóstico generado por el Dr. {this.Nombre}, Especialidad: {this.Especialidad}";
        }

        public override decimal CalcularHonorarios()
        {

            return TarifaConsulta;
        }

        // Inserta primero la persona, luego el doctor
        public new int Insertar()
        {
            try
            {
                int idPersona = base.Insertar();

                SqlConnection conn = Conexion.AbrirConexion();

                string sql = "INSERT INTO Doctor (IDPersona, Especialidad, Exequatur, TarifaConsulta) " +
                             "VALUES (@IDPersona, @Especialidad, @Exequatur, @TarifaConsulta); " +
                             "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDPersona", idPersona);
                cmd.Parameters.AddWithValue("@Especialidad", this.Especialidad ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Exequatur", this.Exequatur ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TarifaConsulta", this.TarifaConsulta);

                this.IDDoctor = (int)cmd.ExecuteScalar();

                return this.IDDoctor;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR AL INSERTAR DOCTOR: " + ex.Message);
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
    }
}
