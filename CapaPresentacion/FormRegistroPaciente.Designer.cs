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
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.BorderStyle = BorderStyle.FixedSingle;
            lblTitulo.Font = new Font("Century", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(347, 40);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(379, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REGISTRO DE PACIENTE";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(146, 237);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre Completo";
            txtNombre.Size = new Size(318, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(146, 289);
            txtCedula.Margin = new Padding(2);
            txtCedula.Name = "txtCedula";
            txtCedula.PlaceholderText = "Cedula";
            txtCedula.Size = new Size(318, 31);
            txtCedula.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(146, 467);
            txtTelefono.Margin = new Padding(2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(239, 31);
            txtTelefono.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(146, 517);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(239, 31);
            txtEmail.TabIndex = 8;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.AutoSize = true;
            dtpFechaNacimiento.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaNacimiento.Location = new Point(146, 340);
            dtpFechaNacimiento.Margin = new Padding(2, 0, 2, 0);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(172, 28);
            dtpFechaNacimiento.TabIndex = 9;
            dtpFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(322, 337);
            dtpFecha.Margin = new Padding(2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(142, 31);
            dtpFecha.TabIndex = 10;
            // 
            // lblGrupoSang
            // 
            lblGrupoSang.AutoSize = true;
            lblGrupoSang.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrupoSang.Location = new Point(650, 246);
            lblGrupoSang.Margin = new Padding(2, 0, 2, 0);
            lblGrupoSang.Name = "lblGrupoSang";
            lblGrupoSang.Size = new Size(155, 22);
            lblGrupoSang.TabIndex = 11;
            lblGrupoSang.Text = "Grupo Sanguineo";
            // 
            // cboGrupoSanguineo
            // 
            cboGrupoSanguineo.DrawMode = DrawMode.OwnerDrawFixed;
            cboGrupoSanguineo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGrupoSanguineo.FormattingEnabled = true;
            cboGrupoSanguineo.Items.AddRange(new object[] { "O+", "", "O-", "", "A+", "", "A-", "", "B+", "", "B-", "", "AB+", "", "AB-" });
            cboGrupoSanguineo.Location = new Point(846, 246);
            cboGrupoSanguineo.Margin = new Padding(2);
            cboGrupoSanguineo.Name = "cboGrupoSanguineo";
            cboGrupoSanguineo.Size = new Size(150, 32);
            cboGrupoSanguineo.TabIndex = 12;
            // 
            // txtAlergias
            // 
            txtAlergias.Location = new Point(654, 344);
            txtAlergias.Margin = new Padding(2);
            txtAlergias.Multiline = true;
            txtAlergias.Name = "txtAlergias";
            txtAlergias.PlaceholderText = "Alergias";
            txtAlergias.Size = new Size(371, 128);
            txtAlergias.TabIndex = 14;
            // 
            // txtSeguro
            // 
            txtSeguro.Location = new Point(649, 293);
            txtSeguro.Margin = new Padding(2);
            txtSeguro.Name = "txtSeguro";
            txtSeguro.PlaceholderText = "Num. Seguro";
            txtSeguro.Size = new Size(150, 31);
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
            txtContactoEmergencia.Location = new Point(146, 570);
            txtContactoEmergencia.Margin = new Padding(2);
            txtContactoEmergencia.Name = "txtContactoEmergencia";
            txtContactoEmergencia.PlaceholderText = "Contacto Emergencia ";
            txtContactoEmergencia.Size = new Size(239, 31);
            txtContactoEmergencia.TabIndex = 18;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(649, 574);
            txtPeso.Margin = new Padding(2);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "Peso (Lb)";
            txtPeso.Size = new Size(150, 31);
            txtPeso.TabIndex = 20;
            txtPeso.TextChanged += txtPeso_TextChanged;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(846, 574);
            txtAltura.Margin = new Padding(2);
            txtAltura.Name = "txtAltura";
            txtAltura.PlaceholderText = "Altura(m)";
            txtAltura.Size = new Size(150, 31);
            txtAltura.TabIndex = 22;
            // 
            // btnGuargar
            // 
            btnGuargar.Font = new Font("Segoe UI", 11.8F);
            btnGuargar.Location = new Point(231, 663);
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
            btnLimpiar.Location = new Point(503, 663);
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
            btnCerrar.Location = new Point(695, 663);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(122, 46);
            btnCerrar.TabIndex = 25;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(146, 164);
            label1.Name = "label1";
            label1.Size = new Size(262, 30);
            label1.TabIndex = 26;
            label1.Text = "Informacion Personal ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(146, 413);
            label2.Name = "label2";
            label2.Size = new Size(119, 30);
            label2.TabIndex = 27;
            label2.Text = "Contacto ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(714, 155);
            label3.Name = "label3";
            label3.Size = new Size(183, 30);
            label3.TabIndex = 28;
            label3.Text = "Datos Medicos ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(728, 505);
            label4.Name = "label4";
            label4.Size = new Size(194, 30);
            label4.TabIndex = 29;
            label4.Text = "Medidas Fisicas";
            // 
            // FormRegistroPaciente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1116, 741);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
            Controls.Add(lblTitulo);
            Margin = new Padding(2);
            Name = "FormRegistroPaciente";
            Text = "FormRegistroPaciente";
            WindowState = FormWindowState.Maximized;
            Load += FormRegistroPaciente_Load;
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
    }
}