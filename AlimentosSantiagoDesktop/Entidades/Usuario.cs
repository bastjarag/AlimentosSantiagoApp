using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiagoDesktop.Entidades
{
    class Usuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public string nombre { get; set; }
        public string apellPaterno { get; set; }
        public string apellMaterno { get; set; }
        public DateTime fechaRegistro { get; set; }
        public int rut { get; set; }
        public char divRut { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public int celular { get; set; }
        public string email { get; set; }
        public int cartera { get; set; }
    }
}
