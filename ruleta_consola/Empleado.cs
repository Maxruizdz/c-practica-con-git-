using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ruleta_consola
{
    public class Empleado : Persona
    {
        public Empleado(string nombre, string apellido) : base(nombre, apellido)
        {
        }

        public override string Descripc()
        {
            return "el nombre del empleado es:" + base.nombre + "\n" + "Apellido:"+ base.apellido;
        }
    }
}
