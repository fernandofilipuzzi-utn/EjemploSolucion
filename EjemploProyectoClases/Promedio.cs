using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploProyectoClases
{
    public class Promedio
    {
        int acum;
        int n;
        public void RegistrarNumero(int valor)
        {
            acum += valor;
            n++;
        }
        public double CalcularPromedio()
        {
            double promedio = 0;
            if (n > 0) promedio = 1.0*acum / n;
            return promedio;
        }
    }
}
