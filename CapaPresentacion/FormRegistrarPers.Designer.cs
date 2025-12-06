namespace CapaPresentacion
{
    partial class FormRegistrarPers
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
            textDoctor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblEspecialidad = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textDoctor
            // 
            textDoctor.Location = new Point(254, 104);
            textDoctor.Name = "textDoctor";
            textDoctor.Size = new Size(204, 31);
            textDoctor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 38);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 1;
            label1.Text = "REISTRAR DOCTOR ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 104);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre: ";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(147, 174);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(59, 25);
            lblEspecialidad.TabIndex = 3;
            lblEspecialidad.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 257);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(306, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(63, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(280, 255);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 6;
            // 
            // FormRegistrarPers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(lblEspecialidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textDoctor);
            Name = "FormRegistrarPers";
            Text = "FormRegistrarPers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textDoctor;
        private Label label1;
        private Label label2;
        private Label lblEspecialidad;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}