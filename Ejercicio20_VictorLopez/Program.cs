using System;

namespace Ejercicio20_VictorLopez
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, perimetro;
            Console.WriteLine("Ingrese la base del rectángulo: ");
            double Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectángulo: ");
            double altura = double.Parse(Console.ReadLine());

            perimetro = 2 * (Base * altura);
            area = Base * altura;

            Console.WriteLine("El perímetro es {0} y el área {1}", perimetro, area);

          
            if (Base==altura)
            {
             
           
                Console.WriteLine("Es un cuadrado");



            }
        }
        
    }
}
