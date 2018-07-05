using AlimentosSantiagoDesktop.Entidades;
using AlimentosSantiagoDesktop.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlimentosSantiagoDesktop.Formularios
{
    public partial class ProveedorManager : Form
    {
        public delegate void OnClose();
        public OnClose onClose;
        private List<Proveedor> proveedores;
        private Proveedor provEscogido;


        public ProveedorManager()
        {
            InitializeComponent();
            HttpManager.ListarDataGrid<Proveedor>("proveedor", ref dgvProveedores, out proveedores);
        }

        private void dgvProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine("Llama al evento");
            provEscogido = proveedores[e.RowIndex];
            tbxDireccion.Text = provEscogido.direccion;
            tbxTelefono.Value = provEscogido.telefono_fijo;
            tbxCelular.Value = provEscogido.telefono_celular;
            tbxNombre.Text = provEscogido.nombre;
         

            btnBorrar.Enabled = true;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            provEscogido = null;
            btnBorrar.Enabled = false;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            /*
             tbxDireccion.Text = provEscogido.direccion;
            tbxTelefono.Value = provEscogido.telefono_fijo;
            tbxCelular.Value = provEscogido.telefono_celular;
            tbxNombre.Text = provEscogido.nombre;
             */

            tbxDireccion.Text = tbxDireccion.Text = "";
            tbxTelefono.Value = tbxTelefono.Value = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
