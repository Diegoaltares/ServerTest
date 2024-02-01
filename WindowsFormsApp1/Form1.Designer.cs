namespace ModbusServerTest
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCrearServidorCabecera = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelCoilsTypeCabecera = new System.Windows.Forms.Label();
            this.comboBoxCoilsTypeCabecera = new System.Windows.Forms.ComboBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.labelEscribirCabecera = new System.Windows.Forms.Label();
            this.comboBoxNombreRegistroCabecera = new System.Windows.Forms.ComboBox();
            this.labelNombreRegistroCabecera = new System.Windows.Forms.Label();
            this.comboBoxEscribirCabecera = new System.Windows.Forms.ComboBox();
            this.groupBoxSimulacion = new System.Windows.Forms.GroupBox();
            this.labelTipoRegistroCabecera = new System.Windows.Forms.Label();
            this.dataGridViewDatosCabecera = new System.Windows.Forms.DataGridView();
            this.dataGridViewDatosReal = new System.Windows.Forms.DataGridView();
            this.groupBoxReal = new System.Windows.Forms.GroupBox();
            this.labelTipoRegistroReal = new System.Windows.Forms.Label();
            this.labelCoilsTypeReal = new System.Windows.Forms.Label();
            this.comboBoxEscribirReal = new System.Windows.Forms.ComboBox();
            this.comboBoxCoilsTypeReal = new System.Windows.Forms.ComboBox();
            this.comboBoxNombreRegistroReal = new System.Windows.Forms.ComboBox();
            this.labelEscribirReal = new System.Windows.Forms.Label();
            this.labelNombreRegistroReal = new System.Windows.Forms.Label();
            this.buttonCrearServidorReal = new System.Windows.Forms.Button();
            this.labelEstadoReal = new System.Windows.Forms.Label();
            this.labelCambiosCabecera = new System.Windows.Forms.Label();
            this.labelCambioReal = new System.Windows.Forms.Label();
            this.groupBoxSimulacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosCabecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosReal)).BeginInit();
            this.groupBoxReal.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCrearServidorCabecera
            // 
            this.buttonCrearServidorCabecera.Location = new System.Drawing.Point(26, 12);
            this.buttonCrearServidorCabecera.Name = "buttonCrearServidorCabecera";
            this.buttonCrearServidorCabecera.Size = new System.Drawing.Size(84, 50);
            this.buttonCrearServidorCabecera.TabIndex = 0;
            this.buttonCrearServidorCabecera.Text = "Crear Servidor";
            this.buttonCrearServidorCabecera.UseVisualStyleBackColor = true;
            this.buttonCrearServidorCabecera.Click += new System.EventHandler(this.buttonCrearServidor_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(23, 774);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(49, 13);
            this.labelEstado.TabIndex = 1;
            this.labelEstado.Text = "Estado: -";
            // 
            // labelCoilsTypeCabecera
            // 
            this.labelCoilsTypeCabecera.AutoSize = true;
            this.labelCoilsTypeCabecera.Location = new System.Drawing.Point(6, 30);
            this.labelCoilsTypeCabecera.Name = "labelCoilsTypeCabecera";
            this.labelCoilsTypeCabecera.Size = new System.Drawing.Size(76, 13);
            this.labelCoilsTypeCabecera.TabIndex = 2;
            this.labelCoilsTypeCabecera.Text = "Tipo Registro: ";
            // 
            // comboBoxCoilsTypeCabecera
            // 
            this.comboBoxCoilsTypeCabecera.FormattingEnabled = true;
            this.comboBoxCoilsTypeCabecera.Items.AddRange(new object[] {
            "Inputs",
            "Coils"});
            this.comboBoxCoilsTypeCabecera.Location = new System.Drawing.Point(88, 27);
            this.comboBoxCoilsTypeCabecera.Name = "comboBoxCoilsTypeCabecera";
            this.comboBoxCoilsTypeCabecera.Size = new System.Drawing.Size(96, 21);
            this.comboBoxCoilsTypeCabecera.TabIndex = 3;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(356, 12);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(84, 50);
            this.buttonAceptar.TabIndex = 4;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // labelEscribirCabecera
            // 
            this.labelEscribirCabecera.AutoSize = true;
            this.labelEscribirCabecera.Location = new System.Drawing.Point(48, 71);
            this.labelEscribirCabecera.Name = "labelEscribirCabecera";
            this.labelEscribirCabecera.Size = new System.Drawing.Size(34, 13);
            this.labelEscribirCabecera.TabIndex = 5;
            this.labelEscribirCabecera.Text = "Valor:";
            this.labelEscribirCabecera.Visible = false;
            // 
            // comboBoxNombreRegistroCabecera
            // 
            this.comboBoxNombreRegistroCabecera.FormattingEnabled = true;
            this.comboBoxNombreRegistroCabecera.Items.AddRange(new object[] {
            "Leer",
            "Escribir"});
            this.comboBoxNombreRegistroCabecera.Location = new System.Drawing.Point(88, 111);
            this.comboBoxNombreRegistroCabecera.Name = "comboBoxNombreRegistroCabecera";
            this.comboBoxNombreRegistroCabecera.Size = new System.Drawing.Size(228, 21);
            this.comboBoxNombreRegistroCabecera.TabIndex = 8;
            this.comboBoxNombreRegistroCabecera.Visible = false;
            // 
            // labelNombreRegistroCabecera
            // 
            this.labelNombreRegistroCabecera.AutoSize = true;
            this.labelNombreRegistroCabecera.Location = new System.Drawing.Point(-4, 114);
            this.labelNombreRegistroCabecera.Name = "labelNombreRegistroCabecera";
            this.labelNombreRegistroCabecera.Size = new System.Drawing.Size(92, 13);
            this.labelNombreRegistroCabecera.TabIndex = 7;
            this.labelNombreRegistroCabecera.Text = "Nombre Registro: ";
            this.labelNombreRegistroCabecera.Visible = false;
            // 
            // comboBoxEscribirCabecera
            // 
            this.comboBoxEscribirCabecera.FormattingEnabled = true;
            this.comboBoxEscribirCabecera.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxEscribirCabecera.Location = new System.Drawing.Point(88, 68);
            this.comboBoxEscribirCabecera.Name = "comboBoxEscribirCabecera";
            this.comboBoxEscribirCabecera.Size = new System.Drawing.Size(96, 21);
            this.comboBoxEscribirCabecera.TabIndex = 9;
            this.comboBoxEscribirCabecera.Visible = false;
            // 
            // groupBoxSimulacion
            // 
            this.groupBoxSimulacion.Controls.Add(this.labelTipoRegistroCabecera);
            this.groupBoxSimulacion.Controls.Add(this.labelCoilsTypeCabecera);
            this.groupBoxSimulacion.Controls.Add(this.comboBoxEscribirCabecera);
            this.groupBoxSimulacion.Controls.Add(this.comboBoxCoilsTypeCabecera);
            this.groupBoxSimulacion.Controls.Add(this.comboBoxNombreRegistroCabecera);
            this.groupBoxSimulacion.Controls.Add(this.labelEscribirCabecera);
            this.groupBoxSimulacion.Controls.Add(this.labelNombreRegistroCabecera);
            this.groupBoxSimulacion.Location = new System.Drawing.Point(26, 88);
            this.groupBoxSimulacion.Name = "groupBoxSimulacion";
            this.groupBoxSimulacion.Size = new System.Drawing.Size(323, 141);
            this.groupBoxSimulacion.TabIndex = 10;
            this.groupBoxSimulacion.TabStop = false;
            this.groupBoxSimulacion.Text = "Cabecera";
            // 
            // labelTipoRegistroCabecera
            // 
            this.labelTipoRegistroCabecera.AutoSize = true;
            this.labelTipoRegistroCabecera.Location = new System.Drawing.Point(190, 30);
            this.labelTipoRegistroCabecera.Name = "labelTipoRegistroCabecera";
            this.labelTipoRegistroCabecera.Size = new System.Drawing.Size(77, 13);
            this.labelTipoRegistroCabecera.TabIndex = 10;
            this.labelTipoRegistroCabecera.Text = "Tipo registro:  -";
            // 
            // dataGridViewDatosCabecera
            // 
            this.dataGridViewDatosCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatosCabecera.Location = new System.Drawing.Point(26, 232);
            this.dataGridViewDatosCabecera.Name = "dataGridViewDatosCabecera";
            this.dataGridViewDatosCabecera.Size = new System.Drawing.Size(323, 539);
            this.dataGridViewDatosCabecera.TabIndex = 11;
            // 
            // dataGridViewDatosReal
            // 
            this.dataGridViewDatosReal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatosReal.Location = new System.Drawing.Point(450, 232);
            this.dataGridViewDatosReal.Name = "dataGridViewDatosReal";
            this.dataGridViewDatosReal.Size = new System.Drawing.Size(323, 539);
            this.dataGridViewDatosReal.TabIndex = 13;
            // 
            // groupBoxReal
            // 
            this.groupBoxReal.Controls.Add(this.labelTipoRegistroReal);
            this.groupBoxReal.Controls.Add(this.labelCoilsTypeReal);
            this.groupBoxReal.Controls.Add(this.comboBoxEscribirReal);
            this.groupBoxReal.Controls.Add(this.comboBoxCoilsTypeReal);
            this.groupBoxReal.Controls.Add(this.comboBoxNombreRegistroReal);
            this.groupBoxReal.Controls.Add(this.labelEscribirReal);
            this.groupBoxReal.Controls.Add(this.labelNombreRegistroReal);
            this.groupBoxReal.Location = new System.Drawing.Point(450, 88);
            this.groupBoxReal.Name = "groupBoxReal";
            this.groupBoxReal.Size = new System.Drawing.Size(323, 141);
            this.groupBoxReal.TabIndex = 12;
            this.groupBoxReal.TabStop = false;
            this.groupBoxReal.Text = "Real";
            // 
            // labelTipoRegistroReal
            // 
            this.labelTipoRegistroReal.AutoSize = true;
            this.labelTipoRegistroReal.Location = new System.Drawing.Point(190, 30);
            this.labelTipoRegistroReal.Name = "labelTipoRegistroReal";
            this.labelTipoRegistroReal.Size = new System.Drawing.Size(77, 13);
            this.labelTipoRegistroReal.TabIndex = 10;
            this.labelTipoRegistroReal.Text = "Tipo registro:  -";
            // 
            // labelCoilsTypeReal
            // 
            this.labelCoilsTypeReal.AutoSize = true;
            this.labelCoilsTypeReal.Location = new System.Drawing.Point(6, 30);
            this.labelCoilsTypeReal.Name = "labelCoilsTypeReal";
            this.labelCoilsTypeReal.Size = new System.Drawing.Size(76, 13);
            this.labelCoilsTypeReal.TabIndex = 2;
            this.labelCoilsTypeReal.Text = "Tipo Registro: ";
            // 
            // comboBoxEscribirReal
            // 
            this.comboBoxEscribirReal.FormattingEnabled = true;
            this.comboBoxEscribirReal.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxEscribirReal.Location = new System.Drawing.Point(88, 68);
            this.comboBoxEscribirReal.Name = "comboBoxEscribirReal";
            this.comboBoxEscribirReal.Size = new System.Drawing.Size(96, 21);
            this.comboBoxEscribirReal.TabIndex = 9;
            this.comboBoxEscribirReal.Visible = false;
            // 
            // comboBoxCoilsTypeReal
            // 
            this.comboBoxCoilsTypeReal.FormattingEnabled = true;
            this.comboBoxCoilsTypeReal.Items.AddRange(new object[] {
            "Inputs",
            "Coils"});
            this.comboBoxCoilsTypeReal.Location = new System.Drawing.Point(88, 27);
            this.comboBoxCoilsTypeReal.Name = "comboBoxCoilsTypeReal";
            this.comboBoxCoilsTypeReal.Size = new System.Drawing.Size(96, 21);
            this.comboBoxCoilsTypeReal.TabIndex = 3;
            // 
            // comboBoxNombreRegistroReal
            // 
            this.comboBoxNombreRegistroReal.FormattingEnabled = true;
            this.comboBoxNombreRegistroReal.Items.AddRange(new object[] {
            "Leer",
            "Escribir"});
            this.comboBoxNombreRegistroReal.Location = new System.Drawing.Point(88, 111);
            this.comboBoxNombreRegistroReal.Name = "comboBoxNombreRegistroReal";
            this.comboBoxNombreRegistroReal.Size = new System.Drawing.Size(228, 21);
            this.comboBoxNombreRegistroReal.TabIndex = 8;
            this.comboBoxNombreRegistroReal.Visible = false;
            // 
            // labelEscribirReal
            // 
            this.labelEscribirReal.AutoSize = true;
            this.labelEscribirReal.Location = new System.Drawing.Point(48, 71);
            this.labelEscribirReal.Name = "labelEscribirReal";
            this.labelEscribirReal.Size = new System.Drawing.Size(34, 13);
            this.labelEscribirReal.TabIndex = 5;
            this.labelEscribirReal.Text = "Valor:";
            this.labelEscribirReal.Visible = false;
            // 
            // labelNombreRegistroReal
            // 
            this.labelNombreRegistroReal.AutoSize = true;
            this.labelNombreRegistroReal.Location = new System.Drawing.Point(-4, 114);
            this.labelNombreRegistroReal.Name = "labelNombreRegistroReal";
            this.labelNombreRegistroReal.Size = new System.Drawing.Size(92, 13);
            this.labelNombreRegistroReal.TabIndex = 7;
            this.labelNombreRegistroReal.Text = "Nombre Registro: ";
            this.labelNombreRegistroReal.Visible = false;
            // 
            // buttonCrearServidorReal
            // 
            this.buttonCrearServidorReal.Location = new System.Drawing.Point(689, 11);
            this.buttonCrearServidorReal.Name = "buttonCrearServidorReal";
            this.buttonCrearServidorReal.Size = new System.Drawing.Size(84, 51);
            this.buttonCrearServidorReal.TabIndex = 14;
            this.buttonCrearServidorReal.Text = "Crear Servidor";
            this.buttonCrearServidorReal.UseVisualStyleBackColor = true;
            this.buttonCrearServidorReal.Click += new System.EventHandler(this.buttonCrearServidorReal_Click);
            // 
            // labelEstadoReal
            // 
            this.labelEstadoReal.AutoSize = true;
            this.labelEstadoReal.Location = new System.Drawing.Point(447, 774);
            this.labelEstadoReal.Name = "labelEstadoReal";
            this.labelEstadoReal.Size = new System.Drawing.Size(49, 13);
            this.labelEstadoReal.TabIndex = 15;
            this.labelEstadoReal.Text = "Estado: -";
            // 
            // labelCambiosCabecera
            // 
            this.labelCambiosCabecera.AutoSize = true;
            this.labelCambiosCabecera.Location = new System.Drawing.Point(116, 12);
            this.labelCambiosCabecera.MaximumSize = new System.Drawing.Size(228, 60);
            this.labelCambiosCabecera.Name = "labelCambiosCabecera";
            this.labelCambiosCabecera.Size = new System.Drawing.Size(76, 13);
            this.labelCambiosCabecera.TabIndex = 16;
            this.labelCambiosCabecera.Text = "Último cambio:";
            this.labelCambiosCabecera.Visible = false;
            // 
            // labelCambioReal
            // 
            this.labelCambioReal.AutoSize = true;
            this.labelCambioReal.Location = new System.Drawing.Point(446, 12);
            this.labelCambioReal.MaximumSize = new System.Drawing.Size(228, 60);
            this.labelCambioReal.Name = "labelCambioReal";
            this.labelCambioReal.Size = new System.Drawing.Size(79, 13);
            this.labelCambioReal.TabIndex = 17;
            this.labelCambioReal.Text = "Último cambio: ";
            this.labelCambioReal.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 796);
            this.Controls.Add(this.labelCambioReal);
            this.Controls.Add(this.labelCambiosCabecera);
            this.Controls.Add(this.labelEstadoReal);
            this.Controls.Add(this.buttonCrearServidorReal);
            this.Controls.Add(this.dataGridViewDatosReal);
            this.Controls.Add(this.groupBoxReal);
            this.Controls.Add(this.dataGridViewDatosCabecera);
            this.Controls.Add(this.groupBoxSimulacion);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.buttonCrearServidorCabecera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxSimulacion.ResumeLayout(false);
            this.groupBoxSimulacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosCabecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosReal)).EndInit();
            this.groupBoxReal.ResumeLayout(false);
            this.groupBoxReal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCrearServidorCabecera;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelCoilsTypeCabecera;
        private System.Windows.Forms.ComboBox comboBoxCoilsTypeCabecera;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelEscribirCabecera;
        private System.Windows.Forms.ComboBox comboBoxNombreRegistroCabecera;
        private System.Windows.Forms.Label labelNombreRegistroCabecera;
        private System.Windows.Forms.ComboBox comboBoxEscribirCabecera;
        private System.Windows.Forms.GroupBox groupBoxSimulacion;
        private System.Windows.Forms.DataGridView dataGridViewDatosCabecera;
        private System.Windows.Forms.Label labelTipoRegistroCabecera;
        private System.Windows.Forms.DataGridView dataGridViewDatosReal;
        private System.Windows.Forms.GroupBox groupBoxReal;
        private System.Windows.Forms.Label labelTipoRegistroReal;
        private System.Windows.Forms.Label labelCoilsTypeReal;
        private System.Windows.Forms.ComboBox comboBoxEscribirReal;
        private System.Windows.Forms.ComboBox comboBoxCoilsTypeReal;
        private System.Windows.Forms.ComboBox comboBoxNombreRegistroReal;
        private System.Windows.Forms.Label labelEscribirReal;
        private System.Windows.Forms.Label labelNombreRegistroReal;
        private System.Windows.Forms.Button buttonCrearServidorReal;
        private System.Windows.Forms.Label labelEstadoReal;
        private System.Windows.Forms.Label labelCambiosCabecera;
        private System.Windows.Forms.Label labelCambioReal;
    }
}

