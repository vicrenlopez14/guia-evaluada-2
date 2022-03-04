using System;

namespace ejercicio17_victorLopez
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividiendo, divisor;

            Console.WriteLine("ingrese el primer numero");
            dividiendo = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero");
            divisor = int.Parse(Console.ReadLine());
            Console.WriteLine("El cociente de la división es " + (dividiendo / divisor ) + " y el residuo de la división es " + (dividiendo% divisor));
            Console.ReadLine();
        }
    }
}
