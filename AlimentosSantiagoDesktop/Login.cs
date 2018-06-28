using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using AlimentosSantiagoDesktop.Utilidades;
using AlimentosSantiagoDesktop.Entidades;
using AlimentosSantiagoDesktop.Formularios;
using System.Threading.Tasks;

namespace AlimentosSantiagoDesktop
{
    public partial class frLogin : Form
    {
        public frLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine("realizando solicitúd");
            //Debug.WriteLine(HttpManager.PeticionGetSimple("usuario/listar").Result);
            Login login = new Login();
            login.usuario = tbxUsuario.Text;
            login.password = tbxPassword.Text;
            Debug.WriteLine("realizando solicitúd");
            Task<string> resultado = HttpManager.SimplePost<Login>("usuario/login", login);
            if (resultado != null)
            {
                bool credCorrectas = Boolean.Parse(resultado.Result);
                if (credCorrectas)
                {
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    menuPrincipal.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Usuario o contraseña incorrrecto, reintente", "Error");
            }
            else
                Debug.WriteLine("Algo salió mal en la conexión");
        }
    }
}
