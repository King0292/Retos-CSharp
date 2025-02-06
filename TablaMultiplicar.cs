using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetosCSharp
{
    internal class TablaMultiplicar
    {
        public static void MostrarTabla()
        {
            try
            {
                Console.WriteLine("Escriba un numero para obtener su tabla: ");
                if (!int.TryParse(Console.ReadLine(), out int multiplier))
                {
                    Console.WriteLine("Error: Debe ingresar un numero entero valido.");
                    return;
                }

                Console.WriteLine("Escriba el rango de la tabla: ");
                if (!int.TryParse(Console.ReadLine(), out int rango) || rango < 0)
                {
                    Console.WriteLine("Error: Debe ingresar un numero entero positivo para el rango.");
                    return;
                }

                for (int i = 0; i <= rango; i++)
                {
                    int result = i * multiplier;
                    Console.WriteLine($"{multiplier} x {i} = {result}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error inesperado: {ex.Message}");
            }
        }
    }
}
