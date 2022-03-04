using System;

namespace Ejercicio3_VictorLopez
{
    class Program
    {
        static void Main(string[] args)
        {
             double radioMA, radioME;

            Console.WriteLine("Favor ingresar el radio mayor: ");
            radioMA = double.Parse(Console.ReadLine());

            Console.WriteLine("Favor ingresar el radio menor: ");
            radioME = double.Parse(Console.ReadLine());

            Console.Write("El area de la corona circular es: " +
                3.1416 * (radioMA - radioME),

            Console.ReadKey()); 
        }
    }
}
