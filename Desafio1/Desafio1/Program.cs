using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string miString;

            Console.WriteLine("Por favor, ingresa tu nombre y presiona enter: ");
            miString = Console.ReadLine();

            Console.WriteLine(miString.ToUpper());
            Console.WriteLine(miString.ToLower());
            Console.WriteLine(miString.Trim());
            Console.WriteLine(miString.Substring(3));

            Console.Read();
        }
    }
}
