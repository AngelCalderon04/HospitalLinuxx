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
    public partial class FormRegistrarDoctor : Form
    {
        public FormRegistrarDoctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// 1. VALIDACIÓN: Agregamos txtCedula a la lista de obligatorios
            if (string.IsNullOrWhiteSpace(textDoctor.Text) ||
                string.IsNullOrWhiteSpace(textCedula.Text) || // <--- NUEVO
                string.IsNullOrWhiteSpace(txtespecialidad.Text) ||
                string.IsNullOrWhiteSpace(textExequatur.Text) ||
                string.IsNullOrWhiteSpace(textTarifa.Text) ||
                string.IsNullOrWhiteSpace(textusuario.Text) ||
                string.IsNullOrWhiteSpace(textClave.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos (incluida la Cédula).", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. CONVERSIÓN TARIFA
            decimal tarifa = 0;
            if (!decimal.TryParse(textTarifa.Text, out tarifa))
            {
                MessageBox.Show("La tarifa debe ser un número válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 3. LLAMADA A LA CAPA DE DATOS
                CapaDatos.CD_Doctor objetoDoctor = new CapaDatos.CD_Doctor();

                objetoDoctor.RegistrarDoctor(
                    textDoctor.Text.Trim(),      // Nombre
                    textCedula.Text.Trim(),      // <--- AQUÍ ENVIAMOS LA CÉDULA REAL AHORA
                    "",                         // Telefono (Sigue vacío si no lo tienes)
                    "",                         // Email (Sigue vacío si no lo tienes)
                    txtespecialidad.Text.Trim(),// Especialidad
                    textExequatur.Text.Trim(),   // Exequatur
                    tarifa,                     // Tarifa
                    textusuario.Text.Trim(),     // Usuario
                    textClave.Text.Trim()        // Clave
                );

                // 4. CONFIRMACIÓN
                MessageBox.Show("¡Doctor registrado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblEspecialidad_Click(object sender, EventArgs e)
        {

        }
    }
}
