using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_01
{
    internal class Program
    {
        static Dictionary<string, int> Comidas = new Dictionary<string, int> { { "Carne", 20 }, { "Pollo", 15 } };
        static Dictionary<string, int> Bebidas = new Dictionary<string, int> { { "Agua", 5 }, { "Leche", 10 } };
        static Dictionary<string, int> Suministros = new Dictionary<string, int> { { "Cuerda", 10 }, { "Antorcha", 5 } };
        static Dictionary<int, string> Categorias = new Dictionary<int, string> { { 1, "Comida" }, { 2, "Bebida" }, { 3, "Suministros" } };
        static void Main(string[] args)
        {
            List<string> registroItems = new List<string>();
            List<int> registroValor = new List<int>();

            int monedas = PedirOro();

            MostrarCategorias(Categorias);

            bool seguir = true;
            while (seguir)
            {
                int elec = EleccionMenu(Categorias);
                string item = DevuelveItemPrecio(elec, out int precio);
                Console.WriteLine($"\n--> Agregaste {item} al carrito por ${precio}");

                registroItems.Add(item);
                registroValor.Add(precio);

                Console.WriteLine("\nDesea seguir comprando? [Si o No]: ");

                seguir = SeguirComprando();

            }

            Console.WriteLine("\nAsí quedó su carrito: ");
            int total = Carrito(registroItems, registroValor);
            bool puedePagar = Paga(monedas, total, registroItems, out int resto);

            while (puedePagar == false)
            {
                Console.Write("\nElija un item a descartar: ");
                string inputDescarte = Console.ReadLine();
                if (int.TryParse(inputDescarte, out int descarte) && descarte <= registroItems.Count && descarte > 0)
                {
                    int indice = descarte - 1;
                    Console.WriteLine($"{registroItems[indice]} de ${registroValor[indice]} fue descartado del carrito.");
                    registroItems.RemoveAt(indice);
                    registroValor.RemoveAt(indice);
                }
                else
                {
                    Console.WriteLine("Valor inválido! Descartá un item de la lista.");
                }
                total = Carrito(registroItems, registroValor);
                puedePagar = Paga(monedas, total, registroItems, out resto);
            }

            


        }
        static int PedirOro()
        {
            Console.Write("Cuántas monedas tenés?: ");
            while (true)
            {
                string inputMonedas = Console.ReadLine();

                if (int.TryParse(inputMonedas, out int monedas))
                {
                    return monedas;
                }
                else
                {
                    Console.Write("Valor inválido! Volvé a ingresar la cantidad: ");
                }
            }
        }
        static void MostrarCategorias(Dictionary<int, string> Categorias)
        {
            Console.WriteLine("\nMenú de hoy:\n");
            foreach (var item in Categorias)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
        static int EleccionMenu(Dictionary<int, string> Categorias)
        {
            Console.Write("\nQué menú le interesa?: ");
            while (true)
            {
                string inputElec = Console.ReadLine();
                if (int.TryParse(inputElec, out int elec) && Categorias.ContainsKey(elec))
                {
                    return elec;
                }
                else
                {
                    Console.Write("Valor inválido! Vuelva a ingresar un N° que corresponda a un menú: ");
                }
            }
        }

        static string DevuelveItemPrecio(int elec, out int precio)
        {
            List<KeyValuePair<string, int>> listaOpciones;
            string menu = ""; 

            switch (elec)
            {
                case 1:
                    listaOpciones = Comidas.ToList();
                    menu = "Comidas";
                    break;
                case 2:
                    listaOpciones = Bebidas.ToList();
                    menu = "Bebidas";
                    break;
                case 3:
                    listaOpciones = Suministros.ToList(); 
                    menu = "Suministros";
                    break;
                default:
                    Console.WriteLine("Valor inválido!");
                    precio = 0;

                    return "Nada";
            }

            Console.WriteLine($"\nMenú {menu}:\n");

            for (int i = 0; i < listaOpciones.Count(); i++)
            {
                Console.Write($"{i + 1} - {listaOpciones[i].Key} - ${listaOpciones[i].Value}\n");
            }

            Console.Write("\nQué ítem desea comprar? [Número]: ");

            while (true)
            {
                int cantidad = listaOpciones.Count;
                string inputNum = Console.ReadLine();
                if (int.TryParse(inputNum, out int num) && num < cantidad + 1 && num > 0)
                {
                    var itemElegido = listaOpciones[num - 1];
                    precio = itemElegido.Value;
                    return itemElegido.Key;
                }
                else
                {
                    Console.WriteLine("Valor inválido! Vuelve a ingresar un número: ");
                }
            }

        }
        static bool SeguirComprando()
        {
            string SioNo = Console.ReadLine().ToUpper();
            
            if (SioNo == "SI")
            {
                return true;
            }
            else if (SioNo == "NO")
            {
                return false;
            }
            else
            {
                Console.WriteLine("No se entiende flaco, vas a seguir comprando.");
                return true;
            }
        }
        static int Carrito(List<string> Item, List<int> Valor)
        {
            int total = 0;
            for (int i = 0; i < Item.Count; i++)
            {
                Console.WriteLine($"{i+1}. {Item[i]} - ${Valor[i]}");
                total += Valor[i];
            }

            Console.WriteLine($"\nEl total a pagar es de ${total}.");

            return total;
        }
        static bool Paga(int dineroJugador, int total, List<string> Item ,out int resto)
        {
            
            if (dineroJugador >= total)
            {
                if (Item.Count != 0)
                {
                    Console.WriteLine($"La compra fue efectuada. Al jugador le restan ${dineroJugador - total}.");
                }
                else
                {
                    Console.WriteLine("El carrito esta vacío. Vuelva otro día!");
                }
                resto = dineroJugador - total;
                return true;
            }
            else
            {
                Console.WriteLine($"No tiene el dinero suficiente. Te faltan ${total - dineroJugador}");
                resto = total - dineroJugador;
                return false;
            }
        }
    }
}
