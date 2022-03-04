using System;

namespace Ejercicio4_VictorLopez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("El cuadrado del número es de: " + Math.Pow(n, 2));
            Console.WriteLine("El cubo del número es de: " + Math.Pow(n, 3));
            




        }
    }
}
