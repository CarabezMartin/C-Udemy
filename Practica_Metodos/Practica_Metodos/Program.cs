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
            
            int num1, num2, res;

            Console.WriteLine("Ingrese el primer numero: ");
            num1 = Convert.ToInt16(Console.ReadLine());

            try
            {
                Console.WriteLine(num1 / 0);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede realizar una division entre 0.");
            }
                      
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
