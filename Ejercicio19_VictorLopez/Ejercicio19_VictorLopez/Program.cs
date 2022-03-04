using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19_VictorLopez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digita un número: ");
            double num = double.Parse(Console.ReadLine());

            if (num < 0)
            {
                double numPositivo = num * -1;
                Console.WriteLine("El número introducido es negativo, número positivo: " + numPositivo);
            }
            else
            {
                Console.WriteLine("El número introducido es positivo.");
            }

            Console.ReadKey();
        }
    }
}
