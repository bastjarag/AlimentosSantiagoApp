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
    public partial class EmpresaEnConvenioManager : Form
    {
        public delegate void OnClose();
        public OnClose onClose;

        private string archivoContrato;
        private string archivoPlanilla;

        public EmpresaEnConvenioManager()
        {
            InitializeComponent();
        }

        private void EmpresaEnConvenioManager_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnExaminarContrato_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdCargaContrato.ShowDialog();
            if (result == DialogResult.OK)
            {
                lblUrlArchivo.Text = archivoContrato = ofdCargaContrato.FileName;
            }
        }

        private void btnAgregarEmpresa_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa((int)tbxSaldo.Value, (int)tbxTelefono.Value, (int)tbxCelular.Value, tbxDireccion.Text, tbxNombreEmpresa.Text, false);
            Task<string> respuesta = HttpManager.SimplePost<Empresa>("empresa", empresa);
            if (respuesta != null)
            {
                Debug.WriteLine(respuesta);
            }
        }

        private void EmpresaEnConvenioManager_Load(object sender, EventArgs e)
        {

        }
    }
}
