namespace CapaPresentacion
{
    partial class Principal
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
            label1 = new Label();
            btnRegistrarPaciente = new Button();
            btnAgendarCita = new Button();
            btnHistorial = new Button();
            btnSalir = new Button();
            btnRegistrarCONS = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 27);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 0;
            label1.Text = "MENU PRINCIPAL";
            // 
            // btnRegistrarPaciente
            // 
            btnRegistrarPaciente.Location = new Point(227, 82);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(209, 34);
            btnRegistrarPaciente.TabIndex = 1;
            btnRegistrarPaciente.Text = "REGISTRAR PACIENTE ";
            btnRegistrarPaciente.UseVisualStyleBackColor = true;
            btnRegistrarPaciente.Click += btnRegistrarPaciente_Click;
            // 
            // btnAgendarCita
            // 
            btnAgendarCita.Location = new Point(227, 149);
            btnAgendarCita.Name = "btnAgendarCita";
            btnAgendarCita.Size = new Size(212, 34);
            btnAgendarCita.TabIndex = 2;
            btnAgendarCita.Text = "AGENDAR CITA";
            btnAgendarCita.UseVisualStyleBackColor = true;
            btnAgendarCita.Click += btnAgendarCita_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Location = new Point(226, 272);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(213, 34);
            btnHistorial.TabIndex = 3;
            btnHistorial.Text = "HISTORIAL PACIENTE ";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(273, 338);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrarCONS
            // 
            btnRegistrarCONS.Location = new Point(227, 210);
            btnRegistrarCONS.Name = "btnRegistrarCONS";
            btnRegistrarCONS.Size = new Size(208, 34);
            btnRegistrarCONS.TabIndex = 5;
            btnRegistrarCONS.Text = "REGISTRAR CONSULTA";
            btnRegistrarCONS.UseVisualStyleBackColor = true;
            btnRegistrarCONS.Click += btnRegistrarCONS_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrarCONS);
            Controls.Add(btnSalir);
            Controls.Add(btnHistorial);
            Controls.Add(btnAgendarCita);
            Controls.Add(btnRegistrarPaciente);
            Controls.Add(label1);
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegistrarPaciente;
        private Button btnAgendarCita;
        private Button btnHistorial;
        private Button btnSalir;
        private Button btnRegistrarCONS;
    }
}