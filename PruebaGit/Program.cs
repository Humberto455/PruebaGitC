using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tOperaciones!");
            Operaciones op1 = new Operaciones();

            op1.Resta(10,5);
            op1.Suma(5, 5);
        }
    }
    class Operaciones
    {
        int resultado;

        public void Resta(int valor1,int valor2)
        {
            resultado = valor1 - valor2;

            Console.WriteLine("El resultado de la resta es: " + resultado);

        }
        public void Suma(int valor1, int valor2)
        {
            resultado = valor1 + valor2;
            Console.WriteLine("Resultado de la suma: " + resultado);
        }
    }
}
