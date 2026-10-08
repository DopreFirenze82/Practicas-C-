using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_01
{
    class Luchador
    {
        public string nombre;
        public int vida { get; private set; }
        public int dañoMin;
        public int dañoMax;

        public Luchador(string nombre, int vida, int dañoMin, int dañoMax)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.dañoMin = dañoMin;
            this.dañoMax = dañoMax;
        }
        Random dado = new Random();
        public int Atacar()
        {
            int ataque = dado.Next(dañoMin, dañoMax + 1);
            return ataque;
        }

        public void RecibirDaño(int ataque)
        {
            vida -= ataque;
            Console.WriteLine($"¡{nombre} recibe {ataque} puntos de daño! Vida restante: {vida}!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Luchador cab = new Luchador("Caballero", 100, 10, 20);
            Luchador orc = new Luchador("Orco", 85, 5, 25);

            Console.WriteLine("--- APARECEN DOS LUCHADORES EN LA ARENA ---");
            Console.WriteLine($"\n¡De un lado hay un {cab.nombre}, que se enfrentará a un temible {orc.nombre}!");
            Console.WriteLine("\nComienza el combate:");

            int ronda = 1;
            while (cab.vida > 0 && orc.vida > 0)
            {
                Console.WriteLine($"\nRonda {ronda}:");
                int ataqueCab = cab.Atacar();
                orc.RecibirDaño(ataqueCab);


                int ataqueOrc = orc.Atacar();
                cab.RecibirDaño(ataqueOrc);
                ronda++;

            }

            Resultado(cab.vida, orc.vida);
        }
        static void Resultado(int vidaCab, int vidaOrc)
        {
            if (vidaCab <= 0 && vidaOrc > 0)
            {
                Console.WriteLine($"El caballero ha sido derrotado a manos del orco!");
            }
            else if (vidaOrc <= 0 && vidaCab > 0)
            {
                Console.WriteLine($"El orco ha sido derrotado a manos del caballero!");
            }
            else
            {
                Console.WriteLine("Ambos luchadores han perecido en batalla por sus heridas.");
            }
        }
    }
}
