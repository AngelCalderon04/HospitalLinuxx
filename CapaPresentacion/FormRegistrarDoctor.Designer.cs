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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textDoctor
            // 
            textDoctor.Location = new Point(189, 118);
            textDoctor.Name = "textDoctor";
            textDoctor.PlaceholderText = "Nombre Completo";
            textDoctor.Size = new Size(257, 31);
            textDoctor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(290, 26);
            label1.Name = "label1";
            label1.Size = new Size(362, 38);
            label1.TabIndex = 1;
            label1.Text = "REISTRAR DOCTOR ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 122);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 2;
            label2.Text = "Nombre: ";
            label2.Click += label2_Click;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEspecialidad.Location = new Point(43, 166);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(131, 23);
            lblEspecialidad.TabIndex = 3;
            lblEspecialidad.Text = "Especialidad:";
            lblEspecialidad.Click += lblEspecialidad_Click;
            // 
            // lblExequatur
            // 
            lblExequatur.AutoSize = true;
            lblExequatur.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExequatur.Location = new Point(60, 220);
            lblExequatur.Name = "lblExequatur";
            lblExequatur.Size = new Size(114, 23);
            lblExequatur.TabIndex = 4;
            lblExequatur.Text = "Exequatur:";
            // 
            // txtespecialidad
            // 
            txtespecialidad.Location = new Point(189, 162);
            txtespecialidad.Name = "txtespecialidad";
            txtespecialidad.PlaceholderText = "Especialidad ";
            txtespecialidad.Size = new Size(257, 31);
            txtespecialidad.TabIndex = 5;
            // 
            // textExequatur
            // 
            textExequatur.Location = new Point(189, 212);
            textExequatur.Name = "textExequatur";
            textExequatur.PlaceholderText = "Exequatur";
            textExequatur.Size = new Size(257, 31);
            textExequatur.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(101, 267);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 7;
            label3.Text = "Tarifa:";
            // 
            // textTarifa
            // 
            textTarifa.Location = new Point(189, 263);
            textTarifa.Name = "textTarifa";
            textTarifa.PlaceholderText = "Tarifa";
            textTarifa.Size = new Size(257, 31);
            textTarifa.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(85, 366);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 9;
            label4.Text = "Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(101, 418);
            label5.Name = "label5";
            label5.Size = new Size(68, 23);
            label5.TabIndex = 10;
            label5.Text = "Clave:";
            // 
            // textusuario
            // 
            textusuario.Location = new Point(189, 366);
            textusuario.Name = "textusuario";
            textusuario.PlaceholderText = "Usuario";
            textusuario.Size = new Size(257, 31);
            textusuario.TabIndex = 11;
            // 
            // textClave
            // 
            textClave.Location = new Point(189, 418);
            textClave.Name = "textClave";
            textClave.PlaceholderText = "Clave ";
            textClave.Size = new Size(257, 31);
            textClave.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(78, 496);
            button1.Name = "button1";
            button1.Size = new Size(135, 34);
            button1.TabIndex = 13;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(281, 496);
            button2.Name = "button2";
            button2.Size = new Size(137, 34);
            button2.TabIndex = 14;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(94, 317);
            label6.Name = "label6";
            label6.Size = new Size(80, 23);
            label6.TabIndex = 15;
            label6.Text = "Cedula:";
            // 
            // textCedula
            // 
            textCedula.Location = new Point(189, 313);
            textCedula.Name = "textCedula";
            textCedula.PlaceholderText = "Cedula";
            textCedula.Size = new Size(257, 31);
            textCedula.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 74);
            panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._new;
            pictureBox1.Location = new Point(568, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 326);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // FormRegistrarDoctor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(951, 572);
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
    }
}