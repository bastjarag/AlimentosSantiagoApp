using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlimentosSantiagoDesktop.Entidades;
using AlimentosSantiagoDesktop.Utilidades;
using System.Diagnostics;


namespace AlimentosSantiagoDesktop.Formularios
{
    public partial class ProductosManager : Form
    {
        public delegate void OnClose();
        public OnClose onClose;
        private List<Producto> productos;
        private Producto prodEscogido;

        public ProductosManager()
        {
            InitializeComponent();
            HttpManager.ListarDataGrid<Producto>("producto", ref dgvProductos, out productos);

        }

        private void dgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine("Llama al evento");
            prodEscogido = productos[e.RowIndex];
            tbxDescripcion.Text = prodEscogido.descripcion;
            tbxNombre.Text = prodEscogido.nombre;
            tbxPrecio.Value = prodEscogido.precio;
            tbxStock.Value = prodEscogido.stock;
            btnBorrar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            prodEscogido = null;
            btnBorrar.Enabled = false;
        }
    }
}
