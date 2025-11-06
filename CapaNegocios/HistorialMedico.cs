using System;
using Microsoft.Data.SqlClient;
using CapaDatos;

namespace HistorialMed
{
    public class HistorialMedico
    {
        // PROPIEDADES del HISTORIL MEDICO
        public int IDHistorialMED { get; set; }
        public int IDPaciente { get; set; }
        public int IDDoctor { get; set; }
        public DateTime FechaConsulta { get; set; }
        public string Sintomas { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }

        // CONEXIÓN
        private ConexionDatos Conexion;

        //  CONSTRUCTOR VACÍO
        public HistorialMedico()
        {
            Conexion = new ConexionDatos();
            FechaConsulta = DateTime.Now;  // Fecha y hora actual
        }

        // 4️⃣ CONSTRUCTOR CON DATOS
        public HistorialMedico(int idPaciente, int idDoctor, string sintomas,
                              string diagnostico, string tratamiento, string observaciones)
        {
            Conexion = new ConexionDatos();
            this.IDPaciente = idPaciente;
            this.IDDoctor = idDoctor;
            this.FechaConsulta = DateTime.Now;
            this.Sintomas = sintomas;
            this.Diagnostico = diagnostico;
            this.Tratamiento = tratamiento;
            this.Observaciones = observaciones;
        }

        // Metodo para insertar El historial medico
        public int Insertar()
        {
            try
            {
                // Abrir conexión
                SqlConnection conn = Conexion.AbrirConexion();

                // Usamos al senor SQL para insertar Datos
                string sql = "INSERT INTO HistorialMedico (IDPaciente, IDDoctor, FechaConsulta, sintomas, Diagnostico, Tratamiento, observaciones) " +
                             "VALUES (@IDPaciente, @IDDoctor, @FechaConsulta, @Sintomas, @Diagnostico, @Tratamiento, @Observaciones); " +
                             "SELECT CAST(SCOPE_IDENTITY() AS INT);";


                SqlCommand cmd = new SqlCommand(sql, conn);

                //  Agregar los parámetros
                cmd.Parameters.AddWithValue("@IDPaciente", this.IDPaciente);
                cmd.Parameters.AddWithValue("@IDDoctor", this.IDDoctor);
                cmd.Parameters.AddWithValue("@FechaConsulta", this.FechaConsulta);
                cmd.Parameters.AddWithValue("@Sintomas", this.Sintomas);
                cmd.Parameters.AddWithValue("@Diagnostico", this.Diagnostico);
                cmd.Parameters.AddWithValue("@Tratamiento", this.Tratamiento);
                cmd.Parameters.AddWithValue("@Observaciones", this.Observaciones);

                // Ejecutar
                int idGenerado = (int)cmd.ExecuteScalar();
                this.IDHistorialMED = idGenerado;

                // esto Cierra la conexion
                Conexion.CerrarConexion();

                return idGenerado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar historial: " + ex.Message);
            }
        }

        // La funcion de este metodo es actualizar el historialMED
        public bool Actualizar()
        {
            try
            {
                SqlConnection conn = Conexion.AbrirConexion();

                string sql = "UPDATE HistorialMedico SET " +
                             "sintomas = @Sintomas, " +
                             "Diagnostico = @Diagnostico, " +
                             "Tratamiento = @Tratamiento, " +
                             "observaciones = @Observaciones " +
                             "WHERE IDHistorialMED = @IDHistorialMED";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDHistorialMED", this.IDHistorialMED);
                cmd.Parameters.AddWithValue("@Sintomas", this.Sintomas);
                cmd.Parameters.AddWithValue("@Diagnostico", this.Diagnostico);
                cmd.Parameters.AddWithValue("@Tratamiento", this.Tratamiento);
                cmd.Parameters.AddWithValue("@Observaciones", this.Observaciones);

                cmd.ExecuteNonQuery();
                Conexion.CerrarConexion();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar historial: " + ex.Message);
            }
        }
    }
}
