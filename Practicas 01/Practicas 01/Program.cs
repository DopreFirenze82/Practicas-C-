using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_01
{
    internal class Program
    {
        static Dictionary<int, string> categorias = new Dictionary<int, string>{{ 1, "Equipamiento"},{ 2, "Espadas" },{ 3, "Magia"}, { 4, "Atuendo"}};
        static Dictionary<string, int> equipamiento = new Dictionary<string, int>{{ "Poción de vida", 100},{ "Polvo de hada", 300},{ "Frasco de XP", 500},};
        static Dictionary<string, int> espadas = new Dictionary<string, int>{{ "Daga", 100},{ "Sable curvo", 300},{ "Excalibur", 1000},};
        static Dictionary<string, int> magia = new Dictionary<string, int>{{ "Varita", 400},{ "Báculo", 700}};
        static Dictionary<string, int> atuendo = new Dictionary<string, int>{{ "Mago", 600}, { "Guerrero", 300},{ "Asesino", 500}, };
    
        static void Main(string[] args)
        {

            List<string> registroItem = new List<string>();
            List<int> registroGasto = new List<int>();

            int dineroJugador = PreguntaPlata();

            Diccionario(categorias);
            int precio;
            bool sigue = true;
            do
            {
                int elec = Eleccion();

                string item = DevuelveItemPrecio(elec, out precio);

                if (PuedeComprar(dineroJugador, precio))
                {
                    Console.WriteLine($"¡Compraste '{item}' por ${precio}!");
                    dineroJugador -= precio;
                    registroItem.Add(item);
                    registroGasto.Add(precio);
                }
                else
                {
                    Console.WriteLine($"Con {dineroJugador} no te alcanza.");
                }
                Estado(dineroJugador);
                sigue = SeguirComprando();
            } while (sigue);

            Console.WriteLine("\n\nCierre de la compra.");
            EstadoFinal(dineroJugador, registroItem, registroGasto);

            
        }

        static void Diccionario(Dictionary<int, string> categorias)
        {
            Console.WriteLine("\nMenú de compras:\n");
            foreach (var item in categorias)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
        static int PreguntaPlata()
        {
            Console.Write("Cuánta plata tiene?: ");
            int dinero = Convert.ToInt32(Console.ReadLine());
            return dinero;
        }

        static int Eleccion()
        {
            Console.Write("\nElija qué categoría le intesa comprar: ");
            
            while (true)
            {
                string inputElec = Console.ReadLine();

                if (int.TryParse(inputElec, out int elec))
                {
                    return elec;   
                }
                else
                {
                    Console.Write("Error. Ingrese un número válido: ");
                }
            }
        }

        static string DevuelveItemPrecio(int eleccion, out int precio)
        {
            List<KeyValuePair<string, int>> listaOpciones;
            switch (eleccion)
            {
                case 1:
                    listaOpciones = equipamiento.ToList();
                    break;
                case 2:
                    listaOpciones = espadas.ToList();
                    break;
                case 3:
                    listaOpciones = magia.ToList();
                    break;
                case 4:
                    listaOpciones = atuendo.ToList();
                    break;    
                default:
                    Console.WriteLine("Número inválido.");
                    precio = 0;
                    return "Nada";
            }
            for (int i = 0; i < listaOpciones.Count(); i++)
            {
                Console.Write($"{i + 1} - {listaOpciones[i].Key} - ${listaOpciones[i].Value}\n");
            }
            Console.Write("\nQué querés comprar? (NUMÉRO): ");
            while (true)
            {
                string inputNum = Console.ReadLine();
                if (int.TryParse(inputNum, out int num))
                {
                    var itemElegido = listaOpciones[num - 1];
                    precio = itemElegido.Value;
                    return itemElegido.Key;
                }
                else
                {
                    Console.Write("Error. Ingresá un número válido: ");
                }
            }
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
        static void EstadoFinal(int dineroJugador,List<string> compra, List<int> gasto)
        {
            Console.WriteLine("\nItems comprados: ");
            int total = 0;
            int i = 0;
            foreach (var item in compra)
            {
                Console.WriteLine($".{item} - ${gasto[i]}");
                total += gasto[i];
                i++;
            }
            Console.WriteLine($"\nTotal gastado: ${total}");
            Console.WriteLine($"Dinero restante: ${dineroJugador}.");
        }

    }    
}
