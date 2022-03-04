using System;

namespace Ejercicio1_VictorLopez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Convertidor grados cenítgrados a fahrenheit.");
            Console.Write("\nIngrese el número de grados centígrados que desea convertir: ");
            double c = Double.Parse(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine("La cantidad de grados Farenhait es de: " + f);
        }
    }
}
