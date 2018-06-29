namespace AlimentosSantiagoDesktop.Formularios
{
    partial class MenuManager
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
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbxCantidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsProductosDisponibles = new System.Windows.Forms.ListBox();
            this.lsMenuActual = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaMenu = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaMenu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnQuitar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.tbxCantidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lsProductosDisponibles);
            this.groupBox1.Controls.Add(this.lsMenuActual);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 432);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear menu";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(244, 177);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 47);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.Text = ">";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(244, 76);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 47);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "<";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.Location = new System.Drawing.Point(10, 329);
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(198, 22);
            this.tbxCantidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Productos Disponibles";
            // 
            // lsProductosDisponibles
            // 
            this.lsProductosDisponibles.FormattingEnabled = true;
            this.lsProductosDisponibles.ItemHeight = 16;
            this.lsProductosDisponibles.Location = new System.Drawing.Point(352, 42);
            this.lsProductosDisponibles.Name = "lsProductosDisponibles";
            this.lsProductosDisponibles.Size = new System.Drawing.Size(198, 260);
            this.lsProductosDisponibles.TabIndex = 2;
            // 
            // lsMenuActual
            // 
            this.lsMenuActual.FormattingEnabled = true;
            this.lsMenuActual.ItemHeight = 16;
            this.lsMenuActual.Location = new System.Drawing.Point(10, 42);
            this.lsMenuActual.Name = "lsMenuActual";
            this.lsMenuActual.Size = new System.Drawing.Size(198, 260);
            this.lsMenuActual.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Día";
            // 
            // dtpFechaMenu
            // 
            this.dtpFechaMenu.Location = new System.Drawing.Point(10, 374);
            this.dtpFechaMenu.Name = "dtpFechaMenu";
            this.dtpFechaMenu.Size = new System.Drawing.Size(198, 22);
            this.dtpFechaMenu.TabIndex = 9;
            // 
            // MenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 457);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuManager";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown tbxCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsProductosDisponibles;
        private System.Windows.Forms.ListBox lsMenuActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaMenu;
        private System.Windows.Forms.Label label4;
    }
}