using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ruleta_consola
{
    public abstract class Persona
    {

        public string nombre { get; set; }
        public string apellido { get; set; }

        public Persona(string nombre , string apellido ) { 
        this.nombre = nombre;
            this.apellido = apellido;
        
        }
        public abstract string Descripc();


    }
}
