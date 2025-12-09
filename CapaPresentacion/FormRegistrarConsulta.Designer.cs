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
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.BorderStyle = BorderStyle.Fixed3D;
            lblPaciente.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaciente.Location = new Point(209, 122);
            lblPaciente.Margin = new Padding(2, 0, 2, 0);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(113, 23);
            lblPaciente.TabIndex = 0;
            lblPaciente.Text = "PACIENTE: ";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.BorderStyle = BorderStyle.Fixed3D;
            lblDoctor.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDoctor.Location = new Point(594, 119);
            lblDoctor.Margin = new Padding(2, 0, 2, 0);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(91, 23);
            lblDoctor.TabIndex = 1;
            lblDoctor.Text = "DOCTOR:";
            // 
            // cboPaciente
            // 
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(336, 119);
            cboPaciente.Margin = new Padding(2);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(211, 28);
            cboPaciente.TabIndex = 2;
            cboPaciente.SelectedIndexChanged += cboPaciente_SelectedIndexChanged;
            // 
            // cboDoctor
            // 
            cboDoctor.FormattingEnabled = true;
            cboDoctor.Location = new Point(717, 119);
            cboDoctor.Margin = new Padding(2);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(202, 28);
            cboDoctor.TabIndex = 3;
            cboDoctor.SelectedIndexChanged += cboDoctor_SelectedIndexChanged;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMotivo.Location = new Point(207, 188);
            lblMotivo.Margin = new Padding(2, 0, 2, 0);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(168, 18);
            lblMotivo.TabIndex = 4;
            lblMotivo.Text = "MOTIVO CONSULTA:";
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiagnostico.Location = new Point(209, 356);
            lblDiagnostico.Margin = new Padding(2, 0, 2, 0);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(125, 18);
            lblDiagnostico.TabIndex = 5;
            lblDiagnostico.Text = "DIAGNOSTICO ";
            // 
            // lblTratamiento
            // 
            lblTratamiento.AutoSize = true;
            lblTratamiento.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTratamiento.Location = new Point(621, 356);
            lblTratamiento.Margin = new Padding(2, 0, 2, 0);
            lblTratamiento.Name = "lblTratamiento";
            lblTratamiento.Size = new Size(130, 18);
            lblTratamiento.TabIndex = 6;
            lblTratamiento.Text = "TRATAMIENTO:";
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblObservaciones.Location = new Point(628, 188);
            lblObservaciones.Margin = new Padding(2, 0, 2, 0);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(149, 18);
            lblObservaciones.TabIndex = 7;
            lblObservaciones.Text = "OBSERVACIONES:";
            lblObservaciones.Click += lblObservaciones_Click;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(207, 223);
            txtMotivo.Margin = new Padding(2);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PlaceholderText = "MOTIVO CONSULTA ";
            txtMotivo.Size = new Size(298, 78);
            txtMotivo.TabIndex = 8;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(209, 385);
            txtDiagnostico.Margin = new Padding(2);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.PlaceholderText = "DIAGNOSTICO";
            txtDiagnostico.Size = new Size(296, 82);
            txtDiagnostico.TabIndex = 9;
            // 
            // txtTratamiento
            // 
            txtTratamiento.Location = new Point(628, 385);
            txtTratamiento.Margin = new Padding(2);
            txtTratamiento.Multiline = true;
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.PlaceholderText = "TRATAMIENTO";
            txtTratamiento.Size = new Size(324, 82);
            txtTratamiento.TabIndex = 10;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(628, 231);
            txtObservaciones.Margin = new Padding(2);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PlaceholderText = "OBSERVACIONES";
            txtObservaciones.Size = new Size(324, 78);
            txtObservaciones.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(431, 535);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(115, 34);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(594, 535);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(105, 34);
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
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1149, 70);
            panel1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(262, 17);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(404, 46);
            label2.TabIndex = 15;
            label2.Text = "REGISTRAR CONSULTA";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(-9, 69);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(116, 566);
            panel2.TabIndex = 16;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(330, 602);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(447, 18);
            progressBar1.TabIndex = 17;
            progressBar1.Visible = false;
            progressBar1.Click += progressBar1_Click;
            // 
            // FormRegistrarConsulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 634);
            Controls.Add(progressBar1);
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
            Margin = new Padding(2);
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
        private ProgressBar progressBar1;
    }
}