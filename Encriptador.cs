using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetosCSharp
{
    internal class Encriptador
    {
        static Dictionary<int, string> valoresParesDeCadenas = new Dictionary<int, string>();
        // Metodo para cifrar los datos
        public static string Cifrador(string text, int key)
        {
            char[] caracteres = text.ToCharArray(); // Argumento pasado a Array char type
            for (int i = 0; i < caracteres.Length; i++)
            {
                if (char.IsLetter(caracteres[i]))
                {
                    char baseChar = char.IsUpper(caracteres[i]) ? 'A' : 'a'; // Determinamos si es mayúscula o minúscula
                    caracteres[i] = (char)((caracteres[i] - baseChar + key) % 26 + baseChar);
                }
                else if (char.IsDigit(caracteres[i]))
                {
                    caracteres[i] = (char)((caracteres[i] - '0' + key) % 10 + '0'); // Cifrado para dígitos
                }
            }
            return new string(caracteres);
        }

        // Metodo para descifrar los datos
        public static string Descifrador(string text, int key) 
        {
            return Cifrador(text, -key);
        }
        // Metodo de muestreo de la lista
        public static void Muestra_Diccionario()
        { 
            Console.WriteLine("Mostrando los textos cifrados guardados:");
            if (valoresParesDeCadenas.Count == 0)
            {
                Console.WriteLine("No hay textos cifrados guardados.");
            }
            else
            {
                foreach (var item in valoresParesDeCadenas)
                {
                    Console.WriteLine($"Clave: {item.Key}, Texto cifrado: {item.Value}");
                }
            }
        }
        
        public static void Encriptado()
        {
            int opciones = 0;
            while (opciones != 4)
            {

                Console.WriteLine("Que desea hacer?\n1 - Cifrar Texto\n2 - Descifrar Texto\n3 - Ver tus textos cifrados\n4 - Salir\n");
                try
                {
                    opciones = Convert.ToInt32(Console.ReadLine());
                    if (opciones < 1 || opciones > 4)
                    {
                        Console.WriteLine("Opcion no valida. Por favor, elija entre 1 y 4.");
                        continue;
                    }


                    switch (opciones)
                    {
                        case 1:
                            try
                            {
                                Console.WriteLine("Ingrese el texto a cifrar:");
                                string texto_c = Console.ReadLine();

                                Console.WriteLine("Ingrese la clave para el cifrado:");
                                if (!int.TryParse(Console.ReadLine(), out int clave_c))
                                {
                                    Console.WriteLine("Error: La clave debe ser un numero entero.");
                                    break;
                                }

                                string texto_cifrado = Cifrador(texto_c, clave_c);
                                Console.WriteLine($"Su texto cifrado es: {texto_cifrado}\nLa clave usada para este cifrado fue: {clave_c}");

                                valoresParesDeCadenas[clave_c] = texto_cifrado; // Guardamos en el diccionario
                                Console.WriteLine("Texto agregado a la lista correctamente.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Ocurrio un error: {ex.Message}");
                            }
                            break;
                        case 2:
                            try
                            {
                                Console.WriteLine("Ingrese el texto a descifrar");
                                string texto_d = Console.ReadLine();
                                Console.WriteLine("Ingrese la clave para el descifrado");
                                int clave_d = Convert.ToInt32(Console.ReadLine());
                                string texto_descifrado = Descifrador(texto_d, clave_d);
                                Console.WriteLine($"Su texto descifrado es: {texto_descifrado}\nLa clave usada para este descifrado fue: {clave_d}\n");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Ocurrio un error: {ex.Message}");
                            }
                            break;
                        case 3:
                            Console.WriteLine("================================");
                            Muestra_Diccionario();
                            Console.WriteLine("================================\n");
                            break;
                        case 4:
                            Console.WriteLine("Saliendo...");
                            break;
                    }
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
        }   
    }
}
