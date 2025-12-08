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
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(202, 35);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(507, 42);
            label1.TabIndex = 0;
            label1.Text = "MENU PRINCIPAL LINUX";
            // 
            // btnRegistrarPaciente
            // 
            btnRegistrarPaciente.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarPaciente.Location = new Point(31, 139);
            btnRegistrarPaciente.Margin = new Padding(2);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(248, 34);
            btnRegistrarPaciente.TabIndex = 1;
            btnRegistrarPaciente.Text = "REGISTRAR PACIENTE ";
            btnRegistrarPaciente.UseVisualStyleBackColor = true;
            btnRegistrarPaciente.Click += btnRegistrarPaciente_Click;
            // 
            // btnAgendarCita
            // 
            btnAgendarCita.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgendarCita.Location = new Point(31, 187);
            btnAgendarCita.Margin = new Padding(2);
            btnAgendarCita.Name = "btnAgendarCita";
            btnAgendarCita.Size = new Size(248, 34);
            btnAgendarCita.TabIndex = 2;
            btnAgendarCita.Text = "AGENDAR CITA";
            btnAgendarCita.UseVisualStyleBackColor = true;
            btnAgendarCita.Click += btnAgendarCita_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistorial.Location = new Point(31, 306);
            btnHistorial.Margin = new Padding(2);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(248, 34);
            btnHistorial.TabIndex = 3;
            btnHistorial.Text = "HISTORIAL PACIENTE ";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9.8F);
            btnSalir.Location = new Point(78, 483);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrarCONS
            // 
            btnRegistrarCONS.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarCONS.Location = new Point(31, 242);
            btnRegistrarCONS.Margin = new Padding(2);
            btnRegistrarCONS.Name = "btnRegistrarCONS";
            btnRegistrarCONS.Size = new Size(248, 34);
            btnRegistrarCONS.TabIndex = 5;
            btnRegistrarCONS.Text = "REGISTRAR CONSULTA";
            btnRegistrarCONS.UseVisualStyleBackColor = true;
            btnRegistrarCONS.Click += btnRegistrarCONS_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 99);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(31, 362);
            button1.Name = "button1";
            button1.Size = new Size(248, 34);
            button1.TabIndex = 7;
            button1.Text = "AGREGAR PERSONAL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(463, 123);
            label2.Name = "label2";
            label2.Size = new Size(279, 23);
            label2.TabIndex = 8;
            label2.Text = "BIENVENIDO AL SISTEMA";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(388, 507);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(297, 31);
            dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(691, 507);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(151, 31);
            dateTimePicker2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._new;
            pictureBox1.Location = new Point(463, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 311);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(938, 550);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(btnRegistrarCONS);
            Controls.Add(btnSalir);
            Controls.Add(btnHistorial);
            Controls.Add(btnAgendarCita);
            Controls.Add(btnRegistrarPaciente);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel1;
        private Button button1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private PictureBox pictureBox1;
    }
}