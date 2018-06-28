using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlimentosSantiagoDesktop.Formularios
{
    public partial class MenuPrincipal : Form
    {
        EmpresaEnConvenioManager frEmpresa;
        MenuManager frMenu;
        ProductosManager frProductos;
        ProveedorManager frProveedor;
        SolicitudEnLineaManager frSolicitudes;
        public MenuPrincipal()
        {
            frEmpresa = new EmpresaEnConvenioManager
            {
                onClose = Show
            };
            frMenu = new MenuManager
            {
                onClose = Show
            };
            frProductos = new ProductosManager
            {
                onClose = Show
            };
            frProveedor = new ProveedorManager
            {
                onClose = Show
            };
            frSolicitudes = new SolicitudEnLineaManager
            {
                onClose = Show
            };
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmpresaAdministrar_Click(object sender, EventArgs e)
        {
            Hide();
            frEmpresa.Show();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void brnMenu_Click(object sender, EventArgs e)
        {
            frMenu.Show();
            Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frProductos.Show();
            Hide();
        }

        private void btnBodega_Click(object sender, EventArgs e)
        {
            frProveedor.Show();
            Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frProveedor.Show();
            Hide();
        }
    }
}
