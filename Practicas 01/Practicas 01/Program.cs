using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_01
{
    class Enemigo
    {
        public string nombre;
        public int salud;
        public Enemigo(string nombre, int salud)
        {
            this.nombre = nombre;
            this.salud = salud;
        }

        public void RecibirDaño(int daño)
        {
            salud -= daño;
            Console.WriteLine($"{nombre} recibió {daño}. Vida restante: {salud}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemigo goblin = new Enemigo("Goblin", 100);
            Console.WriteLine($"Apareció un enemigo: {goblin.nombre}, con {goblin.salud} puntos de vida.");

            goblin.RecibirDaño(30);
            goblin.RecibirDaño(20);
        }
    }
}
