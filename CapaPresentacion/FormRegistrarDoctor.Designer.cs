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
            textExequatur = new TextBox();
            label3 = new Label();
            textTarifa = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textusuario = new TextBox();
            textClave = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            textCedula = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textDoctor
            // 
            textDoctor.Location = new Point(151, 94);
            textDoctor.Margin = new Padding(2, 2, 2, 2);
            textDoctor.Name = "textDoctor";
            textDoctor.PlaceholderText = "Nombre Completo";
            textDoctor.Size = new Size(206, 27);
            textDoctor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(232, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(314, 33);
            label1.TabIndex = 1;
            label1.Text = "REISTRAR DOCTOR ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 98);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombre: ";
            label2.Click += label2_Click;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEspecialidad.Location = new Point(34, 133);
            lblEspecialidad.Margin = new Padding(2, 0, 2, 0);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(115, 21);
            lblEspecialidad.TabIndex = 3;
            lblEspecialidad.Text = "Especialidad:";
            lblEspecialidad.Click += lblEspecialidad_Click;
            // 
            // lblExequatur
            // 
            lblExequatur.AutoSize = true;
            lblExequatur.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExequatur.Location = new Point(48, 176);
            lblExequatur.Margin = new Padding(2, 0, 2, 0);
            lblExequatur.Name = "lblExequatur";
            lblExequatur.Size = new Size(98, 21);
            lblExequatur.TabIndex = 4;
            lblExequatur.Text = "Exequatur:";
            // 
            // txtespecialidad
            // 
            txtespecialidad.Location = new Point(151, 130);
            txtespecialidad.Margin = new Padding(2, 2, 2, 2);
            txtespecialidad.Name = "txtespecialidad";
            txtespecialidad.PlaceholderText = "Especialidad ";
            txtespecialidad.Size = new Size(206, 27);
            txtespecialidad.TabIndex = 5;
            // 
            // textExequatur
            // 
            textExequatur.Location = new Point(151, 170);
            textExequatur.Margin = new Padding(2, 2, 2, 2);
            textExequatur.Name = "textExequatur";
            textExequatur.PlaceholderText = "Exequatur";
            textExequatur.Size = new Size(206, 27);
            textExequatur.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 214);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 7;
            label3.Text = "Tarifa:";
            // 
            // textTarifa
            // 
            textTarifa.Location = new Point(151, 210);
            textTarifa.Margin = new Padding(2, 2, 2, 2);
            textTarifa.Name = "textTarifa";
            textTarifa.PlaceholderText = "Tarifa";
            textTarifa.Size = new Size(206, 27);
            textTarifa.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(68, 293);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 9;
            label4.Text = "Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(81, 334);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 10;
            label5.Text = "Clave:";
            // 
            // textusuario
            // 
            textusuario.Location = new Point(151, 293);
            textusuario.Margin = new Padding(2, 2, 2, 2);
            textusuario.Name = "textusuario";
            textusuario.PlaceholderText = "Usuario";
            textusuario.Size = new Size(206, 27);
            textusuario.TabIndex = 11;
            // 
            // textClave
            // 
            textClave.Location = new Point(151, 334);
            textClave.Margin = new Padding(2, 2, 2, 2);
            textClave.Name = "textClave";
            textClave.PlaceholderText = "Clave ";
            textClave.Size = new Size(206, 27);
            textClave.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(62, 397);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(108, 27);
            button1.TabIndex = 13;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(225, 397);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(110, 27);
            button2.TabIndex = 14;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(75, 254);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 15;
            label6.Text = "Cedula:";
            // 
            // textCedula
            // 
            textCedula.Location = new Point(151, 250);
            textCedula.Margin = new Padding(2, 2, 2, 2);
            textCedula.Name = "textCedula";
            textCedula.PlaceholderText = "Cedula";
            textCedula.Size = new Size(206, 27);
            textCedula.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 3);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 59);
            panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._new;
            pictureBox1.Location = new Point(454, 112);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 261);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(454, 418);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(250, 19);
            progressBar1.TabIndex = 19;
            progressBar1.Visible = false;
            progressBar1.Click += progressBar1_Click;
            // 
            // FormRegistrarDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(761, 458);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(textCedula);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textClave);
            Controls.Add(textusuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textTarifa);
            Controls.Add(label3);
            Controls.Add(textExequatur);
            Controls.Add(txtespecialidad);
            Controls.Add(lblExequatur);
            Controls.Add(lblEspecialidad);
            Controls.Add(label2);
            Controls.Add(textDoctor);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormRegistrarDoctor";
            Text = "FormRegistrarPers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox textExequatur;
        private Label label3;
        private TextBox textTarifa;
        private Label label4;
        private Label label5;
        private TextBox textusuario;
        private TextBox textClave;
        private Button button1;
        private Button button2;
        private Label label6;
        private TextBox textCedula;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
    }
}