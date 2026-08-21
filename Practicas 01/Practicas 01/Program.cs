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
            string[] productos = { "Arroz", "Pan", "Carne", "Agua", "Manteca"};
            Dictionary<string, int> precios = new Dictionary<string, int>
            {
                { productos[0], 5},
                { productos[1], 4},
                { productos[2], 25},
                { productos[3], 10},
                { productos[4], 15}
            };
            List<string> registro = new List<string>();

            Random rng = new Random();

            int clientes = rng.Next(1, 6);

            Console.WriteLine("===== TIENDA ABIERTA =====\n\n");

            for (int i = 0; i < clientes; i++)
            {
                int pedido = rng.Next(0, productos.Length);
                Console.Write($"Entra un cliente y pide lo siguiente: {productos[pedido]}.\n");
                registro.Add(productos[pedido]);
                Console.WriteLine("El cliente se retira.\n");
            }

            Console.WriteLine("===== TIENDA CERRADA =====\n\n");
            Console.WriteLine($"{clientes} cllientes han comprado los siguientes artículos:\n");
            for (int i = 0; i < registro.Count; i++)
            {
                Console.WriteLine(registro[i]);
            }



        }
    }
}
