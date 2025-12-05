using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pacientes;

namespace CapaPresentacion
{
    public partial class FrmHistorialMedico : Form
    {
        public FrmHistorialMedico()
        {
            InitializeComponent();


        }

        private void FrmHistorialMedico_Load(object sender, EventArgs e)
        {
            // Carga la lista de pacientes en el ComboBox cuando se abre el form
            CargarPacientes();

            // Configura el DataGridView
            ConfigurarDataGridView();
        }

        private void CargarPacientes()
        {
            try
            {
               
                // Instancia la clase CD_Paciente
                CapaDatos.CD_Paciente gestor = new CapaDatos.CD_Paciente();


                //Metodo para el metodo dela lista de pacientes que vendran desde Sql
                DataTable dtPacientes = gestor.Listar();

                // Configurar el ComboBox
                cmbPacientes.DataSource = dtPacientes;
                cmbPacientes.DisplayMember = "Nombre";
                cmbPacientes.ValueMember = "IDPaciente";

                cmbPacientes.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbPacientes.SelectedIndex = -1;
                cmbPacientes.Text = "Seleccione un paciente...";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de pacientes: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            // Configuraciones visuales para que se vea bien
            dgvHistorial.ReadOnly = true;
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Este evento se dispara CADA VEZ que seleccionas un paciente diferente
        private void cmbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificamos que haya un ítem seleccionado
            if (cmbPacientes.SelectedItem != null)
            {
                try
                {
                    // Obtener el ID del paciente (conversión segura)
                    DataRowView drv = (DataRowView)cmbPacientes.SelectedItem;
                    int idPacienteSeleccionado = Convert.ToInt32(drv["IDPaciente"]);

                    CapaDatos.CD_HistorialMedico gestor = new CapaDatos.CD_HistorialMedico();

                    // Llamamos al metodo desde el gestor sql
                    DataTable dtHistorial = gestor.ObtenerHistorialPorPaciente(idPacienteSeleccionado);

                    // -------------------------------------

                    // Asignar al Grid
                    dgvHistorial.DataSource = dtHistorial;

                    // Mensajes opcionales
                    if (dtHistorial.Rows.Count == 0 && cmbPacientes.SelectedIndex > -1)
                    {
                        MessageBox.Show("El paciente seleccionado no tiene historial.", "Aviso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
