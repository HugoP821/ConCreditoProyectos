using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   class Program
    {
        static char opc = 's';
        static void Anagrama(string palabra1, string palabra2)
        {
            bool anagrama;
            if (palabra1.Length != palabra2.Length)
            {
                anagrama = false;
            }
            else
            {
                char[] letras1 = palabra1.ToCharArray();
                Array.Sort(letras1);
                char[] letras2 = palabra2.ToCharArray();
                Array.Sort(letras2);
                string pal = new string(letras1);
                string pal2 = new string(letras2);
                if (pal == pal2)
                {
                    anagrama = true;
                }
                else
                {
                    anagrama = false;
                }

            }
                if (anagrama == true)
                {
                    Console.WriteLine("¡Las palabras {0} y {1} son anagramas!", palabra1, palabra2);
                }
                else
                {
                    Console.WriteLine("Las palabras {0} y {1} NO son anagramas.", palabra1, palabra2);
                }

                Console.WriteLine("Otro? s/n");
                opc = Console.ReadKey().KeyChar;
                if (opc == 's')
                {
                    Console.WriteLine("Ingrese la primer cadena: ");
                    palabra1 = Console.ReadLine().ToLower();
                    Console.WriteLine("Ingrese la segunda cadena");
                    palabra2 = Console.ReadLine().ToLower();
                    Anagrama(palabra1, palabra2);
                }
        }
        static void Main(string[] args)
        {
            string cadena1, cadena2;
            Console.WriteLine("Ingrese el primer string: ");
            cadena1 = Console.ReadLine().ToLower();
            Console.WriteLine("Ingrese el segundo string: ");
            cadena2 = Console.ReadLine().ToLower();
            Anagrama(cadena1, cadena2);
            Console.ReadKey();
        }
    }
}
