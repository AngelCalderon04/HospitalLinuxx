using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CapaPresentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            progressBar1.Visible = false;
        }

        // --- ESTA ES LA PARTE CLAVE DEL LOGIN ---
        private async void Principal_Load(object sender, EventArgs e)
        {
            this.Hide();

            FrmLogin login = new FrmLogin();
            DialogResult respuesta = login.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                progressBar1.Visible = true;
                progressBar1.Value = 0;

                for (int i = 0; i <= 100; i++)
                {
                    progressBar1.Value = i;
                    await Task.Delay(10);
                }

                progressBar1.Visible = false;
                this.Show();
            }
            else
            {
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
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FormAGREGAR form = new FormAGREGAR();
            form.ShowDialog();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
