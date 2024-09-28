using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aplicacion 1
            string texto;
            char busqueda;

            Console.WriteLine("Ingrese un texto aqui: ");
            texto = Console.ReadLine();

            Console.WriteLine("Ingrese la letra a buscar: ");
            busqueda = Console.ReadLine()[0];

            Console.WriteLine("El caracter buscado se encuentra en la posicion: " + texto.IndexOf(busqueda));

            //Aplicacion 2
            string nombre, apellido, nombreCompleto;

            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su apellido:");
            apellido = Console.ReadLine();

            nombreCompleto = nombre + " " + apellido;
            Console.WriteLine(nombreCompleto);

            Console.Read();

        }
    }
}
