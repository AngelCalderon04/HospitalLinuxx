namespace CapaPresentacion
{
    partial class RegistrarEnfermero
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
            txtNombre = new TextBox();
            textArea = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblArea = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            textcedula = new TextBox();
            textusuario = new TextBox();
            textclave = new TextBox();
            button1 = new Button();
            button2 = new Button();
            cboTurno = new ComboBox();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(125, 90);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre Completo";
            txtNombre.Size = new Size(197, 27);
            txtNombre.TabIndex = 0;
            // 
            // textArea
            // 
            textArea.Location = new Point(125, 220);
            textArea.Margin = new Padding(2, 2, 2, 2);
            textArea.Name = "textArea";
            textArea.PlaceholderText = "Area";
            textArea.Size = new Size(197, 27);
            textArea.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 94);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 175);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 5;
            label2.Text = "Turno: ";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArea.Location = new Point(57, 220);
            lblArea.Margin = new Padding(2, 0, 2, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(53, 21);
            lblArea.TabIndex = 6;
            lblArea.Text = "Area:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(125, 14);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(440, 35);
            label4.TabIndex = 7;
            label4.Text = "REGISTRAR ENFERMERO ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label4);
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 62);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 132);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 9;
            label3.Text = "Cedula:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 276);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 10;
            label5.Text = "Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(50, 324);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 11;
            label6.Text = "Clave:";
            // 
            // textcedula
            // 
            textcedula.Location = new Point(125, 132);
            textcedula.Margin = new Padding(2, 2, 2, 2);
            textcedula.Name = "textcedula";
            textcedula.PlaceholderText = "Cedula";
            textcedula.Size = new Size(197, 27);
            textcedula.TabIndex = 12;
            textcedula.TextChanged += textcedula_TextChanged;
            // 
            // textusuario
            // 
            textusuario.Location = new Point(125, 273);
            textusuario.Margin = new Padding(2, 2, 2, 2);
            textusuario.Name = "textusuario";
            textusuario.PlaceholderText = "Usuario";
            textusuario.Size = new Size(197, 27);
            textusuario.TabIndex = 13;
            // 
            // textclave
            // 
            textclave.Location = new Point(125, 321);
            textclave.Margin = new Padding(2, 2, 2, 2);
            textclave.Name = "textclave";
            textclave.PlaceholderText = "Clave";
            textclave.Size = new Size(197, 27);
            textclave.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(64, 400);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(109, 27);
            button1.TabIndex = 15;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(206, 400);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(114, 27);
            button2.TabIndex = 16;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Manana", "Tarde ", "Noche " });
            cboTurno.Location = new Point(125, 175);
            cboTurno.Margin = new Padding(2, 2, 2, 2);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(197, 29);
            cboTurno.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._new;
            pictureBox1.Location = new Point(357, 106);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 306);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(142, 453);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(336, 15);
            progressBar1.TabIndex = 19;
            progressBar1.Visible = false;
            progressBar1.Click += progressBar1_Click;
            // 
            // RegistrarEnfermero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(649, 479);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(cboTurno);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textclave);
            Controls.Add(textusuario);
            Controls.Add(textcedula);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(lblArea);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textArea);
            Controls.Add(txtNombre);
            Margin = new Padding(2, 2, 2, 2);
            Name = "RegistrarEnfermero";
            Text = "RegistrarEnfermero";
            WindowState = FormWindowState.Minimized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox textArea;
        private Label label1;
        private Label label2;
        private Label lblArea;
        private Label label4;
        private Panel panel1;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox textcedula;
        private TextBox textusuario;
        private TextBox textclave;
        private Button button1;
        private Button button2;
        private ComboBox cboTurno;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
    }
}