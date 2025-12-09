using CapaDatos;
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

//INICIO
namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar que no estén vacíos
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
                {
                    MessageBox.Show("Ingrese usuario y contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                progressBar1.Value = 0;
                progressBar1.Visible = true;
                progressBar1.Maximum = 100;

                for (int i = 0; i <= 100; i++)
                {
                    progressBar1.Value = i;
                    await Task.Delay(50);
                }

                // 2. Llamar a la Capa de Datos
                CD_Usuario logica = new CD_Usuario();
                bool accesoCorrecto = logica.Login(txtUsuario.Text, txtClave.Text);

                if (accesoCorrecto)
                {
                    // ¡MAGIA! Esto le dice al formulario principal "Todo salió bien"
                    this.DialogResult = DialogResult.OK;
                    this.Close(); // Cerramos el Login como pide el maestro
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClave.Clear();
                    txtUsuario.Focus();
                }

                progressBar1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            // Si cancelan, cerramos la aplicación
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            label3.Focus();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}