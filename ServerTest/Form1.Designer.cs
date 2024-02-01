namespace ServerTest
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
            botonCrearServer = new Button();
            labelEstado = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // botonCrearServer
            // 
            botonCrearServer.Location = new Point(32, 25);
            botonCrearServer.Name = "botonCrearServer";
            botonCrearServer.Size = new Size(107, 48);
            botonCrearServer.TabIndex = 0;
            botonCrearServer.Text = "Crear Servidor";
            botonCrearServer.UseVisualStyleBackColor = true;
            botonCrearServer.Click += buttonCrearServidor_Click;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(15, 421);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(50, 15);
            labelEstado.TabIndex = 1;
            labelEstado.Text = "Estado:-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 165);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 450);
            Controls.Add(label1);
            Controls.Add(labelEstado);
            Controls.Add(botonCrearServer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonCrearServer;
        private Label labelEstado;
        private Label label1;
    }
}
