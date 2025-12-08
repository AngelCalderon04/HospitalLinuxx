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

//INICIO
namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar que no estén vacíos
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
                {
                    MessageBox.Show("Ingrese usuario y contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
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
    }
}
