using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_01
{
    internal class Program
    {
        struct Credenciales
        {
            public string usuario;
            public int ping;
            public string rol;

            public Credenciales (string usuario, int ping, string rol)
            {
                this.usuario = usuario;
                this.ping = ping;
                this.rol = rol;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("IDENTIFICARSE\n\n");

            Credenciales datos = LogIn();

            Console.WriteLine($"Usuario: {datos.usuario}. Ping: {datos.ping}. Rol: {datos.rol}.");

            datos = IntentoHackeo(datos);

            Console.WriteLine($"Rol después del ataque: {datos.rol}.");
        }

        static Credenciales LogIn()
        {
            Console.Write("Ingrese su usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Ingrese su ping: ");
            int ping = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese su rol: ");
            string rol = Console.ReadLine();

            return new Credenciales(usuario, ping, rol);
        }

        static Credenciales IntentoHackeo(Credenciales datosClonados)
        {
            datosClonados.rol = "Usuario baneado";
            return datosClonados;
        }
    }
}
