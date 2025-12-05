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
            SuspendLayout();
            // 
            // txtClave
            // 
            txtClave.Location = new Point(227, 164);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(150, 31);
            txtClave.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(227, 100);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 1;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(153, 251);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(112, 34);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "INGRESAR ";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(335, 251);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "CANCELAR ";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 104);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 4;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 167);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 5;
            label2.Text = "Contrasena";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(txtUsuario);
            Controls.Add(txtClave);
            Name = "FrmLogin";
            Text = "FrmLogin";
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
    }
}