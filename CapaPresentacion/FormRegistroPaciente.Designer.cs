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
            lblTitulo.Location = new Point(62, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(202, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REGISTRO DE PACIENTE";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(62, 67);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(166, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(249, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(318, 31);
            txtNombre.TabIndex = 2;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(62, 119);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(70, 25);
            lblCedula.TabIndex = 3;
            lblCedula.Text = "Cedula:";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(153, 113);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(239, 31);
            txtCedula.TabIndex = 4;
         
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(153, 167);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(239, 31);
            txtTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(62, 170);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(79, 25);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(62, 225);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(153, 225);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 31);
            txtEmail.TabIndex = 8;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.AutoSize = true;
            dtpFechaNacimiento.Location = new Point(62, 284);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(156, 25);
            dtpFechaNacimiento.TabIndex = 9;
            dtpFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(233, 279);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(177, 31);
            dtpFecha.TabIndex = 10;
            // 
            // lblGrupoSang
            // 
            lblGrupoSang.AutoSize = true;
            lblGrupoSang.Location = new Point(62, 346);
            lblGrupoSang.Name = "lblGrupoSang";
            lblGrupoSang.Size = new Size(151, 25);
            lblGrupoSang.TabIndex = 11;
            lblGrupoSang.Text = "Grupo Sanguineo";
            // 
            // cboGrupoSanguineo
            // 
            cboGrupoSanguineo.FormattingEnabled = true;
            cboGrupoSanguineo.Items.AddRange(new object[] { "O+", "", "O-", "", "A+", "", "A-", "", "B+", "", "B-", "", "AB+", "", "AB-" });
            cboGrupoSanguineo.Location = new Point(228, 343);
            cboGrupoSanguineo.Name = "cboGrupoSanguineo";
            cboGrupoSanguineo.Size = new Size(182, 33);
            cboGrupoSanguineo.TabIndex = 12;
            // 
            // lblAlergias
            // 
            lblAlergias.AutoSize = true;
            lblAlergias.Location = new Point(62, 399);
            lblAlergias.Name = "lblAlergias";
            lblAlergias.Size = new Size(79, 25);
            lblAlergias.TabIndex = 13;
            lblAlergias.Text = "Alergias:";
            // 
            // txtAlergias
            // 
            txtAlergias.Location = new Point(228, 399);
            txtAlergias.Multiline = true;
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(323, 67);
            txtAlergias.TabIndex = 14;
            // 
            // lblSeguro
            // 
            lblSeguro.AutoSize = true;
            lblSeguro.Location = new Point(60, 483);
            lblSeguro.Name = "lblSeguro";
            lblSeguro.Size = new Size(168, 25);
            lblSeguro.TabIndex = 15;
            lblSeguro.Text = "Numero de Seguro:";
            // 
            // txtSeguro
            // 
            txtSeguro.Location = new Point(233, 480);
            txtSeguro.Name = "txtSeguro";
            txtSeguro.Size = new Size(150, 31);
            txtSeguro.TabIndex = 16;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Location = new Point(19, 530);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(209, 25);
            lblContacto.TabIndex = 17;
            lblContacto.Text = "Contacto de Emergencia:";
            // 
            // txtContactoEmergencia
            // 
            txtContactoEmergencia.Location = new Point(234, 527);
            txtContactoEmergencia.Name = "txtContactoEmergencia";
            txtContactoEmergencia.Size = new Size(150, 31);
            txtContactoEmergencia.TabIndex = 18;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(98, 582);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(87, 25);
            lblPeso.TabIndex = 19;
            lblPeso.Text = "Peso (Lb):";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(234, 582);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(150, 31);
            txtPeso.TabIndex = 20;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(95, 637);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(90, 25);
            lblAltura.TabIndex = 21;
            lblAltura.Text = "Altura (m)";
           
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(211, 637);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(150, 31);
            txtAltura.TabIndex = 22;
            // 
            // btnGuargar
            // 
            btnGuargar.Location = new Point(73, 718);
            btnGuargar.Name = "btnGuargar";
            btnGuargar.Size = new Size(112, 34);
            btnGuargar.TabIndex = 23;
            btnGuargar.Text = "GUARDAR";
            btnGuargar.UseVisualStyleBackColor = true;
            btnGuargar.Click += btnGuargar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(280, 718);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(455, 718);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(112, 34);
            btnCerrar.TabIndex = 25;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormRegistroPaciente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 764);
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