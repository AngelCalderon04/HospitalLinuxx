namespace CapaPresentacion
{
    partial class ReistrarPersonalADMIN
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
            comboCargo = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textNombre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textCedula = new TextBox();
            comboDepartamento = new ComboBox();
            textSalario = new TextBox();
            textUsuario = new TextBox();
            textClave = new TextBox();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboCargo
            // 
            comboCargo.FormattingEnabled = true;
            comboCargo.Items.AddRange(new object[] { "Administrador General", "Subadministrador", "Director de Recursos Humanos", "Analista de Recursos Humanos", "Gerente Financiero", "Contador", "Auxiliar Contable", "Encargado de Compras", "Auxiliar de Compras", "Jefe de Archivo Clínico", "Técnico de Archivo", "Coordinador de Calidad", "Analista de Calidad", "Encargado de Servicios Generales", "Supervisor de Limpieza", "Especialista en Facturación", "Cajero", "Analista de Cobros", "Recepcionista", "Servicio al Cliente", "Coordinador de Logística", "Técnico de Mantenimiento", "Encargado de Seguridad", "Relacionista Público", "Soporte Técnico", "Administrador de Sistemas" });
            comboCargo.Location = new Point(186, 335);
            comboCargo.Name = "comboCargo";
            comboCargo.Size = new Size(215, 33);
            comboCargo.TabIndex = 0;
            comboCargo.SelectedIndexChanged += comboCargo_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 77);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(120, 24);
            label1.Name = "label1";
            label1.Size = new Size(498, 33);
            label1.TabIndex = 0;
            label1.Text = "REGISTRAR ADMINISTRATIVOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 132);
            label2.Name = "label2";
            label2.Size = new Size(109, 23);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(94, 270);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 3;
            label3.Text = "DPTO: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(71, 335);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 4;
            label4.Text = "CARGO:";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(186, 128);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "NOMBRE COMPLETO";
            textNombre.Size = new Size(223, 31);
            textNombre.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(71, 200);
            label5.Name = "label5";
            label5.Size = new Size(103, 23);
            label5.TabIndex = 6;
            label5.Text = "CEDULA:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(466, 128);
            label6.Name = "label6";
            label6.Size = new Size(108, 23);
            label6.TabIndex = 7;
            label6.Text = "SALARIO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(461, 202);
            label7.Name = "label7";
            label7.Size = new Size(113, 23);
            label7.TabIndex = 8;
            label7.Text = "USUARIO:";
            label7.Click += label7_Click;
            // 
            // textCedula
            // 
            textCedula.Location = new Point(186, 192);
            textCedula.Name = "textCedula";
            textCedula.PlaceholderText = "CEDULA";
            textCedula.Size = new Size(215, 31);
            textCedula.TabIndex = 9;
            // 
            // comboDepartamento
            // 
            comboDepartamento.FormattingEnabled = true;
            comboDepartamento.Items.AddRange(new object[] { "Administración General", "Recursos Humanos", "Finanzas / Contabilidad", "Compras y Suministros", "Archivo Clínico", "Gestión de Calidad", "Planificación y Desarrollo", "Servicios Generales", "Tecnología de la Información (TI)", "Facturación y Cobros", "Atención al Usuario", "Gestión de Riesgos", "Logística", "Mantenimiento", "Seguridad", "Relaciones Públicas" });
            comboDepartamento.Location = new Point(188, 270);
            comboDepartamento.Name = "comboDepartamento";
            comboDepartamento.Size = new Size(213, 33);
            comboDepartamento.TabIndex = 10;
            // 
            // textSalario
            // 
            textSalario.Location = new Point(579, 124);
            textSalario.Name = "textSalario";
            textSalario.PlaceholderText = "$$$$$$";
            textSalario.Size = new Size(182, 31);
            textSalario.TabIndex = 11;
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(579, 194);
            textUsuario.Name = "textUsuario";
            textUsuario.PlaceholderText = "USUARIO";
            textUsuario.Size = new Size(182, 31);
            textUsuario.TabIndex = 12;
            // 
            // textClave
            // 
            textClave.Location = new Point(579, 253);
            textClave.Name = "textClave";
            textClave.PlaceholderText = "CLAVE";
            textClave.Size = new Size(182, 31);
            textClave.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(478, 257);
            label8.Name = "label8";
            label8.Size = new Size(85, 23);
            label8.TabIndex = 14;
            label8.Text = "CLAVE:";
            // 
            // button1
            // 
            button1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(286, 421);
            button1.Name = "button1";
            button1.Size = new Size(123, 34);
            button1.TabIndex = 15;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(442, 421);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 16;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ReistrarPersonalADMIN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 496);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(textClave);
            Controls.Add(textUsuario);
            Controls.Add(textSalario);
            Controls.Add(comboDepartamento);
            Controls.Add(textCedula);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(comboCargo);
            Name = "ReistrarPersonalADMIN";
            Text = "ReistrarPersonalADMIN";
            Load += ReistrarPersonalADMIN_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboCargo;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textNombre;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textCedula;
        private ComboBox comboDepartamento;
        private TextBox textSalario;
        private TextBox textUsuario;
        private TextBox textClave;
        private Label label8;
        private Button button1;
        private Button button2;
    }
}