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
        public GestionCitas()
        {
            InitializeComponent();
        }

        private void CargarComboPacientes()
        {
            // Usamos la clase de conexión "CapaDatos"
            using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
            {
                // El  SQL DEBE TRAER LA COLUMNA IDPaciente EXPLICITAMENTE
                string sql = @"SELECT P.IDPaciente, Per.Nombre 
                       FROM Paciente P 
                       INNER JOIN Personas Per ON P.IDPersona = Per.IDPersona";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //el orden correcto 
                cboPaciente.DisplayMember = "Nombre";      
                cboPaciente.ValueMember = "IDPaciente";    
                cboPaciente.DataSource = dt;              

                cboPaciente.SelectedIndex = -1; // Limpiar selección inicial
            }
        }

        private void CargarComboDoctores()
        {
            using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
            {
                // SQL con IDDoctor
                string sql = @"SELECT D.IDDoctor, Per.Nombre 
                       FROM Doctor D 
                       INNER JOIN Personas Per ON D.IDPersona = Per.IDPersona";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // ORDEN CORRECTO
                cboDoctor.DisplayMember = "Nombre";
                cboDoctor.ValueMember = "IDDoctor"; 
                cboDoctor.DataSource = dt;         

                cboDoctor.SelectedIndex = -1;
            }
        }

        private void FormGestionCitas_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();

            // Configurar ComboBoxes con autocompletado
            cboPaciente.DropDownStyle = ComboBoxStyle.DropDown;
            cboPaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cboDoctor.DropDownStyle = ComboBoxStyle.DropDown;
            cboDoctor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboDoctor.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Llenar ComboBoxes
            CargarComboPacientes();
            CargarComboDoctores();

            // Cargar grid de citas para mostrar las existentes
            CargarGridCitas();



        }



        private void btnAgendar_Click(object sender, EventArgs e)
        {
            // Validar que haya selección, capturaores 
            if (cboPaciente.SelectedItem == null || cboDoctor.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un Paciente y un Doctor.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Por favor, ingrese un motivo para la cita.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                //Fila de datoos
                System.Data.DataRowView filaPaciente = (System.Data.DataRowView)cboPaciente.SelectedItem;
                System.Data.DataRowView filaDoctor = (System.Data.DataRowView)cboDoctor.SelectedItem;

                //Esto trae el ID exacto usando el nombre dela columna que pusimo en sql 
                int idPaciente = Convert.ToInt32(filaPaciente["IDPaciente"]);
                int idDoctor = Convert.ToInt32(filaDoctor["IDDoctor"]);

                // Recogemos el resto de datos
                DateTime fecha = dtpFecha.Value.Date; 
                TimeSpan hora = dtpHora.Value.TimeOfDay;
                string motivo = txtMotivo.Text.Trim();


                //Aqui llmamos a la capaDatosara guardar 
                CapaDatos.CD_Citas gestorCitas = new CapaDatos.CD_Citas();

                gestorCitas.AgendarCita(idPaciente, idDoctor, fecha, hora, motivo);

                MessageBox.Show("¡Cita agendada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agendar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGridCitas()
        {
            using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
            {
                string sql = @"SELECT 
                           c.IDCita,
                           pe.Nombre AS Paciente,
                           dpe.Nombre AS Doctor,
                           c.FechaCita,
                           c.HoraCita,
                           c.MotivoCita
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

                // Ajustes opcionales
                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCitas.ReadOnly = true;
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
            txtMotivo.Clear();
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
                string sql = @"SELECT 
                           c.IDCita,
                           pe.Nombre AS Paciente,
                           dpe.Nombre AS Doctor,
                           c.FechaCita,
                           c.HoraCita,
                           c.MotivoCita
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

                // Ajustes opcionales
                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCitas.ReadOnly = true;
            }
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
