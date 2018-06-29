using AlimentosSantiagoDesktop.Utilidades;
using AlimentosSantiagoDesktop.Entidades;
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
    public partial class MenuManager : Form
    {
        public delegate void OnClose();
        public OnClose onClose;

        public MenuManager()
        {
            InitializeComponent();
            HttpManager.ListarDataGrid<Producto>("producto/productos_stock", ref )
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            onClose();
        }
    }
}
