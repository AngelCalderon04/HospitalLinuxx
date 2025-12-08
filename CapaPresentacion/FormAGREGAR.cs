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
    public partial class FormAGREGAR : Form
    {
        public FormAGREGAR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistrarDoctor form = new FormRegistrarDoctor();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarEnfermero form = new RegistrarEnfermero();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReistrarPersonalADMIN form = new ReistrarPersonalADMIN();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
