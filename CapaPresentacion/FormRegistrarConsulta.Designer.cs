namespace CapaPresentacion
{
    partial class FormRegistrarConsulta
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
            lblPaciente = new Label();
            lblDoctor = new Label();
            cboPaciente = new ComboBox();
            cboDoctor = new ComboBox();
            lblMotivo = new Label();
            lblDiagnostico = new Label();
            lblTratamiento = new Label();
            lblObservaciones = new Label();
            txtMotivo = new TextBox();
            txtDiagnostico = new TextBox();
            txtTratamiento = new TextBox();
            txtObservaciones = new TextBox();
            btnGuardar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Location = new Point(28, 43);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(98, 25);
            lblPaciente.TabIndex = 0;
            lblPaciente.Text = "PACIENTE: ";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Location = new Point(28, 101);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(87, 25);
            lblDoctor.TabIndex = 1;
            lblDoctor.Text = "DOCTOR:";
            // 
            // cboPaciente
            // 
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(148, 50);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(215, 33);
            cboPaciente.TabIndex = 2;
            // 
            // cboDoctor
            // 
            cboDoctor.FormattingEnabled = true;
            cboDoctor.Location = new Point(148, 98);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(215, 33);
            cboDoctor.TabIndex = 3;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(28, 176);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(172, 25);
            lblMotivo.TabIndex = 4;
            lblMotivo.Text = "MOTIVO CONSULTA";
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Location = new Point(28, 269);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(135, 25);
            lblDiagnostico.TabIndex = 5;
            lblDiagnostico.Text = "DIAGNOSTICO ";
            // 
            // lblTratamiento
            // 
            lblTratamiento.AutoSize = true;
            lblTratamiento.Location = new Point(31, 381);
            lblTratamiento.Name = "lblTratamiento";
            lblTratamiento.Size = new Size(132, 25);
            lblTratamiento.TabIndex = 6;
            lblTratamiento.Text = "TRATAMIENTO:";
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Location = new Point(28, 486);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(154, 25);
            lblObservaciones.TabIndex = 7;
            lblObservaciones.Text = "OBSERVACIONES:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(199, 170);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(413, 72);
            txtMotivo.TabIndex = 8;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(199, 269);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(413, 79);
            txtDiagnostico.TabIndex = 9;
            // 
            // txtTratamiento
            // 
            txtTratamiento.Location = new Point(199, 378);
            txtTratamiento.Multiline = true;
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.Size = new Size(413, 82);
            txtTratamiento.TabIndex = 10;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(199, 486);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(413, 71);
            txtObservaciones.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(212, 616);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(395, 616);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 13;
            button1.Text = "CERRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormRegistrarConsulta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 788);
            Controls.Add(button1);
            Controls.Add(btnGuardar);
            Controls.Add(txtObservaciones);
            Controls.Add(txtTratamiento);
            Controls.Add(txtDiagnostico);
            Controls.Add(txtMotivo);
            Controls.Add(lblObservaciones);
            Controls.Add(lblTratamiento);
            Controls.Add(lblDiagnostico);
            Controls.Add(lblMotivo);
            Controls.Add(cboDoctor);
            Controls.Add(cboPaciente);
            Controls.Add(lblDoctor);
            Controls.Add(lblPaciente);
            Name = "FormRegistrarConsulta";
            Text = "RegistrarConsulta";
            Load += FormRegistrarConsulta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPaciente;
        private Label lblDoctor;
        private ComboBox cboPaciente;
        private ComboBox cboDoctor;
        private Label lblMotivo;
        private Label lblDiagnostico;
        private Label lblTratamiento;
        private Label lblObservaciones;
        private TextBox txtMotivo;
        private TextBox txtDiagnostico;
        private TextBox txtTratamiento;
        private TextBox txtObservaciones;
        private Button btnGuardar;
        private Button button1;
    }
}