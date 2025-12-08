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
            btnAgendar = new Button();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            lblListaCitas = new Label();
            dgvCitas = new DataGridView();
            cboPaciente = new ComboBox();
            cboDoctor = new ComboBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblGestionCitas
            // 
            lblGestionCitas.AutoSize = true;
            lblGestionCitas.Font = new Font("Century", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionCitas.ForeColor = SystemColors.ButtonHighlight;
            lblGestionCitas.Location = new Point(571, 9);
            lblGestionCitas.Name = "lblGestionCitas";
            lblGestionCitas.Size = new Size(352, 38);
            lblGestionCitas.TabIndex = 0;
            lblGestionCitas.Text = "GESTION DE CITAS";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Century", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaciente.Location = new Point(24, 150);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(106, 27);
            lblPaciente.TabIndex = 1;
            lblPaciente.Text = "Paciente:";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDoctor.Location = new Point(40, 210);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(78, 23);
            lblDoctor.TabIndex = 3;
            lblDoctor.Text = "Doctor:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Century", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(73, 317);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(79, 27);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(53, 351);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(139, 31);
            dtpFecha.TabIndex = 6;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(280, 317);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(63, 23);
            lblHora.TabIndex = 7;
            lblHora.Text = "Hora:";
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(249, 351);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(152, 31);
            dtpHora.TabIndex = 8;
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.PaleGreen;
            btnAgendar.Location = new Point(80, 475);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(130, 34);
            btnAgendar.TabIndex = 11;
            btnAgendar.Text = "AGENDAR";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.MistyRose;
            btnLimpiar.Location = new Point(231, 475);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Location = new Point(231, 541);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblListaCitas
            // 
            lblListaCitas.AutoSize = true;
            lblListaCitas.Font = new Font("Century", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListaCitas.Location = new Point(539, 90);
            lblListaCitas.Name = "lblListaCitas";
            lblListaCitas.Size = new Size(244, 23);
            lblListaCitas.TabIndex = 14;
            lblListaCitas.Text = "CITAS REGISTRADAS";
            // 
            // dgvCitas
            // 
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(539, 137);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersWidth = 62;
            dgvCitas.Size = new Size(770, 459);
            dgvCitas.TabIndex = 15;
            dgvCitas.CellContentClick += dgvCitas_CellContentClick;
            // 
            // cboPaciente
            // 
            cboPaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(125, 149);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(276, 33);
            cboPaciente.TabIndex = 16;
            cboPaciente.SelectedIndexChanged += cboPaciente_SelectedIndexChanged;
            // 
            // cboDoctor
            // 
            cboDoctor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboDoctor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboDoctor.FormattingEnabled = true;
            cboDoctor.Location = new Point(125, 206);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(276, 33);
            cboDoctor.TabIndex = 17;
            cboDoctor.SelectedIndexChanged += cboDoctor_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(80, 541);
            button1.Name = "button1";
            button1.Size = new Size(130, 34);
            button1.TabIndex = 18;
            button1.Text = "EDITAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(lblGestionCitas);
            panel1.Location = new Point(5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1605, 62);
            panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 99);
            label1.Name = "label1";
            label1.Size = new Size(149, 23);
            label1.TabIndex = 20;
            label1.Text = "NUEVA CITA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 456);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 269);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 22;
            label3.Text = "Costo: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "$3,500.00" });
            comboBox1.Location = new Point(124, 265);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(277, 33);
            comboBox1.TabIndex = 23;
            // 
            // GestionCitas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 630);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(cboDoctor);
            Controls.Add(cboPaciente);
            Controls.Add(dgvCitas);
            Controls.Add(lblListaCitas);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgendar);
            Controls.Add(dtpHora);
            Controls.Add(lblHora);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(lblDoctor);
            Controls.Add(lblPaciente);
            Name = "GestionCitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionCitas";
            Load += FormGestionCitas_Load;
            Click += FormGestionCitas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button btnAgendar;
        private Button btnLimpiar;
        private Button btnCancelar;
        private Label lblListaCitas;
        private DataGridView dgvCitas;
        private ComboBox cboPaciente;
        private ComboBox cboDoctor;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
    }
}