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
            Dictionary<string, int> cantReps = new Dictionary<string, int>
            {
                { "Flexiones", 20},
                { "Dominadas", 8},
                { "Sentadillas", 25},
                { "Abdominales", 50}
            };
            Dictionary<string, int> registro = new Dictionary<string ,int>();

            Bienvenida(cantReps);

            PedirEjercicioySeries(cantReps, registro);
            ImprimirResumen(registro, cantReps);
        }
        static void Bienvenida(Dictionary<string, int> cantReps)
        {
            Console.WriteLine("===== RUTINA DE CALISTENIA =====");
            Console.WriteLine("\nPreparate para entrenar!\n");
       
            Console.WriteLine("Ejercicios:");
            foreach (var item in cantReps)
            {
                Console.WriteLine($" - {item.Key}");
            }
        }
        static void PedirEjercicioySeries(Dictionary<string, int> cantReps, Dictionary<string, int> registro)
        {
            Console.WriteLine("\nArmando la rutina:");

            foreach (var item in cantReps)
            {
                Console.Write($"Cuántas series de {item.Key} vas a hacer hoy? (0 si ninguna): ");
                int series = Convert.ToInt32(Console.ReadLine());
                if (series > 0)
                {
                    registro.Add(item.Key, series);
                }
            }
        }
        static void ImprimirResumen(Dictionary<string, int> registro, Dictionary<string, int> cantReps)
        {
            Console.WriteLine("\n===== FINAL DEL ENTRENAMIENTO =====");

            foreach(var item in registro)
            {
                Console.WriteLine($"\n - Ejercicio: {item.Key} - Series: {item.Value}");
                Console.WriteLine($"   REPETICIONES: {cantReps[item.Key] * item.Value}");
            }
        }

   
    }    
}
