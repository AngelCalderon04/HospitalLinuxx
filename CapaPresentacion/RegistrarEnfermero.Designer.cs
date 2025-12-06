namespace CapaPresentacion
{
    partial class RegistrarEnfermero
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
            txtNombre = new TextBox();
            txtTurno = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblArea = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(314, 84);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 0;
            // 
            // txtTurno
            // 
            txtTurno.Location = new Point(296, 147);
            txtTurno.Name = "txtTurno";
            txtTurno.Size = new Size(150, 31);
            txtTurno.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(296, 223);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 84);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 147);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 5;
            label2.Text = "Turno: ";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(202, 223);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(52, 25);
            lblArea.TabIndex = 6;
            lblArea.Text = "Area:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 28);
            label4.Name = "label4";
            label4.Size = new Size(213, 25);
            label4.TabIndex = 7;
            label4.Text = "REGISTRAR ENFERMERO ";
            // 
            // RegistrarEnfermero
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(lblArea);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(txtTurno);
            Controls.Add(txtNombre);
            Name = "RegistrarEnfermero";
            Text = "RegistrarEnfermero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtTurno;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label lblArea;
        private Label label4;
    }
}