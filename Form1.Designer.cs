namespace mluduena.CAI.Ej01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDocumento = new TextBox();
            txtFechaNac = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            button1 = new Button();
            lstDatos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 79);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 135);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 197);
            label4.Name = "label4";
            label4.Size = new Size(198, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha de nacimiento (mm/dd/yyyy)";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(28, 36);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(100, 23);
            txtDocumento.TabIndex = 7;
            // 
            // txtFechaNac
            // 
            txtFechaNac.Location = new Point(28, 215);
            txtFechaNac.Name = "txtFechaNac";
            txtFechaNac.Size = new Size(100, 23);
            txtFechaNac.TabIndex = 9;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(28, 153);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(28, 97);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(28, 260);
            button1.Name = "button1";
            button1.Size = new Size(83, 28);
            button1.TabIndex = 14;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstDatos
            // 
            lstDatos.FormattingEnabled = true;
            lstDatos.ItemHeight = 15;
            lstDatos.Location = new Point(177, 36);
            lstDatos.Name = "lstDatos";
            lstDatos.Size = new Size(120, 94);
            lstDatos.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstDatos);
            Controls.Add(button1);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtFechaNac);
            Controls.Add(txtDocumento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDocumento;
        private TextBox txtFechaNac;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button button1;
        private ListBox lstDatos;
    }
}