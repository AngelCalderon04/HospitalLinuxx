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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(156, 113);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre Completo";
            txtNombre.Size = new Size(245, 31);
            txtNombre.TabIndex = 0;
            // 
            // textArea
            // 
            textArea.Location = new Point(156, 275);
            textArea.Name = "textArea";
            textArea.PlaceholderText = "Area";
            textArea.Size = new Size(245, 31);
            textArea.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 117);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 219);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 5;
            label2.Text = "Turno: ";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArea.Location = new Point(71, 275);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(60, 23);
            lblArea.TabIndex = 6;
            lblArea.Text = "Area:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(156, 18);
            label4.Name = "label4";
            label4.Size = new Size(523, 42);
            label4.TabIndex = 7;
            label4.Text = "REGISTRAR ENFERMERO ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label4);
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 77);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 165);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 9;
            label3.Text = "Cedula:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(48, 345);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 10;
            label5.Text = "Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(63, 405);
            label6.Name = "label6";
            label6.Size = new Size(68, 23);
            label6.TabIndex = 11;
            label6.Text = "Clave:";
            // 
            // textcedula
            // 
            textcedula.Location = new Point(156, 165);
            textcedula.Name = "textcedula";
            textcedula.PlaceholderText = "Cedula";
            textcedula.Size = new Size(245, 31);
            textcedula.TabIndex = 12;
            textcedula.TextChanged += textcedula_TextChanged;
            // 
            // textusuario
            // 
            textusuario.Location = new Point(156, 341);
            textusuario.Name = "textusuario";
            textusuario.PlaceholderText = "Usuario";
            textusuario.Size = new Size(245, 31);
            textusuario.TabIndex = 13;
            // 
            // textclave
            // 
            textclave.Location = new Point(156, 401);
            textclave.Name = "textclave";
            textclave.PlaceholderText = "Clave";
            textclave.Size = new Size(245, 31);
            textclave.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(80, 500);
            button1.Name = "button1";
            button1.Size = new Size(136, 34);
            button1.TabIndex = 15;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(258, 500);
            button2.Name = "button2";
            button2.Size = new Size(143, 34);
            button2.TabIndex = 16;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Manana", "Tarde ", "Noche " });
            cboTurno.Location = new Point(156, 219);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(245, 31);
            cboTurno.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._new;
            pictureBox1.Location = new Point(446, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(332, 383);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // RegistrarEnfermero
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(811, 599);
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
            Name = "RegistrarEnfermero";
            Text = "RegistrarEnfermero";
            WindowState = FormWindowState.Maximized;
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
    }
}