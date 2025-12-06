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
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(475, 40);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(311, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REGISTRO DE PACIENTE";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(288, 132);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(201, 30);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(519, 132);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(318, 31);
            txtNombre.TabIndex = 2;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCedula.Location = new Point(408, 185);
            lblCedula.Margin = new Padding(2, 0, 2, 0);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(85, 30);
            lblCedula.TabIndex = 3;
            lblCedula.Text = "Cedula:";
            lblCedula.Click += lblCedula_Click;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(501, 186);
            txtCedula.Margin = new Padding(2);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(239, 31);
            txtCedula.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(501, 236);
            txtTelefono.Margin = new Padding(2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(239, 31);
            txtTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10.8F);
            lblTelefono.Location = new Point(398, 235);
            lblTelefono.Margin = new Padding(2, 0, 2, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(97, 30);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.8F);
            lblEmail.Location = new Point(428, 284);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 30);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(501, 281);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 31);
            txtEmail.TabIndex = 8;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.AutoSize = true;
            dtpFechaNacimiento.Font = new Font("Segoe UI", 10.8F);
            dtpFechaNacimiento.Location = new Point(300, 340);
            dtpFechaNacimiento.Margin = new Padding(2, 0, 2, 0);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(190, 30);
            dtpFechaNacimiento.TabIndex = 9;
            dtpFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(501, 338);
            dtpFecha.Margin = new Padding(2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(176, 31);
            dtpFecha.TabIndex = 10;
            // 
            // lblGrupoSang
            // 
            lblGrupoSang.AutoSize = true;
            lblGrupoSang.Font = new Font("Segoe UI", 10.8F);
            lblGrupoSang.Location = new Point(308, 392);
            lblGrupoSang.Margin = new Padding(2, 0, 2, 0);
            lblGrupoSang.Name = "lblGrupoSang";
            lblGrupoSang.Size = new Size(182, 30);
            lblGrupoSang.TabIndex = 11;
            lblGrupoSang.Text = "Grupo Sanguineo";
            // 
            // cboGrupoSanguineo
            // 
            cboGrupoSanguineo.FormattingEnabled = true;
            cboGrupoSanguineo.Items.AddRange(new object[] { "O+", "", "O-", "", "A+", "", "A-", "", "B+", "", "B-", "", "AB+", "", "AB-" });
            cboGrupoSanguineo.Location = new Point(501, 389);
            cboGrupoSanguineo.Margin = new Padding(2);
            cboGrupoSanguineo.Name = "cboGrupoSanguineo";
            cboGrupoSanguineo.Size = new Size(182, 33);
            cboGrupoSanguineo.TabIndex = 12;
            // 
            // lblAlergias
            // 
            lblAlergias.AutoSize = true;
            lblAlergias.Font = new Font("Segoe UI", 10.8F);
            lblAlergias.Location = new Point(396, 455);
            lblAlergias.Margin = new Padding(2, 0, 2, 0);
            lblAlergias.Name = "lblAlergias";
            lblAlergias.Size = new Size(95, 30);
            lblAlergias.TabIndex = 13;
            lblAlergias.Text = "Alergias:";
            // 
            // txtAlergias
            // 
            txtAlergias.Location = new Point(501, 440);
            txtAlergias.Margin = new Padding(2);
            txtAlergias.Multiline = true;
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(323, 66);
            txtAlergias.TabIndex = 14;
            // 
            // lblSeguro
            // 
            lblSeguro.AutoSize = true;
            lblSeguro.Font = new Font("Segoe UI", 10.8F);
            lblSeguro.Location = new Point(285, 529);
            lblSeguro.Margin = new Padding(2, 0, 2, 0);
            lblSeguro.Name = "lblSeguro";
            lblSeguro.Size = new Size(205, 30);
            lblSeguro.TabIndex = 15;
            lblSeguro.Text = "Numero de Seguro:";
            // 
            // txtSeguro
            // 
            txtSeguro.Location = new Point(501, 526);
            txtSeguro.Margin = new Padding(2);
            txtSeguro.Name = "txtSeguro";
            txtSeguro.Size = new Size(150, 31);
            txtSeguro.TabIndex = 16;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 10.8F);
            lblContacto.Location = new Point(235, 585);
            lblContacto.Margin = new Padding(2, 0, 2, 0);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(255, 30);
            lblContacto.TabIndex = 17;
            lblContacto.Text = "Contacto de Emergencia:";
            // 
            // txtContactoEmergencia
            // 
            txtContactoEmergencia.Location = new Point(501, 582);
            txtContactoEmergencia.Margin = new Padding(2);
            txtContactoEmergencia.Name = "txtContactoEmergencia";
            txtContactoEmergencia.Size = new Size(150, 31);
            txtContactoEmergencia.TabIndex = 18;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI", 10.8F);
            lblPeso.Location = new Point(386, 631);
            lblPeso.Margin = new Padding(2, 0, 2, 0);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(106, 30);
            lblPeso.TabIndex = 19;
            lblPeso.Text = "Peso (Lb):";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(501, 629);
            txtPeso.Margin = new Padding(2);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(150, 31);
            txtPeso.TabIndex = 20;
            txtPeso.TextChanged += txtPeso_TextChanged;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Segoe UI", 10.8F);
            lblAltura.Location = new Point(382, 688);
            lblAltura.Margin = new Padding(2, 0, 2, 0);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(109, 30);
            lblAltura.TabIndex = 21;
            lblAltura.Text = "Altura (m)";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(500, 685);
            txtAltura.Margin = new Padding(2);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(150, 31);
            txtAltura.TabIndex = 22;
            // 
            // btnGuargar
            // 
            btnGuargar.Font = new Font("Segoe UI", 11.8F);
            btnGuargar.Location = new Point(280, 755);
            btnGuargar.Margin = new Padding(2);
            btnGuargar.Name = "btnGuargar";
            btnGuargar.Size = new Size(146, 46);
            btnGuargar.TabIndex = 23;
            btnGuargar.Text = "GUARDAR";
            btnGuargar.UseVisualStyleBackColor = true;
            btnGuargar.Click += btnGuargar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 11.8F);
            btnLimpiar.Location = new Point(519, 755);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 46);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 11.8F);
            btnCerrar.Location = new Point(720, 755);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(122, 46);
            btnCerrar.TabIndex = 25;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormRegistroPaciente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.unnamed__1_;
            ClientSize = new Size(1229, 911);
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
            Margin = new Padding(2);
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