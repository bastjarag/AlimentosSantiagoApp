namespace AlimentosSantiagoDesktop.Formularios
{
    partial class MenuPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.brnMenu = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnBodega = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEmpresaAdministrar = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // brnMenu
            // 
            this.brnMenu.Location = new System.Drawing.Point(16, 34);
            this.brnMenu.Name = "brnMenu";
            this.brnMenu.Size = new System.Drawing.Size(113, 32);
            this.brnMenu.TabIndex = 1;
            this.brnMenu.Text = "Menu Diario";
            this.brnMenu.UseVisualStyleBackColor = true;
            this.brnMenu.Click += new System.EventHandler(this.brnMenu_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(16, 73);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(113, 32);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bodega";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clientes e usuarios";
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(178, 34);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(113, 32);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Administrar";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnBodega
            // 
            this.btnBodega.Location = new System.Drawing.Point(19, 134);
            this.btnBodega.Name = "btnBodega";
            this.btnBodega.Size = new System.Drawing.Size(111, 54);
            this.btnBodega.TabIndex = 6;
            this.btnBodega.Text = "Bodega proveedores";
            this.btnBodega.UseVisualStyleBackColor = true;
            this.btnBodega.Click += new System.EventHandler(this.btnBodega_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Proveedores";
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(178, 94);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(113, 32);
            this.btnProveedores.TabIndex = 8;
            this.btnProveedores.Text = "Administrar";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Empresas";
            // 
            // btnEmpresaAdministrar
            // 
            this.btnEmpresaAdministrar.Location = new System.Drawing.Point(178, 156);
            this.btnEmpresaAdministrar.Name = "btnEmpresaAdministrar";
            this.btnEmpresaAdministrar.Size = new System.Drawing.Size(113, 32);
            this.btnEmpresaAdministrar.TabIndex = 10;
            this.btnEmpresaAdministrar.Text = "Administrar";
            this.btnEmpresaAdministrar.UseVisualStyleBackColor = true;
            this.btnEmpresaAdministrar.Click += new System.EventHandler(this.btnEmpresaAdministrar_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(121, 223);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 32);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 267);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEmpresaAdministrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBodega);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.brnMenu);
            this.Controls.Add(this.label1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brnMenu;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnBodega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEmpresaAdministrar;
        private System.Windows.Forms.Button btnLogout;
    }
}