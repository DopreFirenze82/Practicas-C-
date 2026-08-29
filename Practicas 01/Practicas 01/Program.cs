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
                { "Pesas", 50},
                { "Soga", 100},
                { "Saco", 150},
            };

            Console.Write("Cuántas monedas tenes?: ");
            string inputMonedas = Console.ReadLine();

            if (int.TryParse(inputMonedas, out int monedas))
            {
                Console.WriteLine($"\nCon {monedas} podes comprar los siguientes artículos:");
                foreach (var item in catalogo)
                {
                    Console.WriteLine($"Producto: {item.Key}.");
                }

                Console.Write("¿Qué querés comprar?: ");
                string compra = Console.ReadLine();

                if (catalogo.ContainsKey(compra))
                {
                    Console.WriteLine($"El producto {compra} cuesta ${catalogo[compra]}");
                }
                else
                {
                    Console.WriteLine("No tenemos eso.");
                }
            }
            else
            {
                Console.WriteLine("\nQué descís flaco? Raja de acá.");
            }
        }
    }    
}
