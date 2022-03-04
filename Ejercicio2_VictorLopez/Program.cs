using System;

namespace Ejercicio2_VictorLopez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculador de ingreso total y promedio de un trimestre");
            Console.Write("Inicie colocando el sueldo del primer mes: $");
            double m1 = double.Parse(Console.ReadLine());
            Console.Write("Inicie colocando el sueldo del segundo mes: $");
            double m2 = double.Parse(Console.ReadLine());
            Console.Write("Inicie colocando el sueldo del tercer mes: $");
            double m3 = double.Parse(Console.ReadLine());


            double ingresoT;
            ingresoT = (m1 + m2 + m3);
            Console.WriteLine("Su ingreso total en el año es de: $" + ingresoT);

            double PromedioM;
            PromedioM = ((m1 + m2 + m3) / 3);
            Console.WriteLine("El promedio del primer trimestre es: $" + Math.Round(PromedioM,2));

            Console.ReadKey();
        }
    }
}
