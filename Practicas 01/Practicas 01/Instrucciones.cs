using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_01
{
    internal class Instrucciones
    {
        /*
          Dictionary<string, int> ejercicio = new Dictionary<string, int>
             {
                 { "Correr", 60},
                 { "Boxeo", 40},
                 { "Gimnasio", 30}
             };

             Dictionary<string, int> registro = new Dictionary<string, int>();

             Console.WriteLine("===== COMIENZO DEL DÍA =====");
             Console.Write("\nCuánta energía tiene el jugador?: ");

             int energia = 0;
             bool ok = false;

             while (!ok)
             {
                 string inputEnergia = Console.ReadLine();
                 if (int.TryParse(inputEnergia, out energia))
                 {
                     Console.WriteLine($"El jugador comienza el día con {energia} puntos de energía.");
                     ok = true;
                 }
                 else
                 {
                     Console.Write("Ingrese un valor válido: ");
                 }
             }

             while (energia > 0)
             {
                 Console.WriteLine("\nOpciones: ");
                 foreach (var item in ejercicio)
                 {
                     Console.WriteLine($"- {item.Key}: Cuesta {item.Value} de energia");
                 }
                 Console.WriteLine("- Dormir.");

                 Console.Write($"Qué querés entrenar? Te quedan {energia} puntos de energía: ");
                 string elec = Console.ReadLine();
                 if (elec == "Dormir"){break;}
                 if (ejercicio.ContainsKey(elec))
                 {
                     if (energia >= ejercicio[elec])
                     {
                         Console.WriteLine($"\nEntrenaste {elec} de manera exitosa!");
                         if (registro.ContainsKey(elec))
                         {
                             registro[elec] += 1;
                         }
                         else
                         {
                             registro.Add(elec, 1);
                         }
                         energia -= ejercicio[elec];
                     }
                     else
                     {
                         Console.WriteLine("Energía muy baja. Probá otro entrenamiento o anda a dormir.");
                     }

                 }
             }

             Console.WriteLine("Salida del while");

             Console.WriteLine("===== CIERRE DEL DÍA =====");
             Console.WriteLine("Entrenaste lo siguiente:");

             foreach (var item in registro)
             {
                 Console.WriteLine($"{item.Key} - {item.Value} veces.");
             }
         */

    }
}
