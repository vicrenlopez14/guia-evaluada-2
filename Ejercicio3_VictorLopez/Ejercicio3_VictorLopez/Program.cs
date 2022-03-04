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


            if (radioMA < radioME)
            {
                Console.WriteLine("El radio mayor debe ser más grande que el radio menor");
                return;
            }

            double resultado = Math.PI * (Math.Pow(radioMA, 2) - Math.Pow(radioME, 2));

            Console.WriteLine("El area de la corona circular es: " + Math.Round(resultado, 2));

            Console.ReadKey(); 
        }
    }
}
