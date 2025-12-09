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
    public partial class FormAGREGAR : Form
    {
        public FormAGREGAR()
        {
            InitializeComponent();
            progressBar1.Visible = false;
        }

        private async Task MostrarCargaAsync()
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;

            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(30);
                progressBar1.Value = i;
            }

            progressBar1.Visible = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await MostrarCargaAsync();
            FormRegistrarDoctor form = new FormRegistrarDoctor();
            form.ShowDialog();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await MostrarCargaAsync();
            RegistrarEnfermero form = new RegistrarEnfermero();
            form.ShowDialog();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await MostrarCargaAsync();
            ReistrarPersonalADMIN form = new ReistrarPersonalADMIN();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}