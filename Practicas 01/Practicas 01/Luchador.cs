using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_01
{
    internal class Luchador
    {
        public string Nombre;
        public int Energia;
        public int Dinero;

        public Luchador(string nombreInicial, int energiaInicial, int dineroInicial)
        {
            Nombre = nombreInicial;
            Energia = energiaInicial;
            Dinero = dineroInicial;
        }
        
        public void Trabajar(int horas)
        {
            if (Energia > 10)
            {

                Energia -= horas * 10;
                Dinero += horas * 15;
                Console.WriteLine($"{Nombre} trabajó {horas} horas. Perdío {horas * 10} puntos de energía y ganó ${Dinero}.");
            }
            else
            {
                Console.WriteLine($"{Nombre} no tiene suficiente energía para trabajar.");
            }
        }
        
        public void Comer()
        {
            if (Dinero > 20)
            {
                Dinero -= 20;
                Energia += 30;

                Console.WriteLine($"{Nombre} comío y recuperó 30 puntos de energía. Gastó $20.");
            }
            else
            {
                Console.WriteLine($"{Nombre} no tiene suficiente dinero para comer, con ${Dinero} no le alcanza.");
            }
        }
        
        public void MostrarEstadisticas()
        {
            Console.WriteLine($"{Nombre} tiene {Energia} puntos de energía y ${Dinero}.");
        }
    }
}
