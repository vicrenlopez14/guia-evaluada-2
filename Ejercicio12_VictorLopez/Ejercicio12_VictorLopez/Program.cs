using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12_VictorLopez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine("El número menor es: " + num1);
            }

            else if (num2 < num1)
            {
                Console.WriteLine("El número menor es: " + num2);
            }

            else
            {
                Console.WriteLine("Ambos números son iguales");
            }

            Console.ReadKey();
        }
    }
}
