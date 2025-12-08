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
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.BorderStyle = BorderStyle.Fixed3D;
            lblPaciente.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaciente.Location = new Point(261, 153);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(130, 25);
            lblPaciente.TabIndex = 0;
            lblPaciente.Text = "PACIENTE: ";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.BorderStyle = BorderStyle.Fixed3D;
            lblDoctor.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDoctor.Location = new Point(742, 149);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(107, 25);
            lblDoctor.TabIndex = 1;
            lblDoctor.Text = "DOCTOR:";
            // 
            // cboPaciente
            // 
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(420, 149);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(263, 33);
            cboPaciente.TabIndex = 2;
            cboPaciente.SelectedIndexChanged += cboPaciente_SelectedIndexChanged;
            // 
            // cboDoctor
            // 
            cboDoctor.FormattingEnabled = true;
            cboDoctor.Location = new Point(896, 149);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(251, 33);
            cboDoctor.TabIndex = 3;
            cboDoctor.SelectedIndexChanged += cboDoctor_SelectedIndexChanged;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMotivo.Location = new Point(259, 235);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(202, 22);
            lblMotivo.TabIndex = 4;
            lblMotivo.Text = "MOTIVO CONSULTA:";
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiagnostico.Location = new Point(261, 445);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(149, 22);
            lblDiagnostico.TabIndex = 5;
            lblDiagnostico.Text = "DIAGNOSTICO ";
            // 
            // lblTratamiento
            // 
            lblTratamiento.AutoSize = true;
            lblTratamiento.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTratamiento.Location = new Point(776, 445);
            lblTratamiento.Name = "lblTratamiento";
            lblTratamiento.Size = new Size(156, 22);
            lblTratamiento.TabIndex = 6;
            lblTratamiento.Text = "TRATAMIENTO:";
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblObservaciones.Location = new Point(785, 235);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(178, 22);
            lblObservaciones.TabIndex = 7;
            lblObservaciones.Text = "OBSERVACIONES:";
            lblObservaciones.Click += lblObservaciones_Click;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(259, 279);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PlaceholderText = "MOTIVO CONSULTA ";
            txtMotivo.Size = new Size(371, 97);
            txtMotivo.TabIndex = 8;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(261, 481);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.PlaceholderText = "DIAGNOSTICO";
            txtDiagnostico.Size = new Size(369, 102);
            txtDiagnostico.TabIndex = 9;
            // 
            // txtTratamiento
            // 
            txtTratamiento.Location = new Point(785, 481);
            txtTratamiento.Multiline = true;
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.PlaceholderText = "TRATAMIENTO";
            txtTratamiento.Size = new Size(404, 102);
            txtTratamiento.TabIndex = 10;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(785, 289);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PlaceholderText = "OBSERVACIONES";
            txtObservaciones.Size = new Size(404, 97);
            txtObservaciones.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(539, 669);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(144, 43);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(742, 669);
            button1.Name = "button1";
            button1.Size = new Size(131, 43);
            button1.TabIndex = 13;
            button1.Text = "CERRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1436, 87);
            panel1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(327, 21);
            label2.Name = "label2";
            label2.Size = new Size(485, 55);
            label2.TabIndex = 15;
            label2.Text = "REGISTRAR CONSULTA";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(-11, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(145, 708);
            panel2.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(562, 735);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(147, 31);
            dateTimePicker1.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(680, 735);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(158, 31);
            dateTimePicker2.TabIndex = 18;
            // 
            // FormRegistrarConsulta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 792);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}