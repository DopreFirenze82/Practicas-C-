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
            string[] productos = { "Arroz", "Pan", "Carne", "Agua", "Manteca" };
            Dictionary<string, int> precios = new Dictionary<string, int>
            {
                { productos[0], 5},
                { productos[1], 4},
                { productos[2], 25},
                { productos[3], 10},
                { productos[4], 15}
            };
            List<string> registro = new List<string>();
            Dictionary<string, int> conteoRegistro = new Dictionary<string, int>();

            Random rng = new Random();
            int totalRecaudado = 0; 
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
            Console.WriteLine($"{clientes} clientes han comprado los siguientes artículos:\n");

            foreach (string item in registro)
            {
                if (conteoRegistro.ContainsKey(item))
                {
                    conteoRegistro[item]++;
                }
                else
                {
                    conteoRegistro.Add(item, 1);
                }
            }

            foreach (var item in conteoRegistro)
            {
                int precioUnitario = precios[item.Key];

                int precioFinal = precioUnitario;

                int probDescuento = rng.Next(1, 101);

                if (probDescuento > 50)
                {
                    precioFinal = precioUnitario / 2;
                    Console.WriteLine($"¡OFERTA! {item.Key} a mitad de precio.");
                }

                int subtotal = precioFinal * item.Value;

                totalRecaudado += subtotal;

                Console.WriteLine($"{item.Key} : {item.Value} u. x {precioUnitario} = ${subtotal}");
            }

            Console.WriteLine("\n");
            Console.WriteLine($"TOTAL DEL DÍA: {totalRecaudado}");

            
        }
    }
}
