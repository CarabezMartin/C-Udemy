using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Multiplicar(15, 14));
            Console.Read();
        }

        #region Metodos sin valor de retorno
        public static void Escribe() 
        {
            Console.WriteLine("Escribiendo desde el metodo.");            
        }

        public static void EscibeEspicifico(string texto) 
        {
            Console.WriteLine(texto);            
        }
        #endregion

        #region Metodos con valor de retorno
        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
        #endregion
    }
}
