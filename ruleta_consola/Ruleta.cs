using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ruleta_consola
{
    public class Ruleta
    {
        Random numeroRandom;
        int numero_ganador;

        public Ruleta() {


            this.numero_ganador=numeroRandom.Next(0, 37);


        }

        public Boolean aposta_numeros(Cliente cliente, int saldo_apostado, List<int>Numeros_apostados) {

            Boolean ronda_ganadora;
            Boolean ronda_valida;
            if (apuesta_valida(cliente, saldo_apostado, Numeros_apostados.Count) == true) {
                ronda_valida = true;

                if (comprobar_ganador(Numeros_apostados) == true) {
                    cliente.saldo = saldo_apostado * 36;






                }



            }
            else { ronda_valida = false; }


            return ronda_valida;
            


        }
        public Boolean apuesta_valida(Cliente cliente, int saldo_apostado, int cantidad_numeros_jugados) 
        {
            Boolean apuesta_valida ;
            int saldo = cliente.saldo - (saldo_apostado * cantidad_numeros_jugados);
            if (saldo >= 0)
            {
                cliente.saldo=cliente.saldo - (saldo_apostado * cantidad_numeros_jugados);
                apuesta_valida = true;
            }
            else apuesta_valida = false;


            return apuesta_valida;
        
        
        
        
        
        }

        public Boolean comprobar_ganador(List<int> numeros_apostados ) {
            Boolean num_gana = false;
          

            foreach (int i in numeros_apostados) {

                if (this.numero_ganador == i)
                {
                    num_gana = true;
                    break;



                }
                else {num_gana = false; }
            
            
            }



            return num_gana;
        
        
        
        
        }
    }
}
