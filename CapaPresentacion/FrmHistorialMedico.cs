using System;
using System.Data;
using System.Windows.Forms;

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
            // Implementación real en tu versión; aquí hay una plantilla mínima
            try
            {
                CargarPacientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }

        private void CargarPacientes()
        {
            // Lógica real en tu proyecto. Si usas gestor.Listar(), mantenla aquí.
            // Esta implementación evita errores de compilación si está vacía.
        }

        private void cmbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica para cambiar selección de paciente (tu código original)
        }

        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Manejo de click en grid si lo necesitas
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
