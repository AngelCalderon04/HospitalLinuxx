using System;
using CapaDatos;
using Personas;
using Microsoft.Data.SqlClient;

namespace Enfermero
{

    public class Enfermero : Persona
    {

        public int IDEnfermero { get; set; }
        public string Turno { get; set; } //manana, tarde, noche, 
        public string Area { get; set; } //Emergencias, Quirofano,pediatria


        //Constructor vacio para onsultar a la base de DATOS 

        public Enfermero() : base()
        { }

        //Constructor conlosparametrospara crear nuevos ENFERMEROS 

        public Enfermero(int IDEnfermero, string nombre, string cedula, string telefono, string Email, string Turno,
                         string Area) : base(nombre, cedula, telefono, Email, "Enfermero")

        {
            this.IDEnfermero = IDEnfermero;
            this.Turno = Turno;
            this.Area = Area;


        }
        // Implementación del método abstracto GenerarDiagnostico
        public override string GenerarDiagnostico()
        {
            return $"Reporte de enfermería generado por {this.Nombre}, Área: {this.Area}, Turno: {this.Turno}";
        }

        // Sobrescritura del método virtual CalcularHonorarios
        public override decimal CalcularHonorarios()
        {
            // Los enfermeros cobran según su turno
            decimal tarifaBase = 500; // Tarifa base por turno

            if (this.Turno == "Noche")
            {
                return tarifaBase * 1.5m; // 50% más en turno nocturno
            }
            else if (this.Turno == "Tarde")
            {
                return tarifaBase * 1.2m; // 20% más en turno tarde
            }
            else // Mañana
            {
                return tarifaBase;
            }
        }

        // Método para insertar un nuevo Enfermero
        // Primero inserta en Personas, luego en Enfermero
        public new int Insertar()
        {
            try
            {
                // 1. Insertar en la tabla Personas (llama al método de la clase padre)
                int IDPersona = base.Insertar();

                // 2. Abrir conexión
                SqlConnection conn = Conexion.AbrirConexion();

                // 3. SQL para insertar en tabla Enfermero
                string sql = "INSERT INTO Enfermero (IDPersona, Turno, Area) " +
                             "VALUES (@IDPersona, @Turno, @Area); " +
                             "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                // 4. Crear comando
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDPersona", IDPersona);
                cmd.Parameters.AddWithValue("@Turno", this.Turno);
                cmd.Parameters.AddWithValue("@Area", this.Area);

                // 5. Ejecutar y obtener el ID generado
                this.IDEnfermero = (int)cmd.ExecuteScalar();

                // 6. Cerrar conexión
                Conexion.CerrarConexion();

                return this.IDEnfermero;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR AL INSERTAR ENFERMERO: " + ex.Message);
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
    }
}
