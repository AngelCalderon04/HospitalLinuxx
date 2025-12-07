namespace CapaPresentacion
{
    partial class FormRegistroPaciente
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
            lblTitulo = new Label();
            txtNombre = new TextBox();
            txtCedula = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            dtpFechaNacimiento = new Label();
            dtpFecha = new DateTimePicker();
            lblGrupoSang = new Label();
            cboGrupoSanguineo = new ComboBox();
            txtAlergias = new TextBox();
            txtSeguro = new TextBox();
            lblContacto = new Label();
            txtContactoEmergencia = new TextBox();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btnGuargar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.BorderStyle = BorderStyle.FixedSingle;
            lblTitulo.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ButtonFace;
            lblTitulo.Location = new Point(299, 29);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(506, 44);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REGISTRO DE PACIENTE";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(115, 213);
            txtNombre.Margin = new Padding(2);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre Completo";
            txtNombre.Size = new Size(303, 49);
            txtNombre.TabIndex = 2;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(115, 278);
            txtCedula.Margin = new Padding(2);
            txtCedula.Multiline = true;
            txtCedula.Name = "txtCedula";
            txtCedula.PlaceholderText = "Cedula";
            txtCedula.Size = new Size(303, 48);
            txtCedula.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(115, 483);
            txtTelefono.Margin = new Padding(2);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(303, 49);
            txtTelefono.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(115, 546);
            txtEmail.Margin = new Padding(2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(303, 51);
            txtEmail.TabIndex = 8;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.AutoSize = true;
            dtpFechaNacimiento.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaNacimiento.Location = new Point(115, 351);
            dtpFechaNacimiento.Margin = new Padding(2, 0, 2, 0);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(113, 23);
            dtpFechaNacimiento.TabIndex = 9;
            dtpFechaNacimiento.Text = "Fecha Nac:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(248, 345);
            dtpFecha.Margin = new Padding(2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(170, 31);
            dtpFecha.TabIndex = 10;
            // 
            // lblGrupoSang
            // 
            lblGrupoSang.AutoSize = true;
            lblGrupoSang.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrupoSang.Location = new Point(611, 213);
            lblGrupoSang.Margin = new Padding(2, 0, 2, 0);
            lblGrupoSang.Name = "lblGrupoSang";
            lblGrupoSang.Size = new Size(171, 23);
            lblGrupoSang.TabIndex = 11;
            lblGrupoSang.Text = "Grupo Sanguineo";
            // 
            // cboGrupoSanguineo
            // 
            cboGrupoSanguineo.DrawMode = DrawMode.OwnerDrawFixed;
            cboGrupoSanguineo.FormattingEnabled = true;
            cboGrupoSanguineo.Items.AddRange(new object[] { "O+", "", "O-", "", "A+", "", "A-", "", "B+", "", "B-", "", "AB+", "", "AB-" });
            cboGrupoSanguineo.Location = new Point(798, 213);
            cboGrupoSanguineo.Margin = new Padding(2);
            cboGrupoSanguineo.Name = "cboGrupoSanguineo";
            cboGrupoSanguineo.Size = new Size(222, 32);
            cboGrupoSanguineo.TabIndex = 12;
            // 
            // txtAlergias
            // 
            txtAlergias.Location = new Point(626, 335);
            txtAlergias.Margin = new Padding(2);
            txtAlergias.Multiline = true;
            txtAlergias.Name = "txtAlergias";
            txtAlergias.PlaceholderText = "Alergias";
            txtAlergias.Size = new Size(394, 114);
            txtAlergias.TabIndex = 14;
            // 
            // txtSeguro
            // 
            txtSeguro.Location = new Point(798, 268);
            txtSeguro.Margin = new Padding(2);
            txtSeguro.Multiline = true;
            txtSeguro.Name = "txtSeguro";
            txtSeguro.PlaceholderText = "Num. Seguro";
            txtSeguro.Size = new Size(222, 41);
            txtSeguro.TabIndex = 16;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 10.8F);
            lblContacto.Location = new Point(322, 569);
            lblContacto.Margin = new Padding(2, 0, 2, 0);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(0, 30);
            lblContacto.TabIndex = 17;
            // 
            // txtContactoEmergencia
            // 
            txtContactoEmergencia.Location = new Point(115, 616);
            txtContactoEmergencia.Margin = new Padding(2);
            txtContactoEmergencia.Multiline = true;
            txtContactoEmergencia.Name = "txtContactoEmergencia";
            txtContactoEmergencia.PlaceholderText = "Contacto Emergencia ";
            txtContactoEmergencia.Size = new Size(303, 50);
            txtContactoEmergencia.TabIndex = 18;
            txtContactoEmergencia.TextChanged += txtContactoEmergencia_TextChanged;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(630, 531);
            txtPeso.Margin = new Padding(2);
            txtPeso.Multiline = true;
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "Peso (Lb)";
            txtPeso.Size = new Size(164, 51);
            txtPeso.TabIndex = 20;
            txtPeso.TextChanged += txtPeso_TextChanged;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(848, 531);
            txtAltura.Margin = new Padding(2);
            txtAltura.Multiline = true;
            txtAltura.Name = "txtAltura";
            txtAltura.PlaceholderText = "Altura(m)";
            txtAltura.Size = new Size(172, 51);
            txtAltura.TabIndex = 22;
            // 
            // btnGuargar
            // 
            btnGuargar.BackColor = Color.LightSkyBlue;
            btnGuargar.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuargar.Location = new Point(242, 695);
            btnGuargar.Margin = new Padding(2);
            btnGuargar.Name = "btnGuargar";
            btnGuargar.Size = new Size(176, 39);
            btnGuargar.TabIndex = 23;
            btnGuargar.Text = "GUARDAR";
            btnGuargar.UseVisualStyleBackColor = false;
            btnGuargar.Click += btnGuargar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Azure;
            btnLimpiar.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(466, 695);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(181, 46);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.LightCoral;
            btnCerrar.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(708, 691);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(167, 46);
            btnCerrar.TabIndex = 25;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Century", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(115, 155);
            label1.Name = "label1";
            label1.Size = new Size(303, 35);
            label1.TabIndex = 26;
            label1.Text = "Informacion Personal ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Century", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(115, 428);
            label2.Name = "label2";
            label2.Size = new Size(140, 35);
            label2.TabIndex = 27;
            label2.Text = "Contacto ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Century", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(611, 155);
            label3.Name = "label3";
            label3.Size = new Size(213, 35);
            label3.TabIndex = 28;
            label3.Text = "Datos Medicos ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Century", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(630, 470);
            label4.Name = "label4";
            label4.Size = new Size(226, 35);
            label4.TabIndex = 29;
            label4.Text = "Medidas Fisicas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 91);
            panel1.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(626, 272);
            label5.Name = "label5";
            label5.Size = new Size(139, 23);
            label5.TabIndex = 31;
            label5.Text = "Num. Seguro:";
            // 
            // FormRegistroPaciente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1116, 756);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuargar);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(txtContactoEmergencia);
            Controls.Add(lblContacto);
            Controls.Add(txtSeguro);
            Controls.Add(txtAlergias);
            Controls.Add(cboGrupoSanguineo);
            Controls.Add(lblGrupoSang);
            Controls.Add(dtpFecha);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtCedula);
            Controls.Add(txtNombre);
            Margin = new Padding(2);
            Name = "FormRegistroPaciente";
            Text = "FormRegistroPaciente";
            Load += FormRegistroPaciente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtNombre;
        private TextBox txtCedula;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Label dtpFechaNacimiento;
        private DateTimePicker dtpFecha;
        private Label lblGrupoSang;
        private ComboBox cboGrupoSanguineo;
        private TextBox txtAlergias;
        private TextBox txtSeguro;
        private Label lblContacto;
        private TextBox txtContactoEmergencia;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button btnGuargar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label label5;
    }
}