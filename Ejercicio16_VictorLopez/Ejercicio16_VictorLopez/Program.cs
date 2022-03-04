using System;

namespace Ejercicio16_VictorLopez
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digita el primer número: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digita el segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            if(numero2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
            }

            else
            {
                double total = (double)numero1 / numero2;
                Console.WriteLine("El resultado de la división es: " + total);
            }
        }
    }
}
