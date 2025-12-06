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
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(224, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 31);
            label1.TabIndex = 0;
            label1.Text = "MENU PRINCIPAL";
            // 
            // btnRegistrarPaciente
            // 
            btnRegistrarPaciente.Location = new Point(236, 109);
            btnRegistrarPaciente.Margin = new Padding(2, 2, 2, 2);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(167, 27);
            btnRegistrarPaciente.TabIndex = 1;
            btnRegistrarPaciente.Text = "REGISTRAR PACIENTE ";
            btnRegistrarPaciente.UseVisualStyleBackColor = true;
            btnRegistrarPaciente.Click += btnRegistrarPaciente_Click;
            // 
            // btnAgendarCita
            // 
            btnAgendarCita.Location = new Point(236, 168);
            btnAgendarCita.Margin = new Padding(2, 2, 2, 2);
            btnAgendarCita.Name = "btnAgendarCita";
            btnAgendarCita.Size = new Size(170, 27);
            btnAgendarCita.TabIndex = 2;
            btnAgendarCita.Text = "AGENDAR CITA";
            btnAgendarCita.UseVisualStyleBackColor = true;
            btnAgendarCita.Click += btnAgendarCita_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Location = new Point(236, 293);
            btnHistorial.Margin = new Padding(2, 2, 2, 2);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(170, 27);
            btnHistorial.TabIndex = 3;
            btnHistorial.Text = "HISTORIAL PACIENTE ";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9.8F);
            btnSalir.Location = new Point(284, 359);
            btnSalir.Margin = new Padding(2, 2, 2, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 27);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrarCONS
            // 
            btnRegistrarCONS.Location = new Point(236, 234);
            btnRegistrarCONS.Margin = new Padding(2, 2, 2, 2);
            btnRegistrarCONS.Name = "btnRegistrarCONS";
            btnRegistrarCONS.Size = new Size(166, 27);
            btnRegistrarCONS.TabIndex = 5;
            btnRegistrarCONS.Text = "REGISTRAR CONSULTA";
            btnRegistrarCONS.UseVisualStyleBackColor = true;
            btnRegistrarCONS.Click += btnRegistrarCONS_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.diapositiva_1_658x502;
            ClientSize = new Size(640, 455);
            Controls.Add(btnRegistrarCONS);
            Controls.Add(btnSalir);
            Controls.Add(btnHistorial);
            Controls.Add(btnAgendarCita);
            Controls.Add(btnRegistrarPaciente);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
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