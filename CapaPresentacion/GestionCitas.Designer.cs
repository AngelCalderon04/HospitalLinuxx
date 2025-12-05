namespace CapaPresentacion
{
    partial class GestionCitas
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
            lblGestionCitas = new Label();
            lblPaciente = new Label();
            lblDoctor = new Label();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblHora = new Label();
            dtpHora = new DateTimePicker();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            btnAgendar = new Button();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            lblListaCitas = new Label();
            dgvCitas = new DataGridView();
            cboPaciente = new ComboBox();
            cboDoctor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // lblGestionCitas
            // 
            lblGestionCitas.AutoSize = true;
            lblGestionCitas.Location = new Point(103, 31);
            lblGestionCitas.Name = "lblGestionCitas";
            lblGestionCitas.Size = new Size(162, 25);
            lblGestionCitas.TabIndex = 0;
            lblGestionCitas.Text = "GESTION DE CITAS";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Location = new Point(78, 108);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(80, 25);
            lblPaciente.TabIndex = 1;
            lblPaciente.Text = "Paciente:";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Location = new Point(86, 166);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(71, 25);
            lblDoctor.TabIndex = 3;
            lblDoctor.Text = "Doctor:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(86, 228);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(61, 25);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(178, 222);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(183, 31);
            dtpFecha.TabIndex = 6;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(86, 289);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(55, 25);
            lblHora.TabIndex = 7;
            lblHora.Text = "Hora:";
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(167, 289);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(161, 31);
            dtpHora.TabIndex = 8;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(84, 347);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(73, 25);
            lblMotivo.TabIndex = 9;
            lblMotivo.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(154, 347);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(375, 71);
            txtMotivo.TabIndex = 10;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(86, 442);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(112, 34);
            btnAgendar.TabIndex = 11;
            btnAgendar.Text = "AGENDAR";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(234, 442);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(388, 442);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblListaCitas
            // 
            lblListaCitas.AutoSize = true;
            lblListaCitas.Location = new Point(568, 59);
            lblListaCitas.Name = "lblListaCitas";
            lblListaCitas.Size = new Size(177, 25);
            lblListaCitas.TabIndex = 14;
            lblListaCitas.Text = "CITAS REGISTRADAS";
            // 
            // dgvCitas
            // 
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(563, 110);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersWidth = 62;
            dgvCitas.Size = new Size(1075, 385);
            dgvCitas.TabIndex = 15;
            dgvCitas.CellContentClick += dgvCitas_CellContentClick;
            // 
            // cboPaciente
            // 
            cboPaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(178, 115);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(335, 33);
            cboPaciente.TabIndex = 16;
            cboPaciente.SelectedIndexChanged += cboPaciente_SelectedIndexChanged;
            // 
            // cboDoctor
            // 
            cboDoctor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboDoctor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboDoctor.FormattingEnabled = true;
            cboDoctor.Location = new Point(178, 166);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(322, 33);
            cboDoctor.TabIndex = 17;
            cboDoctor.SelectedIndexChanged += cboDoctor_SelectedIndexChanged;
            // 
            // GestionCitas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1603, 533);
            Controls.Add(cboDoctor);
            Controls.Add(cboPaciente);
            Controls.Add(dgvCitas);
            Controls.Add(lblListaCitas);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgendar);
            Controls.Add(txtMotivo);
            Controls.Add(lblMotivo);
            Controls.Add(dtpHora);
            Controls.Add(lblHora);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(lblDoctor);
            Controls.Add(lblPaciente);
            Controls.Add(lblGestionCitas);
            Name = "GestionCitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionCitas";
            Load += FormGestionCitas_Load;
            Click += FormGestionCitas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGestionCitas;
        private Label lblPaciente;
        private Label lblDoctor;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblHora;
        private DateTimePicker dtpHora;
        private Label lblMotivo;
        private TextBox txtMotivo;
        private Button btnAgendar;
        private Button btnLimpiar;
        private Button btnCancelar;
        private Label lblListaCitas;
        private DataGridView dgvCitas;
        private ComboBox cboPaciente;
        private ComboBox cboDoctor;
    }
}