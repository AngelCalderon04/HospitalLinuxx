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
            lblEspecialidad.Location = new Point(132, 169);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(113, 25);
            lblEspecialidad.TabIndex = 3;
            lblEspecialidad.Text = "Especialidad:";
            // 
            // lblExequatur
            // 
            lblExequatur.AutoSize = true;
            lblExequatur.Location = new Point(137, 257);
            lblExequatur.Name = "lblExequatur";
            lblExequatur.Size = new Size(94, 25);
            lblExequatur.TabIndex = 4;
            lblExequatur.Text = "Exequatur:";
            // 
            // txtespecialidad
            // 
            txtespecialidad.Location = new Point(266, 166);
            txtespecialidad.Name = "txtespecialidad";
            txtespecialidad.Size = new Size(192, 31);
            txtespecialidad.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(280, 255);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 340);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 7;
            label3.Text = "Tarifa:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(254, 340);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 8;
            // 
            // FormRegistrarDoctor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}