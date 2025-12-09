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
        {
            // 1. VALIDACIÓN
            // CORRECCIÓN: Fíjate que el paréntesis de cierre del IF ')' está AL FINAL de todo.
            if (string.IsNullOrWhiteSpace(textDoctor.Text) ||
                string.IsNullOrWhiteSpace(textCedula.Text) ||
                string.IsNullOrWhiteSpace(textExequatur.Text) ||
                string.IsNullOrWhiteSpace(textTarifa.Text) ||
                string.IsNullOrWhiteSpace(textusuario.Text) ||
                string.IsNullOrWhiteSpace(textClave.Text) ||
                string.IsNullOrWhiteSpace(cboEspecialidad.Text)) // <--- Ahora sí está dentro
            {
                MessageBox.Show("Por favor, complete todos los campos (incluida la Especialidad).", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // CONVERSIÓN TARIFA
            decimal tarifa = 0;
            if (!decimal.TryParse(textTarifa.Text, out tarifa))
            {
                MessageBox.Show("La tarifa debe ser un número válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // LLAMADA A LA CAPA DE DATOS
                CapaDatos.CD_Doctor objetoDoctor = new CapaDatos.CD_Doctor();

                objetoDoctor.RegistrarDoctor(
                    textDoctor.Text.Trim(),       // Nombre
                    textCedula.Text.Trim(),       // Cédula
                    "",                           // Telefono (Vacío)
                    "",                           // Email (Vacío)
                    cboEspecialidad.Text,         // <--- USAMOS EL TEXTO DEL COMBOBOX
                    textExequatur.Text.Trim(),    // Exequatur
                    tarifa,                       // Tarifa
                    textusuario.Text.Trim(),      // Usuario
                    textClave.Text.Trim()         // Clave
                );

                // CONFIRMACIÓN
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

        // Estos métodos vacíos los puedes borrar si no los usas, pero no afectan.
        private void label2_Click(object sender, EventArgs e) { }
        private void lblEspecialidad_Click(object sender, EventArgs e) { }
        private void txtespecialidad_TextChanged(object sender, EventArgs e) { }
    }
}