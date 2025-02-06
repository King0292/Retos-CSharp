using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RetosCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Seleccione el programa que desea ejecutar:");
                Console.WriteLine("1. Encriptador");
                Console.WriteLine("2. Juego de Numeros Aleatorios");
                Console.WriteLine("3. Tabla de Multiplicar Personalizada");
                Console.WriteLine("0. Salir");
                Console.Write("Ingrese una opcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Encriptador.Encriptado();
                        break;
                    case "2":
                        NumerosRandom.Juego();
                        break;
                    case "3":
                        TablaMultiplicar.MostrarTabla();
                        break;
                    case "0":
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opcion no valida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
