namespace CapaPresentacion
{
    partial class FrmHistorialMedico
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
            gbBusqueda = new GroupBox();
            button1 = new Button();
            cmbPacientes = new ComboBox();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dgvHistorial = new DataGridView();
            btnCerrar = new Button();
            gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // gbBusqueda
            // 
            gbBusqueda.Controls.Add(button1);
            gbBusqueda.Controls.Add(cmbPacientes);
            gbBusqueda.Controls.Add(label1);
            gbBusqueda.Location = new Point(8, 24);
            gbBusqueda.Name = "gbBusqueda";
            gbBusqueda.Size = new Size(520, 105);
            gbBusqueda.TabIndex = 0;
            gbBusqueda.TabStop = false;
            gbBusqueda.Text = " Buscar Paciente";
            // 
            // button1
            // 
            button1.Location = new Point(402, 53);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "BUSCAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // cmbPacientes
            // 
            cmbPacientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPacientes.FormattingEnabled = true;
            cmbPacientes.Location = new Point(141, 53);
            cmbPacientes.Name = "cmbPacientes";
            cmbPacientes.Size = new Size(236, 33);
            cmbPacientes.TabIndex = 1;
            cmbPacientes.SelectedIndexChanged += cmbPacientes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 53);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "PACIENTE:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(23, 142);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersWidth = 62;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.Size = new Size(952, 306);
            dgvHistorial.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(381, 454);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(201, 50);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmHistorialMedico
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 534);
            Controls.Add(btnCerrar);
            Controls.Add(dgvHistorial);
            Controls.Add(gbBusqueda);
            Name = "FrmHistorialMedico";
            Text = "Historial Médico de Pacientes";
            Load += FrmHistorialMedico_Load;
            gbBusqueda.ResumeLayout(false);
            gbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbBusqueda;
        private Label label1;
        private Button button1;
        private ComboBox cmbPacientes;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dgvHistorial;
        private Button btnCerrar;
    }
}