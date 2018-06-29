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

        private List<Producto> stockDisponible;
        private List<Producto> menuDelDia;
        public MenuManager()
        {
            InitializeComponent();
            stockDisponible = HttpManager.GetListar<Producto>("producto/productos_stock");
            lsProductosDisponibles.DataSource = stockDisponible;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                onClose();
            }
            catch (NullReferenceException)
            {
                Application.Exit();
            }
        }
    }
}
