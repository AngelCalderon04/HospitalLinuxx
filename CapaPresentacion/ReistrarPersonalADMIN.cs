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
    public partial class ReistrarPersonalADMIN : Form
    {
        public ReistrarPersonalADMIN()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. VALIDAR CAMPOS
            if (string.IsNullOrWhiteSpace(textNombre.Text) ||
                string.IsNullOrWhiteSpace(textCedula.Text) ||
                string.IsNullOrWhiteSpace(comboCargo.Text) ||
                string.IsNullOrWhiteSpace(comboDepartamento.Text) ||
                string.IsNullOrWhiteSpace(textSalario.Text) ||
                string.IsNullOrWhiteSpace(textUsuario.Text) ||
                string.IsNullOrWhiteSpace(textClave.Text))
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. VALIDAR Y CONVERTIR SALARIO
            decimal salario = 0;
            if (!decimal.TryParse(textSalario.Text, out salario))
            {
                MessageBox.Show("El salario debe ser un número válido (ej. 15000.00).", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 3. GUARDAR DATOS
                CapaDatos.CD_PersonalAdministrativo logica = new CapaDatos.CD_PersonalAdministrativo();

                logica.RegistrarAdministrativo(
                    textNombre.Text.Trim(),      // Nombre
                    textCedula.Text.Trim(),      // Cédula
                    "",                         // Teléfono (Manda vacío si no tienes el textbox)
                    "",                         // Email (Manda vacío si no tienes el textbox)
                    comboDepartamento.Text,       // Departamento (del ComboBox)
                    comboCargo.Text,              // Cargo (del ComboBox o TextBox)
                    salario,                    // Salario decimal
                    textUsuario.Text.Trim(),     // Usuario
                    textClave.Text.Trim()        // Clave
                );

                MessageBox.Show("¡Administrativo registrado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReistrarPersonalADMIN_Load(object sender, EventArgs e)
        {
            // Limpiar selección de combos
            if (comboDepartamento.Items.Count > 0) comboDepartamento.SelectedIndex = -1;
            if (comboCargo.Items.Count > 0) comboCargo.SelectedIndex = -1;

            // Quitar foco inicial
            this.ActiveControl = null;
        }
    }
}
