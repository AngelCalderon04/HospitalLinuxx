namespace CapaPresentacion
{
    partial class FormRegistrarDoctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textDoctor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblEspecialidad = new Label();
            lblExequatur = new Label();
            txtespecialidad = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // textDoctor
            // 
            textDoctor.Location = new Point(254, 104);
            textDoctor.Name = "textDoctor";
            textDoctor.Size = new Size(204, 31);
            textDoctor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 38);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 1;
            label1.Text = "REISTRAR DOCTOR ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 104);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre: ";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(122, 166);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(113, 25);
            lblEspecialidad.TabIndex = 3;
            lblEspecialidad.Text = "Especialidad:";
            // 
            // lblExequatur
            // 
            lblExequatur.AutoSize = true;
            lblExequatur.Location = new Point(132, 230);
            lblExequatur.Name = "lblExequatur";
            lblExequatur.Size = new Size(94, 25);
            lblExequatur.TabIndex = 4;
            lblExequatur.Text = "Exequatur:";
            // 
            // txtespecialidad
            // 
            txtespecialidad.Location = new Point(254, 166);
            txtespecialidad.Name = "txtespecialidad";
            txtespecialidad.Size = new Size(192, 31);
            txtespecialidad.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(254, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 31);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 288);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 7;
            label3.Text = "Tarifa:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(254, 288);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 31);
            textBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 360);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 9;
            label4.Text = "Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(132, 437);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 10;
            label5.Text = "Contrasena: ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(254, 354);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 31);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(254, 437);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(192, 31);
            textBox4.TabIndex = 12;
            // 
            // FormRegistrarDoctor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 513);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(txtespecialidad);
            Controls.Add(lblExequatur);
            Controls.Add(lblEspecialidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textDoctor);
            Name = "FormRegistrarDoctor";
            Text = "FormRegistrarPers";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textDoctor;
        private Label label1;
        private Label label2;
        private Label lblEspecialidad;
        private Label lblExequatur;
        private TextBox txtespecialidad;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}