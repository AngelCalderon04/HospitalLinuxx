using CapaDatos;
using Doctor;
using Microsoft.Data.SqlClient;
using Personas;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{

    public partial class GestionCitas : Form
    {
        private bool Editar = false;
        private int IDCitaSeleccionada = 0;

        public GestionCitas()
        {
            InitializeComponent();
            progressBar1.Visible = false;
        }

        private void CargarComboPacientes()
        {
            using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
            {
                string sql = @"SELECT P.IDPaciente, Per.Nombre 
                       FROM Paciente P 
                       INNER JOIN Personas Per ON P.IDPersona = Per.IDPersona";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboPaciente.DisplayMember = "Nombre";
                cboPaciente.ValueMember = "IDPaciente";
                cboPaciente.DataSource = dt;

                cboPaciente.SelectedIndex = -1;
            }
        }

        private void CargarComboDoctores()
        {
            using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
            {
                string sql = @"SELECT D.IDDoctor, Per.Nombre 
                       FROM Doctor D 
                       INNER JOIN Personas Per ON D.IDPersona = Per.IDPersona";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboDoctor.DisplayMember = "Nombre";
                cboDoctor.ValueMember = "IDDoctor";
                cboDoctor.DataSource = dt;

                cboDoctor.SelectedIndex = -1;
            }
        }

        private void FormGestionCitas_Load(object sender, EventArgs e)
        {
            CargarComboPacientes();
            CargarComboDoctores();
            CargarGridCitasData();

            cboPaciente.SelectedIndex = -1;
            cboDoctor.SelectedIndex = -1;
            dgvCitas.ClearSelection();
            this.ActiveControl = null;
        }

        private async void btnAgendar_Click(object sender, EventArgs e)
        {
            if (cboPaciente.SelectedItem == null || cboDoctor.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un Paciente y un Doctor.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            progressBar1.Visible = true;
            progressBar1.Value = 0;

            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(10);
            }

            try
            {
                CapaDatos.CD_Citas objetoCD = new CapaDatos.CD_Citas();

                int idPac = Convert.ToInt32(cboPaciente.SelectedValue);
                int idDoc = Convert.ToInt32(cboDoctor.SelectedValue);
                DateTime fecha = dtpFecha.Value;
                TimeSpan hora = dtpHora.Value.TimeOfDay;

                if (Editar == false)
                {
                    objetoCD.AgendarCita(idPac, idDoc, fecha, hora, "");
                    MessageBox.Show("Cita agendada correctamente.");
                }
                else
                {
                    objetoCD.EditarCita(IDCitaSeleccionada, idPac, idDoc, fecha, hora);
                    MessageBox.Show("Cita editada correctamente.");

                    Editar = false;
                    IDCitaSeleccionada = 0;
                    btnAgendar.Text = "AGENDAR";
                }

                CargarGridCitas();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            progressBar1.Visible = false;
        }

        private void LimpiarFormulario()
        {
            cboPaciente.SelectedIndex = -1;
            cboDoctor.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;

            if (Controls.Find("txtCosto", true).Length > 0)
                Controls.Find("txtCosto", true)[0].Text = "";

            Editar = false;
            IDCitaSeleccionada = 0;
            btnAgendar.Text = "AGENDAR";
        }

        private void CargarGridCitas()
        {
            using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
            {
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

                dgvCitas.DataSource = null;
                dgvCitas.Columns.Clear();
                dgvCitas.AutoGenerateColumns = true;
                dgvCitas.DataSource = dt;

                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCitas.ReadOnly = true;

                if (dgvCitas.Columns.Contains("IDPaciente")) dgvCitas.Columns["IDPaciente"].Visible = false;
                if (dgvCitas.Columns.Contains("IDDoctor")) dgvCitas.Columns["IDDoctor"].Visible = false;
                if (dgvCitas.Columns.Contains("IDCita")) dgvCitas.Columns["IDCita"].Visible = false;

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
            cboPaciente.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count > 0)
            {
                Editar = true;
                IDCitaSeleccionada = Convert.ToInt32(dgvCitas.CurrentRow.Cells["IDCita"].Value);

                cboPaciente.SelectedValue = Convert.ToInt32(dgvCitas.CurrentRow.Cells["IDPaciente"].Value);
                cboDoctor.SelectedValue = Convert.ToInt32(dgvCitas.CurrentRow.Cells["IDDoctor"].Value);

                dtpFecha.Value = Convert.ToDateTime(dgvCitas.CurrentRow.Cells["FechaCita"].Value);

                dtpHora.Value = Convert.ToDateTime(dgvCitas.CurrentRow.Cells["FechaCita"].Value).Date +
                                (TimeSpan)dgvCitas.CurrentRow.Cells["HoraCita"].Value;

                btnAgendar.Text = "ACTUALIZAR";
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
            }
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvgCitas()
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
            c.IDPaciente,
            c.IDDoctor,
            pe.Nombre AS Paciente,
            dpe.Nombre AS Doctor,
            c.FechaCita,
            c.HoraCita,
            d.TarifaConsulta AS Costo
        
        FROM Citas c
        INNER JOIN Paciente p ON c.IDPaciente = p.IDPaciente
        INNER INNER JOIN Personas pe ON p.IDPersona = pe.IDPersona
        INNER JOIN Doctor d ON c.IDDoctor = d.IDDoctor
        INNER JOIN Personas dpe ON d.IDPersona = dpe.IDPersona
        ORDER BY c.FechaCita, c.HoraCita";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCitas.DataSource = dt;

                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCitas.ReadOnly = true;

                if (dgvCitas.Columns.Contains("IDPaciente")) dgvCitas.Columns["IDPaciente"].Visible = false;
                if (dgvCitas.Columns.Contains("IDDoctor")) dgvCitas.Columns["IDDoctor"].Visible = false;

                if (dgvCitas.Columns.Contains("Costo")) dgvCitas.Columns["Costo"].DefaultCellStyle.Format = "C2";
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}