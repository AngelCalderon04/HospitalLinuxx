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
    public partial class FormRegistrarDoctor : Form
    {
        public FormRegistrarDoctor()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {// 1. VALIDACIÓN: Agregamos txtCedula a la lista de obligatorios
            if (string.IsNullOrWhiteSpace(textDoctor.Text) ||
                string.IsNullOrWhiteSpace(textCedula.Text) ||
                string.IsNullOrWhiteSpace(txtespecialidad.Text) ||
                string.IsNullOrWhiteSpace(textExequatur.Text) ||
                string.IsNullOrWhiteSpace(textTarifa.Text) ||
                string.IsNullOrWhiteSpace(textusuario.Text) ||
                string.IsNullOrWhiteSpace(textClave.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos (incluida la Cédula).", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tarifa = 0;
            if (!decimal.TryParse(textTarifa.Text, out tarifa))
            {
                MessageBox.Show("La tarifa debe ser un número válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                progressBar1.Value = 0;
                progressBar1.Visible = true;
                progressBar1.Maximum = 100;

                for (int i = 0; i <= 100; i++)
                {
                    progressBar1.Value = i;
                    await Task.Delay(30); // 3 segundos
                }

                CapaDatos.CD_Doctor objetoDoctor = new CapaDatos.CD_Doctor();

                objetoDoctor.RegistrarDoctor(
                    textDoctor.Text.Trim(),
                    textCedula.Text.Trim(),
                    "",
                    "",
                    txtespecialidad.Text.Trim(),
                    textExequatur.Text.Trim(),
                    tarifa,
                    textusuario.Text.Trim(),
                    textClave.Text.Trim()
                );

                MessageBox.Show("¡Doctor registrado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                progressBar1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblEspecialidad_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}