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
            components = new System.ComponentModel.Container();
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
            txtcosto = new ComboBox();
            progressBar1 = new ProgressBar();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblGestionCitas
            // 
            lblGestionCitas.AutoSize = true;
            lblGestionCitas.Font = new Font("Century", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionCitas.ForeColor = SystemColors.ButtonHighlight;
            lblGestionCitas.Location = new Point(457, 7);
            lblGestionCitas.Margin = new Padding(2, 0, 2, 0);
            lblGestionCitas.Name = "lblGestionCitas";
            lblGestionCitas.Size = new Size(304, 33);
            lblGestionCitas.TabIndex = 0;
            lblGestionCitas.Text = "GESTION DE CITAS";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Century", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaciente.Location = new Point(19, 120);
            lblPaciente.Margin = new Padding(2, 0, 2, 0);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(92, 23);
            lblPaciente.TabIndex = 1;
            lblPaciente.Text = "Paciente:";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDoctor.Location = new Point(32, 168);
            lblDoctor.Margin = new Padding(2, 0, 2, 0);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(69, 21);
            lblDoctor.TabIndex = 3;
            lblDoctor.Text = "Doctor:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Century", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(58, 254);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(69, 23);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(42, 281);
            dtpFecha.Margin = new Padding(2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(112, 27);
            dtpFecha.TabIndex = 6;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(224, 254);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(55, 21);
            lblHora.TabIndex = 7;
            lblHora.Text = "Hora:";
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(199, 281);
            dtpHora.Margin = new Padding(2);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(122, 27);
            dtpHora.TabIndex = 8;
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.PaleGreen;
            btnAgendar.Location = new Point(64, 380);
            btnAgendar.Margin = new Padding(2);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(104, 27);
            btnAgendar.TabIndex = 11;
            btnAgendar.Text = "AGENDAR";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.MistyRose;
            btnLimpiar.Location = new Point(185, 380);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 27);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Location = new Point(185, 433);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 27);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblListaCitas
            // 
            lblListaCitas.AutoSize = true;
            lblListaCitas.Font = new Font("Century", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListaCitas.Location = new Point(431, 72);
            lblListaCitas.Margin = new Padding(2, 0, 2, 0);
            lblListaCitas.Name = "lblListaCitas";
            lblListaCitas.Size = new Size(211, 21);
            lblListaCitas.TabIndex = 14;
            lblListaCitas.Text = "CITAS REGISTRADAS";
            // 
            // dgvCitas
            // 
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(431, 110);
            dgvCitas.Margin = new Padding(2);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersWidth = 62;
            dgvCitas.Size = new Size(616, 367);
            dgvCitas.TabIndex = 15;
            dgvCitas.CellContentClick += dgvCitas_CellContentClick;
            // 
            // cboPaciente
            // 
            cboPaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(100, 119);
            cboPaciente.Margin = new Padding(2);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(222, 28);
            cboPaciente.TabIndex = 16;
            cboPaciente.SelectedIndexChanged += cboPaciente_SelectedIndexChanged;
            // 
            // cboDoctor
            // 
            cboDoctor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboDoctor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboDoctor.FormattingEnabled = true;
            cboDoctor.Location = new Point(100, 165);
            cboDoctor.Margin = new Padding(2);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(222, 28);
            cboDoctor.TabIndex = 17;
            cboDoctor.SelectedIndexChanged += cboDoctor_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(64, 433);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(104, 27);
            button1.TabIndex = 18;
            button1.Text = "EDITAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(lblGestionCitas);
            panel1.Location = new Point(4, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 50);
            panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 79);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 20;
            label1.Text = "NUEVA CITA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 365);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 215);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 22;
            label3.Text = "Costo: ";
            // 
            // txtcosto
            // 
            txtcosto.FormattingEnabled = true;
            txtcosto.Items.AddRange(new object[] { "$3,500.00" });
            txtcosto.Location = new Point(99, 212);
            txtcosto.Margin = new Padding(2);
            txtcosto.Name = "txtcosto";
            txtcosto.Size = new Size(222, 28);
            txtcosto.TabIndex = 23;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(42, 480);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(280, 20);
            progressBar1.TabIndex = 24;
            progressBar1.Visible = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // GestionCitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 504);
            Controls.Add(progressBar1);
            Controls.Add(txtcosto);
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
            Margin = new Padding(2);
            Name = "GestionCitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionCitas";
            Load += FormGestionCitas_Load;
            Click += FormGestionCitas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private ComboBox txtcosto;
        private ProgressBar progressBar1;
        private ErrorProvider errorProvider1;
    }
}