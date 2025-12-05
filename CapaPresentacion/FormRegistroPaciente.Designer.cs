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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCedula = new Label();
            txtCedula = new TextBox();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            dtpFechaNacimiento = new Label();
            dtpFecha = new DateTimePicker();
            lblGrupoSang = new Label();
            cboGrupoSanguineo = new ComboBox();
            lblAlergias = new Label();
            txtAlergias = new TextBox();
            lblSeguro = new Label();
            txtSeguro = new TextBox();
            lblContacto = new Label();
            txtContactoEmergencia = new TextBox();
            lblPeso = new Label();
            txtPeso = new TextBox();
            lblAltura = new Label();
            txtAltura = new TextBox();
            btnGuargar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(50, 18);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(168, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REGISTRO DE PACIENTE";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(50, 54);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(137, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(199, 54);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(255, 27);
            txtNombre.TabIndex = 2;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(50, 95);
            lblCedula.Margin = new Padding(2, 0, 2, 0);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(58, 20);
            lblCedula.TabIndex = 3;
            lblCedula.Text = "Cedula:";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(122, 90);
            txtCedula.Margin = new Padding(2, 2, 2, 2);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(192, 27);
            txtCedula.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(122, 134);
            txtTelefono.Margin = new Padding(2, 2, 2, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(192, 27);
            txtTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(50, 136);
            lblTelefono.Margin = new Padding(2, 0, 2, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(50, 180);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(122, 180);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(192, 27);
            txtEmail.TabIndex = 8;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.AutoSize = true;
            dtpFechaNacimiento.Location = new Point(50, 227);
            dtpFechaNacimiento.Margin = new Padding(2, 0, 2, 0);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(131, 20);
            dtpFechaNacimiento.TabIndex = 9;
            dtpFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(186, 223);
            dtpFecha.Margin = new Padding(2, 2, 2, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(142, 27);
            dtpFecha.TabIndex = 10;
            // 
            // lblGrupoSang
            // 
            lblGrupoSang.AutoSize = true;
            lblGrupoSang.Location = new Point(50, 277);
            lblGrupoSang.Margin = new Padding(2, 0, 2, 0);
            lblGrupoSang.Name = "lblGrupoSang";
            lblGrupoSang.Size = new Size(124, 20);
            lblGrupoSang.TabIndex = 11;
            lblGrupoSang.Text = "Grupo Sanguineo";
            // 
            // cboGrupoSanguineo
            // 
            cboGrupoSanguineo.FormattingEnabled = true;
            cboGrupoSanguineo.Items.AddRange(new object[] { "O+", "", "O-", "", "A+", "", "A-", "", "B+", "", "B-", "", "AB+", "", "AB-" });
            cboGrupoSanguineo.Location = new Point(182, 274);
            cboGrupoSanguineo.Margin = new Padding(2, 2, 2, 2);
            cboGrupoSanguineo.Name = "cboGrupoSanguineo";
            cboGrupoSanguineo.Size = new Size(146, 28);
            cboGrupoSanguineo.TabIndex = 12;
            // 
            // lblAlergias
            // 
            lblAlergias.AutoSize = true;
            lblAlergias.Location = new Point(50, 319);
            lblAlergias.Margin = new Padding(2, 0, 2, 0);
            lblAlergias.Name = "lblAlergias";
            lblAlergias.Size = new Size(66, 20);
            lblAlergias.TabIndex = 13;
            lblAlergias.Text = "Alergias:";
            // 
            // txtAlergias
            // 
            txtAlergias.Location = new Point(182, 319);
            txtAlergias.Margin = new Padding(2, 2, 2, 2);
            txtAlergias.Multiline = true;
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(259, 54);
            txtAlergias.TabIndex = 14;
            // 
            // lblSeguro
            // 
            lblSeguro.AutoSize = true;
            lblSeguro.Location = new Point(48, 386);
            lblSeguro.Margin = new Padding(2, 0, 2, 0);
            lblSeguro.Name = "lblSeguro";
            lblSeguro.Size = new Size(138, 20);
            lblSeguro.TabIndex = 15;
            lblSeguro.Text = "Numero de Seguro:";
            // 
            // txtSeguro
            // 
            txtSeguro.Location = new Point(186, 384);
            txtSeguro.Margin = new Padding(2, 2, 2, 2);
            txtSeguro.Name = "txtSeguro";
            txtSeguro.Size = new Size(121, 27);
            txtSeguro.TabIndex = 16;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Location = new Point(15, 424);
            lblContacto.Margin = new Padding(2, 0, 2, 0);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(175, 20);
            lblContacto.TabIndex = 17;
            lblContacto.Text = "Contacto de Emergencia:";
            // 
            // txtContactoEmergencia
            // 
            txtContactoEmergencia.Location = new Point(187, 422);
            txtContactoEmergencia.Margin = new Padding(2, 2, 2, 2);
            txtContactoEmergencia.Name = "txtContactoEmergencia";
            txtContactoEmergencia.Size = new Size(121, 27);
            txtContactoEmergencia.TabIndex = 18;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(78, 466);
            lblPeso.Margin = new Padding(2, 0, 2, 0);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(72, 20);
            lblPeso.TabIndex = 19;
            lblPeso.Text = "Peso (Lb):";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(187, 466);
            txtPeso.Margin = new Padding(2, 2, 2, 2);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(121, 27);
            txtPeso.TabIndex = 20;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(76, 510);
            lblAltura.Margin = new Padding(2, 0, 2, 0);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(76, 20);
            lblAltura.TabIndex = 21;
            lblAltura.Text = "Altura (m)";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(169, 510);
            txtAltura.Margin = new Padding(2, 2, 2, 2);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(121, 27);
            txtAltura.TabIndex = 22;
            // 
            // btnGuargar
            // 
            btnGuargar.Location = new Point(169, 604);
            btnGuargar.Margin = new Padding(2, 2, 2, 2);
            btnGuargar.Name = "btnGuargar";
            btnGuargar.Size = new Size(90, 27);
            btnGuargar.TabIndex = 23;
            btnGuargar.Text = "GUARDAR";
            btnGuargar.UseVisualStyleBackColor = true;
            btnGuargar.Click += btnGuargar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(426, 604);
            btnLimpiar.Margin = new Padding(2, 2, 2, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 27);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(578, 604);
            btnCerrar.Margin = new Padding(2, 2, 2, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(90, 27);
            btnCerrar.TabIndex = 25;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormRegistroPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.unnamed__1_;
            ClientSize = new Size(983, 729);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuargar);
            Controls.Add(txtAltura);
            Controls.Add(lblAltura);
            Controls.Add(txtPeso);
            Controls.Add(lblPeso);
            Controls.Add(txtContactoEmergencia);
            Controls.Add(lblContacto);
            Controls.Add(txtSeguro);
            Controls.Add(lblSeguro);
            Controls.Add(txtAlergias);
            Controls.Add(lblAlergias);
            Controls.Add(cboGrupoSanguineo);
            Controls.Add(lblGrupoSang);
            Controls.Add(dtpFecha);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(txtCedula);
            Controls.Add(lblCedula);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormRegistroPaciente";
            Text = "FormRegistroPaciente";
            Load += FormRegistroPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblCedula;
        private TextBox txtCedula;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label dtpFechaNacimiento;
        private DateTimePicker dtpFecha;
        private Label lblGrupoSang;
        private ComboBox cboGrupoSanguineo;
        private Label lblAlergias;
        private TextBox txtAlergias;
        private Label lblSeguro;
        private TextBox txtSeguro;
        private Label lblContacto;
        private TextBox txtContactoEmergencia;
        private Label lblPeso;
        private TextBox txtPeso;
        private Label lblAltura;
        private TextBox txtAltura;
        private Button btnGuargar;
        private Button btnLimpiar;
        private Button btnCerrar;
    }
}