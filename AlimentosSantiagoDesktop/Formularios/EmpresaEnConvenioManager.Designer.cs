namespace AlimentosSantiagoDesktop.Formularios
{
    partial class EmpresaEnConvenioManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCelular = new System.Windows.Forms.NumericUpDown();
            this.tbxTelefono = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSaldo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDireccion = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxNombreEmpresa = new System.Windows.Forms.TextBox();
            this.btnExaminarContrato = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUrlArchivo = new System.Windows.Forms.Label();
            this.ofdCargaContrato = new System.Windows.Forms.OpenFileDialog();
            this.btnAgregarEmpresa = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExaminarPlanilla = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUrlPlanilla = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCargarPlanilla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxSaldo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 540);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EmpresaEnConvenioManager";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarEmpresa);
            this.groupBox2.Controls.Add(this.lblUrlArchivo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnExaminarContrato);
            this.groupBox2.Controls.Add(this.tbxNombreEmpresa);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbxDireccion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxCelular);
            this.groupBox2.Controls.Add(this.tbxTelefono);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbxSaldo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 414);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar empresa nueva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Celular";
            // 
            // tbxCelular
            // 
            this.tbxCelular.Location = new System.Drawing.Point(148, 104);
            this.tbxCelular.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.tbxCelular.Name = "tbxCelular";
            this.tbxCelular.Size = new System.Drawing.Size(195, 22);
            this.tbxCelular.TabIndex = 4;
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Location = new System.Drawing.Point(148, 66);
            this.tbxTelefono.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(195, 22);
            this.tbxTelefono.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefono";
            // 
            // tbxSaldo
            // 
            this.tbxSaldo.Location = new System.Drawing.Point(148, 30);
            this.tbxSaldo.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.tbxSaldo.Name = "tbxSaldo";
            this.tbxSaldo.Size = new System.Drawing.Size(195, 22);
            this.tbxSaldo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo mensual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direccion";
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Location = new System.Drawing.Point(148, 142);
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(195, 53);
            this.tbxDireccion.TabIndex = 7;
            this.tbxDireccion.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre Empresa";
            // 
            // tbxNombreEmpresa
            // 
            this.tbxNombreEmpresa.Location = new System.Drawing.Point(148, 211);
            this.tbxNombreEmpresa.Name = "tbxNombreEmpresa";
            this.tbxNombreEmpresa.Size = new System.Drawing.Size(195, 22);
            this.tbxNombreEmpresa.TabIndex = 9;
            // 
            // btnExaminarContrato
            // 
            this.btnExaminarContrato.Location = new System.Drawing.Point(148, 256);
            this.btnExaminarContrato.Name = "btnExaminarContrato";
            this.btnExaminarContrato.Size = new System.Drawing.Size(105, 38);
            this.btnExaminarContrato.TabIndex = 10;
            this.btnExaminarContrato.Text = "Examinar";
            this.btnExaminarContrato.UseVisualStyleBackColor = true;
            this.btnExaminarContrato.Click += new System.EventHandler(this.btnExaminarContrato_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Archivo contrato";
            // 
            // lblUrlArchivo
            // 
            this.lblUrlArchivo.AutoSize = true;
            this.lblUrlArchivo.Location = new System.Drawing.Point(6, 300);
            this.lblUrlArchivo.Name = "lblUrlArchivo";
            this.lblUrlArchivo.Size = new System.Drawing.Size(28, 17);
            this.lblUrlArchivo.TabIndex = 12;
            this.lblUrlArchivo.Text = "url:";
            // 
            // ofdCargaContrato
            // 
            this.ofdCargaContrato.Filter = "Word files (*.doc, *.docx)|*.doc;*.docx";
            // 
            // btnAgregarEmpresa
            // 
            this.btnAgregarEmpresa.Location = new System.Drawing.Point(88, 346);
            this.btnAgregarEmpresa.Name = "btnAgregarEmpresa";
            this.btnAgregarEmpresa.Size = new System.Drawing.Size(152, 49);
            this.btnAgregarEmpresa.TabIndex = 13;
            this.btnAgregarEmpresa.Text = "Agregar empresa convenio";
            this.btnAgregarEmpresa.UseVisualStyleBackColor = true;
            this.btnAgregarEmpresa.Click += new System.EventHandler(this.btnAgregarEmpresa_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(115, 461);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(191, 64);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCargarPlanilla);
            this.groupBox3.Controls.Add(this.lblUrlPlanilla);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnExaminarPlanilla);
            this.groupBox3.Location = new System.Drawing.Point(497, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 231);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Carga masiva trabajadores";
            // 
            // btnExaminarPlanilla
            // 
            this.btnExaminarPlanilla.Location = new System.Drawing.Point(16, 57);
            this.btnExaminarPlanilla.Name = "btnExaminarPlanilla";
            this.btnExaminarPlanilla.Size = new System.Drawing.Size(105, 38);
            this.btnExaminarPlanilla.TabIndex = 14;
            this.btnExaminarPlanilla.Text = "Examinar";
            this.btnExaminarPlanilla.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Planilla trabajadores";
            // 
            // lblUrlPlanilla
            // 
            this.lblUrlPlanilla.AutoSize = true;
            this.lblUrlPlanilla.Location = new System.Drawing.Point(13, 98);
            this.lblUrlPlanilla.Name = "lblUrlPlanilla";
            this.lblUrlPlanilla.Size = new System.Drawing.Size(28, 17);
            this.lblUrlPlanilla.TabIndex = 14;
            this.lblUrlPlanilla.Text = "url:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(329, 461);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(191, 64);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar campos de texto";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCargarPlanilla
            // 
            this.btnCargarPlanilla.Location = new System.Drawing.Point(62, 142);
            this.btnCargarPlanilla.Name = "btnCargarPlanilla";
            this.btnCargarPlanilla.Size = new System.Drawing.Size(152, 49);
            this.btnCargarPlanilla.TabIndex = 14;
            this.btnCargarPlanilla.Text = "Cargar planilla trabajadores";
            this.btnCargarPlanilla.UseVisualStyleBackColor = true;
            // 
            // EmpresaEnConvenioManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmpresaEnConvenioManager";
            this.Text = "EmpresaEnConvenioManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmpresaEnConvenioManager_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxSaldo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown tbxSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tbxCelular;
        private System.Windows.Forms.NumericUpDown tbxTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUrlArchivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExaminarContrato;
        private System.Windows.Forms.TextBox tbxNombreEmpresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox tbxDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregarEmpresa;
        private System.Windows.Forms.OpenFileDialog ofdCargaContrato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExaminarPlanilla;
        private System.Windows.Forms.Label lblUrlPlanilla;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCargarPlanilla;
    }
}