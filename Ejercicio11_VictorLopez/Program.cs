using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11_VictorLopez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba los valores del cateto: ");
            double cateto = double.Parse(Console.ReadLine());
            Console.WriteLine("Escriba los valores del cateto: ");
            double cateto2 = double.Parse(Console.ReadLine());
            double resultado = (cateto * cateto2) + (cateto2 * cateto2);
            double hipotenusa = Math.Sqrt(resultado);
            Console.WriteLine("El resultado es: " + hipotenusa);
            Console.ReadKey();
        }
    }
}
