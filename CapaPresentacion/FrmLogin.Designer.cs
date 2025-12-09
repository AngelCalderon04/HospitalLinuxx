namespace CapaPresentacion
{
    partial class FrmLogin
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
            txtClave = new TextBox();
            txtUsuario = new TextBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtClave
            // 
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(317, 158);
            txtClave.Margin = new Padding(2);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.PlaceholderText = "CLAVE";
            txtClave.Size = new Size(120, 24);
            txtClave.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(317, 111);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "USUARIO";
            txtUsuario.Size = new Size(120, 24);
            txtUsuario.TabIndex = 1;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.InactiveBorder;
            btnIngresar.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(198, 226);
            btnIngresar.Margin = new Padding(2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(102, 27);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "INGRESAR ";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.InactiveBorder;
            btnCancelar.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(347, 226);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 27);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "CANCELAR ";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(198, 111);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 4;
            label1.Text = "USUARIO:";
            label1.TextAlign = ContentAlignment.TopRight;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(220, 158);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 5;
            label2.Text = "CLAVE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Century", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(126, 14);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(274, 33);
            label3.TabIndex = 7;
            label3.Text = "HOSPITAL LINUX";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 62);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._new;
            pictureBox1.Location = new Point(-10, 38);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 229);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(298, 331);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 10;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(672, 374);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(txtUsuario);
            Controls.Add(txtClave);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtClave;
        private TextBox txtUsuario;
        private Button btnIngresar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
    }
}