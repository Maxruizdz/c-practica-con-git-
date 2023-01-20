using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ruleta_consola
{
    public class Cliente: Persona
    {
        public int saldo { get; set; }

        public Cliente(string nombre, string apellido, int saldo) : base(nombre, apellido)
        {
            this.saldo = saldo;
        }

        public override string Descripc()
        {
            return "el nombre :" + base.nombre + "\n" + "Apellido:" + base.apellido  ;
        }
        public int ver_Saldo() {


            return saldo;
        }
    }
}
