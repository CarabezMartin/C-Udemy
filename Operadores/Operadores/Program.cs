using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 3, num3;

            //Operadores unarios
            num3 = -num1;
            Console.WriteLine("el valor de num3 es: {0}",num3);


            //Operadores de adicion
            num1++;
            Console.WriteLine(num1);
            Console.Read();
        }
    }
}
