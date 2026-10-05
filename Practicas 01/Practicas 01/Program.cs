using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_01
{
    internal class Program
    {
        struct Atributos
        {
            public int fuerza;
            public int agilidad;
            public int inteligencia;

            public Atributos (int fuerza, int agilidad, int inteligencia)
            {
                this.fuerza = fuerza;
                this.agilidad= agilidad;
                this.inteligencia = inteligencia;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("CREACIÓN DE PERSONAJE\n ");

            Atributos atributos = pedirDatos();

            Console.WriteLine("\n--- PERSONAJE CREADO CON ÉXITO ---");

            Console.WriteLine("\nSu personaje tiene los siguientes atributos: ");
            Console.WriteLine($"-Fuerza: {atributos.fuerza}\n" +
                $"-Agilidad: {atributos.agilidad}\n" +
                $"-Inteligencia: {atributos.inteligencia}");
           
        }

        static Atributos pedirDatos()
        {
            Console.WriteLine("Ingrese las estadísticas de su personaje:");
            Console.Write("- Fuerza: ");
            int fuerza = Convert.ToInt32(Console.ReadLine());

            Console.Write("- Agilidad: ");
            int agilidad = Convert.ToInt32(Console.ReadLine());

            Console.Write("- Inteligencia: ");
            int inteligencia = Convert.ToInt32(Console.ReadLine());

            return new Atributos(fuerza, agilidad, inteligencia);
        }
    }
}
