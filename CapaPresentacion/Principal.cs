using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        // --- ESTA ES LA PARTE CLAVE DEL LOGIN ---
        private void Principal_Load(object sender, EventArgs e)
        {
            // 1. Ocultamos el menú principal apenas arranca para que no se vea
            this.Hide();

            // 2. Abrimos el formulario de Login como una ventana "Modal" (bloqueante)
            // Asegúrate de haber creado ya el FrmLogin como te indiqué en el paso anterior
            FrmLogin login = new FrmLogin();
            DialogResult respuesta = login.ShowDialog();

            // 3. Verificamos qué pasó en el Login
            if (respuesta == DialogResult.OK)
            {
                // Si el usuario puso la clave bien (DialogResult.OK), mostramos el menú
                this.Show();
            }
            else
            {
                // Si el usuario cerró el login o le dio a Cancelar, matamos la aplicación completa
                Application.Exit();
            }
        }
        // ----------------------------------------

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            FormRegistroPaciente form = new FormRegistroPaciente();
            form.ShowDialog();
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            GestionCitas form = new GestionCitas();
            form.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorialMedico form = new FrmHistorialMedico();
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea salir del sistema?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegistrarCONS_Click(object sender, EventArgs e)
        {
            FormRegistrarConsulta form = new FormRegistrarConsulta();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Botón vacío
        }
    }
}
