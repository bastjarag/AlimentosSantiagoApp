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
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.nombre = tbxNombre.Text;
            producto.descripcion = tbxDescripcion.Text;
            producto.precio = (int)tbxPrecio.Value;
            producto.stock = (int)tbxStock.Value;

            if (prodEscogido != null)
            {
                producto.id = prodEscogido.id;
                if (HttpManager.SimplePut<Producto>("producto", producto))
                    MessageBox.Show("Producto actualizado");

                prodEscogido = producto;
                HttpManager.ListarDataGrid<Producto>("producto", ref dgvProductos, out productos);
                return;
            }
            Task<string> respuesta = HttpManager.SimplePost<Producto>("producto", producto);
            if (respuesta != null)
            {
                if (Convert.ToBoolean(respuesta.Result))
                {
                    MessageBox.Show("Producto almacenado con exito");
                    HttpManager.ListarDataGrid<Producto>("producto", ref dgvProductos, out productos);
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (prodEscogido == null)
                return;

            if (HttpManager.SimpleDelete("producto", prodEscogido.id.ToString()))
            {
                MessageBox.Show("Producto borrado.");
                prodEscogido = null;
                HttpManager.ListarDataGrid<Producto>("producto", ref dgvProductos, out productos);
                btnBorrar.Enabled = false;
                LimpiarCampos();
            }
            else
                MessageBox.Show("No se pudo borrar el producto.");
        }

        private void LimpiarCampos()
        {
            tbxNombre.Text = tbxDescripcion.Text = "";
            tbxPrecio.Value = tbxStock.Value = 0;
        }
    }
}
