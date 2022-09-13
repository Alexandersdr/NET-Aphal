// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace Calculador 
{
    class Program
    {
        static void Main(string[] args)
        {
            
         Console.Clear();

         Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

         Console.WriteLine("Sengundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            
            Console.WriteLine($"O resultado da Multriplicar é + {resultado}");
            Console.WriteLine($"O resultado da Soma é + {v1 + v2}");
            Console.WriteLine($"O resultado da Dividir é + {v1 / v2}");
            Console.WriteLine($"O resultado da Subtrair é + {v1 - v2}");

        }
    }
}
