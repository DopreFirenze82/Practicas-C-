using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_01
{
    class Item
    {
        public string Nombre { get; set;}
        public int Precio { get; private set; }

        public Item (string nombre, int precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item> carrito = new List<Item>();
            carrito.Add(new Item("Runa de fuego", 100));
            carrito.Add(new Item("Runa de agua", 150));
            carrito.Add(new Item("Runa de rayo", 200));

            int total = 0;
            int i = 1;
            foreach (var item in carrito)
            {
                Console.WriteLine($"{i}- {item.Nombre}: ${item.Precio}.");
                i++;
                total += item.Precio;                
            }
            Console.WriteLine($"\nEl total gastado es de: ${total}.");
        }
    }
}
