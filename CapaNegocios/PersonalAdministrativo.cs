using System;
using Microsoft.Data.SqlClient;
using Personas;
using CapaDatos;


namespace PersonalAdministrativo

{
    public class PersonalAdministrativo : Persona

    {  //Propiedades de la clase PersonalAdministrativa 
        public int IDAdministrativo { get; set; }
        public string Departamento { get; set; } //CLUD DE VIVORAS, Contabilidad
        public string Cargo { get; set; }
        public Decimal Salario { get; set; }
        public string Nombre { get; set; }

        //constructor para consultar en la base de datos

        public PersonalAdministrativo() : base()

        {

        }

        public PersonalAdministrativo(string Nombre, string Cedula, string Telefono, string Email,
                                      string Departamento, string Cargo, decimal Salario)
                                    : base(Nombre, Cedula, Telefono, Email, "Administrativo")

        {
            this.Departamento = Departamento;
            this.Cargo = Cargo;
            this.Salario = Salario;


        }

        //Metodo para Generar diagnostico 
        //PERO las Donas de LIMPIEZAS NO REALIZAN Diagnostico, asi que se lo negamos de una vez 
        public override string GenerarDiagnostico()
        {
            return $"El personal administrativo {this.Nombre} no genera diagnósticos médicos. " +
                   $"Su función es: {this.Cargo} en el departamento de {this.Departamento}.";
        }

        //  metodo virtual CalcularHonorarios
        // El personal administrativo tiene salario fijo mensual
        public override decimal CalcularHonorarios()
        {
            // Retorna el salario mensual
            return this.Salario;
        }


        // Metodo para obtener información del puesto
        public string ObtenerInformacionPuesto()
        {
            return $"Empleado: {this.Nombre}\n" +
                   $"Cargo: {this.Cargo}\n" +
                   $"Departamento: {this.Departamento}\n" +
                   $"Salario Mensual: RD${this.Salario:N2}";
        }

        // Metodo para insertar nuevo Personal Administrativo
        // Por 5ta vez, Primero inserta en Personas y luego en PersonalAdministrativo
        public new int Insertar()
        {
            try
            {
                // Insertar en la tabla Personas (llama al método de la clase padre)
                int IDPersona = base.Insertar();

                SqlConnection conn = Conexion.AbrirConexion();

                //EL SQL para insertar en tabla PersonalAdministrativo
                string sql = "INSERT INTO PersonalAdministrativo (IDPersona, Departamento, Cargo, SalarioMensual) " +
                             "VALUES (@IDPersona, @Departamento, @Cargo, @SalarioMensual); " +
                             "SELECT CAST(SCOPE_IDENTITY() AS INT);";


                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDPersona", IDPersona);
                cmd.Parameters.AddWithValue("@Departamento", this.Departamento ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cargo", this.Cargo ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@SalarioMensual", this.Salario);

                //  Ejecutar y obtener el ID generado
                this.IDAdministrativo = (int)cmd.ExecuteScalar();

                // Cerrar conexión
                Conexion.CerrarConexion();

                return this.IDAdministrativo;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR AL INSERTAR PERSONAL ADMINISTRATIVO: " + ex.Message);
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

        // Método para actualizar datos del personal administrativo
        public bool Actualizar()
        {
            try
            {
                SqlConnection conn = Conexion.AbrirConexion();

                string sql = "UPDATE PersonalAdministrativo SET " +
                             "Departamento = @Departamento, " +
                             "Cargo = @Cargo, " +
                             "SalarioMensual = @SalarioMensual " +
                             "WHERE IDAdministrativo = @IDAdministrativo";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDAdministrativo", this.IDAdministrativo);
                cmd.Parameters.AddWithValue("@Departamento", this.Departamento ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cargo", this.Cargo ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@SalarioMensual", this.Salario);

                cmd.ExecuteNonQuery();
                Conexion.CerrarConexion();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR AL ACTUALIZAR PERSONAL ADMINISTRATIVO: " + ex.Message);
            }
            finally
            {
                Conexion.CerrarConexion();
            }

        }

    }

}