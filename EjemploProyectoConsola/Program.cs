using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EjemploProyectoClases;

namespace EjemploProyectoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Promedio p = new Promedio();

            Console.WriteLine("Ingrese un valor (corte con <0)");
            valor = Convert.ToInt32(Console.ReadLine());
            while (valor >= 0)
            {
                p.RegistrarNumero(valor);

                Console.WriteLine("Ingrese un valor (corte con <0)");
                valor = Convert.ToInt32(Console.ReadLine());
            }

            double promedio = p.CalcularPromedio();
            Console.WriteLine("El promedio es {0:f2}", promedio);

            Console.ReadKey();
        }
    }
}
