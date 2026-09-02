using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> catalogo = new Dictionary<string, int>
            {
                { "USP-S", 200},
                { "MP9", 1250},
                { "M4A1-S", 2900},
                { "AK47", 2700}
            };
            Console.WriteLine("Menú de armas:\n");
            foreach (var item in catalogo)
            {
                Console.WriteLine($". {item.Key} - ${item.Value}");
            }

            int dineroJugador = PreguntaPlata();

            bool sigue = true;
            do
            {
                string elec = Eleccion();

                if (PuedeComprar(dineroJugador, catalogo[elec]))
                {
                    Console.WriteLine($"¡Compraste el arma por ${catalogo[elec]}!");
                    dineroJugador -= catalogo[elec];
                }
                else
                {
                    Console.WriteLine($"Con {dineroJugador} no te alcanza.");
                }
                Estado(dineroJugador);
                sigue = SeguirComprando();
            } while (sigue);
        }

        static int PreguntaPlata()
        {
            Console.Write("\nCuánta plata tiene?: ");
            int dinero = Convert.ToInt32(Console.ReadLine());
            return dinero;
        }

        static string Eleccion()
        {
            Console.Write("\nQué arma quisiera comprar?: ");
            string elec = Console.ReadLine();
            return elec;
        }

        static bool PuedeComprar(int dineroJugador, int costoArma)
        {
            if (dineroJugador >= costoArma){return true;}else{return false; }
        }

        static void Estado(int dinero)
        {
            Console.WriteLine($"Te quedan ${dinero} disponibles.");
        }

        static bool SeguirComprando()
        {
            Console.Write("Querés seguir comprando?: ");
            string respuesta = Console.ReadLine();
            if (respuesta == "Si") { return true; } else { return false;}
        }

    }    
}
