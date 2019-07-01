using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicanNumerosConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, r;

            Console.WriteLine("Ingrese el primer número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            r = n1 * n2;

            Console.WriteLine("El resultados es: " + r);
            Console.ReadLine();
        }
    }
}
