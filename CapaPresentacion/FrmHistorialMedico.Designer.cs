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
            button1 = new Button();
            cmbPacientes = new ComboBox();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dgvHistorial = new DataGridView();
            btnCerrar = new Button();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(558, 111);
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
            cmbPacientes.Location = new Point(234, 112);
            cmbPacientes.Name = "cmbPacientes";
            cmbPacientes.Size = new Size(303, 33);
            cmbPacientes.TabIndex = 1;
            cmbPacientes.SelectedIndexChanged += cmbPacientes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Century", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 112);
            label1.Name = "label1";
            label1.Size = new Size(139, 27);
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
            dgvHistorial.Location = new Point(61, 166);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersWidth = 62;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.Size = new Size(973, 357);
            dgvHistorial.TabIndex = 1;
            dgvHistorial.CellContentClick += dgvHistorial_CellContentClick;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(428, 558);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(201, 50);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 77);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(326, 23);
            label2.Name = "label2";
            label2.Size = new Size(367, 38);
            label2.TabIndex = 0;
            label2.Text = "HISTORIAL MEDICO";
            // 
            // FrmHistorialMedico
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 638);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            Controls.Add(cmbPacientes);
            Controls.Add(dgvHistorial);
            Name = "FrmHistorialMedico";
            Text = "Historial Médico de Pacientes";
            WindowState = FormWindowState.Maximized;
            Load += FrmHistorialMedico_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private ComboBox cmbPacientes;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dgvHistorial;
        private Button btnCerrar;
        private Panel panel1;
        private Label label2;
    }
}