using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiagoDesktop.Entidades
{
    public class Proveedor
    {
        public int id { get; set; }
        public String direccion { get; set; }
        public int telefono_fijo { get; set; }
        public int telefono_celular { get; set; }
        public String nombre { get; set; }
        public String email { get; set; }
    }
}
