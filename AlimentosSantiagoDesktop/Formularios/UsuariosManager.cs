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

namespace AlimentosSantiagoDesktop.Formularios
{
    public partial class UsuariosManager : Form
    {
        private List<Usuario> usuarios;
        private Usuario usuarioSelec;

        public UsuariosManager()
        {
            InitializeComponent();
            usuarios = new List<Usuario>();
            ActualizarLista();
        }

        private void DgvCellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuarioSelec = usuarios[e.RowIndex];
            tbxApellMaterno.Text = usuarioSelec.apellMaterno;
            tbxApellPaterno.Text = usuarioSelec.apellPaterno;
            tbxCartera.Value = usuarioSelec.cartera;
            tbxCelular.Value = usuarioSelec.celular;
            tbxDireccion.Text = usuarioSelec.direccion;
            tbxDv.Text = usuarioSelec.divRut.ToString();
            tbxEmail.Text = usuarioSelec.email;
            tbxNombre.Text = usuarioSelec.nombre;
            tbxRut.Value = usuarioSelec.rut;
            tbxTelefono.Value = usuarioSelec.telefono;
            tbxUsuario.Text = usuarioSelec.usuario;
            tbxPassword.Text = usuarioSelec.password;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            usuarioSelec = null;
            tbxUsuario.Text = tbxPassword.Text = tbxApellMaterno.Text = 
                tbxApellPaterno.Text = tbxDireccion.Text = tbxDv.Text =
                tbxEmail.Text = tbxNombre.Text = String.Empty;
            tbxCartera.Value = tbxCelular.Value = tbxRut.Value = tbxTelefono.Value = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.apellMaterno = tbxApellMaterno.Text;
            usuario.apellPaterno = tbxApellPaterno.Text;
            usuario.cartera = (int)tbxCartera.Value;
            usuario.celular = (int)tbxCelular.Value;
            usuario.direccion = tbxDireccion.Text;
            usuario.divRut = tbxDv.Text[0];
            usuario.email = tbxEmail.Text;
            usuario.nombre = tbxNombre.Text;
            usuario.rut = (int)tbxRut.Value;
            usuario.telefono = (int)tbxTelefono.Value;
            usuario.usuario = tbxUsuario.Text;
            usuario.password = tbxPassword.Text;
            if (usuarioSelec != null)
            {
                usuario.id = usuarioSelec.id;
                if (HttpManager.SimplePut<Usuario>("usuario", usuario))
                    MessageBox.Show("Usuario actualizado");
                else
                    MessageBox.Show("Nose pudo actualizar el usuario");

                usuarioSelec = usuario;
                ActualizarLista();
                return;
            }
            if (HttpManager.PostDescerializar<Usuario>("usuario", ref usuario))
                MessageBox.Show("Usuario guardado con exito");
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            HttpManager.ListarDataGrid<Usuario>("usuario", ref dgvUsuarios, out usuarios);
        }
    }
}
