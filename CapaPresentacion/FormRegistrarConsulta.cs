using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using Microsoft.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class FormRegistrarConsulta : Form
    {
        public FormRegistrarConsulta()
        {
            InitializeComponent();
        }



        private void FormRegistrarConsulta_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            // Configuracion de  ComboBoxes para autocompletado
            cboPaciente.DropDownStyle = ComboBoxStyle.DropDown;
            cboPaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cboDoctor.DropDownStyle = ComboBoxStyle.DropDown;
            cboDoctor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboDoctor.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Cargar datos en los combos
            CargarComboPacientes();
            CargarComboDoctores();
        }

        private void CargarComboPacientes()
        {
            {
                using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
                {
                    string sql = @"SELECT p.IDPaciente, pe.Nombre
                       FROM Paciente p
                       INNER JOIN Personas pe ON p.IDPersona = pe.IDPersona";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboPaciente.DataSource = dt;
                    cboPaciente.DisplayMember = "Nombre";
                    cboPaciente.ValueMember = "IDPaciente";
                    cboPaciente.SelectedIndex = -1;

                    // Autocompletado
                    AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
                    foreach (DataRow row in dt.Rows) auto.Add(row["Nombre"].ToString());
                    cboPaciente.AutoCompleteCustomSource = auto;
                }
            }
        }

        private void CargarComboDoctores()
        {

            using (SqlConnection conn = new ConexionDatos().ObtenerConexion())
            {
                string sql = @"SELECT d.IDDoctor, pe.Nombre
                       FROM Doctor d
                       INNER JOIN Personas pe ON d.IDPersona = pe.IDPersona";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboDoctor.DataSource = dt;
                cboDoctor.DisplayMember = "Nombre";
                cboDoctor.ValueMember = "IDDoctor";
                cboDoctor.SelectedIndex = -1;

                // Autocompletado
                AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
                foreach (DataRow row in dt.Rows) auto.Add(row["Nombre"].ToString());
                cboDoctor.AutoCompleteCustomSource = auto;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones, capturadores de errores 
            if (cboPaciente.SelectedValue == null || cboDoctor.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un paciente y un doctor.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener datos del formulario
            int idPaciente = Convert.ToInt32(cboPaciente.SelectedValue);
            int idDoctor = Convert.ToInt32(cboDoctor.SelectedValue);
            string motivo = txtMotivo.Text.Trim();
            string diagnostico = txtDiagnostico.Text.Trim();
            string tratamiento = txtTratamiento.Text.Trim();
            string observaciones = txtObservaciones.Text.Trim();

            //Capturador de error 

            if (string.IsNullOrEmpty(motivo))
            {
                MessageBox.Show("Debe ingresar el motivo de la consulta.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                //Aqui llama de la capaDatos los query 
                CD_HistorialMedico gestor = new CD_HistorialMedico();


                gestor.RegistrarConsulta(
                    idPaciente,
                    idDoctor,
                    motivo,       // Esto corresponde a sintomas 
                    diagnostico,
                    tratamiento,
                    observaciones
                );

                MessageBox.Show("Consulta registrada correctamente en el historial.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la consulta: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimpiarCampos()
        {
            cboPaciente.SelectedIndex = -1;
            cboDoctor.SelectedIndex = -1;
            txtMotivo.Clear();
            txtDiagnostico.Clear();
            txtTratamiento.Clear();
            txtObservaciones.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblObservaciones_Click(object sender, EventArgs e)
        {

        }
    }




}

