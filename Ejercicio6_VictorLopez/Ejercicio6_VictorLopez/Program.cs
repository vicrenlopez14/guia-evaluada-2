using System;

namespace Ejercicio6_VictorLopez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el radio del circulo: ");
            double radio = double.Parse(Console.ReadLine());
            double Perimetro = (2 * Math.PI) * radio;
            Console.WriteLine("El perimetro del circulo es: " + Math.Round(Perimetro, 2));
        }
    }
}
