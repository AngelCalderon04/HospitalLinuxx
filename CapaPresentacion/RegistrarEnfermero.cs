using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class RegistrarEnfermero : Form
    {
        public RegistrarEnfermero()
        {
            InitializeComponent();

            progressBar1.Visible = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // 1. VALIDAR
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(textcedula.Text) ||
                string.IsNullOrWhiteSpace(cboTurno.Text) ||
                string.IsNullOrWhiteSpace(textArea.Text) ||
                string.IsNullOrWhiteSpace(textusuario.Text) ||
                string.IsNullOrWhiteSpace(textclave.Text))
            {
                MessageBox.Show("Por favor complete los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                progressBar1.Visible = true;
                progressBar1.Value = 0;

                for (int i = 0; i <= 100; i++)
                {
                    progressBar1.Value = i;
                    await Task.Delay(10);
                }

                // 2. GUARDAR
                CapaDatos.CD_Enfermero objetoEnfermero = new CapaDatos.CD_Enfermero();

                objetoEnfermero.RegistrarEnfermero(
                    txtNombre.Text.Trim(),
                    textcedula.Text.Trim(),
                    "",
                    "",
                    cboTurno.Text,
                    textArea.Text.Trim(),
                    textusuario.Text.Trim(),
                    textclave.Text.Trim()
                );

                MessageBox.Show("¡Enfermero y Usuario registrados con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textcedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
