using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8_VictorLopez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la nota obtenida en los siguientes perfiles:");

            Console.WriteLine();

            Console.Write("Tareas: ");
            double tareas = double.Parse(Console.ReadLine());

            Console.Write("Portafolio: ");
            double portafolio = double.Parse(Console.ReadLine());

            Console.Write("Laboratorio: ");
            double lab = double.Parse(Console.ReadLine());

            Console.Write("Examen: ");
            double exam = double.Parse(Console.ReadLine());

            Double notaFinal = (tareas * 0.15) + (portafolio * 0.25) + (lab * 0.25) + (exam * 0.35);

            Console.WriteLine();

            Console.WriteLine("La nota final es: " + notaFinal);

            Console.ReadKey();
        }
    }
}
