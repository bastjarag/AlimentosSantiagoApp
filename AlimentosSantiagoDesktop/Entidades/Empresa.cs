using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiagoDesktop.Entidades
{
    public class Empresa
    {
        public int id;
        public int saldoMes, telefono, celular;
        public String direccion, urlPlanilla, urlContrato, nombre;
        public bool convenio;

        public Empresa()
        {
        }

        public Empresa(int saldoMes, int telefono, int celular, string direccion, string nombre, bool convenio)
        {
            this.saldoMes = saldoMes;
            this.telefono = telefono;
            this.celular = celular;
            this.direccion = direccion;
            urlPlanilla = String.Empty;
            urlContrato = String.Empty;
            this.nombre = nombre;
            this.convenio = convenio;
        }

        public Empresa(int id, int saldoMes, int telefono, int celular, string direccion, string urlPlanilla, string urlContrato, string nombre, bool convenio)
        {
            this.id = id;
            this.saldoMes = saldoMes;
            this.telefono = telefono;
            this.celular = celular;
            this.direccion = direccion;
            this.urlPlanilla = urlPlanilla;
            this.urlContrato = urlContrato;
            this.nombre = nombre;
            this.convenio = convenio;
        }
    }
}
