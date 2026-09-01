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
            Console.WriteLine("Creación de trabajador:\n");

            Console.Write("Ingrese un nombre: ");
            string nombreInicial = Console.ReadLine();
            Console.Write("Energía: ");
            int energiaInicial = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero: ");
            int dineroInicial = Convert.ToInt32(Console.ReadLine());

            Luchador trabajador1 = new Luchador(nombreInicial, energiaInicial, dineroInicial);

            Console.WriteLine("\n=== EMPIEZA LA JORNADA ===");
            Console.Write($"Cuántas horas va a trabajar {nombreInicial}?: ");
            int horas = Convert.ToInt32(Console.ReadLine());

            trabajador1.Trabajar(horas);
            trabajador1.Comer();

            trabajador1.MostrarEstadisticas();
        }
    }    
}
