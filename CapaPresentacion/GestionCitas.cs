using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using Microsoft.Data.SqlClient;
using Personas;
using Doctor;

namespace CapaPresentacion
{

    public partial class GestionCitas : Form


    {

        // TODO: Variables para controlar la edición
        private bool Editar = false;
        private int IDCitaSeleccionada = 0;
        public GestionCitas()
        {
            InitializeComponent();
        }

        private void CargarComboPacientes()
        {
            // TODO: Usamos la clase de conexion CapaDatos
            using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
            {
                // TODO: El  SQL DEBE TRAER LA COLUMNA IDPaciente EXPLICITAMENTE
                string sql = @"SELECT P.IDPaciente, Per.Nombre 
                       FROM Paciente P 
                       INNER JOIN Personas Per ON P.IDPersona = Per.IDPersona";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //TODO: el orden correcto 
                cboPaciente.DisplayMember = "Nombre";
                cboPaciente.ValueMember = "IDPaciente";
                cboPaciente.DataSource = dt;
                cboPaciente.SelectedIndex = -1; //TODO: Limpiar seleccion inicial
            }
        }

        private void CargarComboDoctores()
        {
            using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
            {
                conn.Open();
                // OJO AQUÍ: Estamos pidiendo 3 cosas: ID, Nombre y TARIFA
                string query = @"SELECT 
                            d.IDDoctor, 
                            p.Nombre, 
                            d.TarifaConsulta 
                        FROM Doctor d
                        INNER JOIN Personas p ON d.IDPersona = p.IDPersona";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Guardamos TODA la tabla en el combo (aunque solo mostremos el nombre)
                cboDoctor.DataSource = dt;
                cboDoctor.DisplayMember = "Nombre";      // Lo que ve el usuario
                cboDoctor.ValueMember = "IDDoctor";      // El valor real (ID)
            }
        }

        private void FormGestionCitas_Load(object sender, EventArgs e)
        {
            //TODO: se cargan los datos 
          
            CargarComboPacientes();
            CargarComboDoctores();
            CargarGridCitasData();

            //TODO: Deseleccionar los ComboBox (Para que aparezcan vacíos)
            cboPaciente.SelectedIndex = -1;
            cboDoctor.SelectedIndex = -1;

            dgvCitas.ClearSelection();

            // TODO: Quitar el foco para que no parpadee el cursor en la primera caja
            this.ActiveControl = null;


        }



        private void btnAgendar_Click(object sender, EventArgs e)
        {
            // TODO: Validar que haya selección, capturaores 
            if (cboPaciente.SelectedItem == null || cboDoctor.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un Paciente y un Doctor.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                CapaDatos.CD_Citas objetoCD = new CapaDatos.CD_Citas();

                // TODO: Recogemos datos
                int idPac = Convert.ToInt32(cboPaciente.SelectedValue);
                int idDoc = Convert.ToInt32(cboDoctor.SelectedValue);
                DateTime fecha = dtpFecha.Value;
                TimeSpan hora = dtpHora.Value.TimeOfDay;

                if (Editar == false)
                {
                    // TODO:  MODO GUARDAR NUEVO
                    objetoCD.AgendarCita(idPac, idDoc, fecha, hora, "");
                    MessageBox.Show("Cita agendada correctamente.");
                }
                else
                {
                    // TODO: MODO EDITAR 
                    objetoCD.EditarCita(IDCitaSeleccionada, idPac, idDoc, fecha, hora);
                    MessageBox.Show("Cita editada correctamente.");

                    //TODO: Volvemos al estado original
                    Editar = false;
                    IDCitaSeleccionada = 0;
                    btnAgendar.Text = "AGENDAR"; // Regresamos el texto original
                }

                // TODO: LIMPIEZA FINAL
                CargarGridCitas(); // Refrescar tabla
                LimpiarFormulario(); // Metodo para borrar textos 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // TODO: Mtodo paralimpiar los campos 
        private void LimpiarFormulario()
        {
            // TODO: Reseteamos los ComboBox para que no tengan nada seleccionado
            cboPaciente.SelectedIndex = -1;
            cboDoctor.SelectedIndex = -1;

            //TODO:  Reseteamos las fechas al día de hoy
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;

            // TODO:  Limpiamos cajas de texto 
            // txtMotivo.Clear(); // Descomenta si usas motivo
            if (Controls.Find("txtCosto", true).Length > 0)
                Controls.Find("txtCosto", true)[0].Text = ""; // Limpia costo si existe

            // TODO: Variable de edicions 
            Editar = false;
            IDCitaSeleccionada = 0;

            // TODO: Regresamos el boton a su estado original
            btnAgendar.Text = "AGENDAR";
        }

        private void CargarGridCitas()
        {
            using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
            {
              
                //TODO:el sql correcto con los IDs ocultos 
                string sql = @"SELECT 
                    c.IDCita,
                    c.IDPaciente,
                    c.IDDoctor,
                    pe.Nombre AS Paciente,
                    dpe.Nombre AS Doctor,
                    c.FechaCita,
                    c.HoraCita,
                    d.TarifaConsulta AS Costo
                FROM Citas c
                INNER JOIN Paciente p ON c.IDPaciente = p.IDPaciente
                INNER JOIN Personas pe ON p.IDPersona = pe.IDPersona
                INNER JOIN Doctor d ON c.IDDoctor = d.IDDoctor
                INNER JOIN Personas dpe ON d.IDPersona = dpe.IDPersona
                ORDER BY c.FechaCita, c.HoraCita";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //TODO:Solucion 

             
                //TODO: estolimpia os datosviejos de a tabla 
                dgvCitas.DataSource = null;
                dgvCitas.Columns.Clear();

                // TODO: Le decimos que genere todo nuevo automaticamente
                dgvCitas.AutoGenerateColumns = true;

                //TODO: Le damos los datos editados 
                dgvCitas.DataSource = dt;

        
                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCitas.ReadOnly = true;

                // TODO: Ocultar los IDs (Usamos 'Contains' para que no explote si no existen)
                if (dgvCitas.Columns.Contains("IDPaciente")) dgvCitas.Columns["IDPaciente"].Visible = false;
                if (dgvCitas.Columns.Contains("IDDoctor")) dgvCitas.Columns["IDDoctor"].Visible = false;
                if (dgvCitas.Columns.Contains("IDCita")) dgvCitas.Columns["IDCita"].Visible = false;

                // Formato Moneda
                if (dgvCitas.Columns.Contains("Costo")) dgvCitas.Columns["Costo"].DefaultCellStyle.Format = "C2";
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        private void LimpiarCampos()
        {
            cboPaciente.Text = "";
            cboDoctor.Text = "";
            dtpFecha.Value = DateTime.Today;
            dtpHora.Value = DateTime.Now;
            //txtMotivo.Clear();
            cboPaciente.Focus();
        }


        private void dvgCitas()
        {

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificamos que sea un doctor válido y no la selección vacía (-1)
            if (cboDoctor.SelectedIndex != -1 && cboDoctor.SelectedItem is DataRowView)
            {
                try
                {
                    //  Convertimos el ítem seleccionado a una Fila de Datos
                    DataRowView fila = (DataRowView)cboDoctor.SelectedItem;

                    // Buscamos la columna "TarifaConsulta" (que trajimos en el SQL oculto)
                    decimal tarifa = Convert.ToDecimal(fila["TarifaConsulta"]);

                    // La ponemos en el TextBox txtCosto con formato de dinero
                    txtcosto.Text = tarifa.ToString("C2"); // Muestra: $ 2,500.00
                }
                catch
                {
                    // Si algo falla, ponemos 0
                    txtcosto.Text = "$ 0.00";
                }
            }
        }

        private bool ObtenerIDPacientePorNombre(string nombre, out int idPaciente)
        {
            idPaciente = 0;
            using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
            {
                string sql = "SELECT IDPaciente FROM Paciente p INNER JOIN Personas pe ON p.IDPersona = pe.IDPersona WHERE pe.Nombre=@Nombre";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    idPaciente = Convert.ToInt32(result);
                    return true;
                }
            }
            return false;
        }

        private bool ObtenerIDDoctorPorNombre(string nombre, out int idDoctor)
        {
            idDoctor = 0;
            using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
            {
                string sql = "SELECT IDDoctor FROM Doctor d INNER JOIN Personas pe ON d.IDPersona = pe.IDPersona WHERE pe.Nombre=@Nombre";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    idDoctor = Convert.ToInt32(result);
                    return true;
                }
            }
            return false;
        }

        private void CargarGridCitasData()
        {
            using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
            {
                // 1. AGREGAMOS c.IDPaciente Y c.IDDoctor AL SELECT
                string sql = @"SELECT 
            c.IDCita,
            c.IDPaciente,   -- <--- ¡ESTO ES LO QUE TE FALTA!
            c.IDDoctor,     -- <--- ¡ESTO TAMBIÉN!
            pe.Nombre AS Paciente,
            dpe.Nombre AS Doctor,
            c.FechaCita,
            c.HoraCita,
            d.TarifaConsulta AS Costo
        
        FROM Citas c
        INNER JOIN Paciente p ON c.IDPaciente = p.IDPaciente
        INNER JOIN Personas pe ON p.IDPersona = pe.IDPersona
        INNER JOIN Doctor d ON c.IDDoctor = d.IDDoctor
        INNER JOIN Personas dpe ON d.IDPersona = dpe.IDPersona
        ORDER BY c.FechaCita, c.HoraCita";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCitas.DataSource = dt;

                 //TODO: esteticoss raros de indio 
                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCitas.ReadOnly = true;

                
                if (dgvCitas.Columns.Contains("IDPaciente")) dgvCitas.Columns["IDPaciente"].Visible = false;
                if (dgvCitas.Columns.Contains("IDDoctor")) dgvCitas.Columns["IDDoctor"].Visible = false;

                // TODO: Formato moneda para el costo (si lo tienes)
                if (dgvCitas.Columns.Contains("Costo")) dgvCitas.Columns["Costo"].DefaultCellStyle.Format = "C2";
            }
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //TODO Verificacion si hay fila seleccionadad 
            if (dgvCitas.SelectedRows.Count > 0)
            {
               // TODO Cambiar el modo a "EDITAR"
                Editar = true;


                try
                {
                    // TODO se obtiene el ID (Usando SelectedRows[0]
                    IDCitaSeleccionada = Convert.ToInt32(dgvCitas.SelectedRows[0].Cells["IDCita"].Value);

                    
                    cboPaciente.SelectedValue = Convert.ToInt32(dgvCitas.SelectedRows[0].Cells["IDPaciente"].Value);
                    cboDoctor.SelectedValue = Convert.ToInt32(dgvCitas.SelectedRows[0].Cells["IDDoctor"].Value);

                    // TODO Fechas y Horas
                    dtpFecha.Value = Convert.ToDateTime(dgvCitas.SelectedRows[0].Cells["FechaCita"].Value);

                    DateTime fechaCompleta = Convert.ToDateTime(dgvCitas.SelectedRows[0].Cells["FechaCita"].Value);
                    TimeSpan horaCita = (TimeSpan)dgvCitas.SelectedRows[0].Cells["HoraCita"].Value;
                    dtpHora.Value = fechaCompleta.Date + horaCita;

                    // TODO se cambia el botón para que el usuario sepa que va a actualizar
                    btnAgendar.Text = "ACTUALIZAR";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos para editar: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
            }
        }
    }

}
