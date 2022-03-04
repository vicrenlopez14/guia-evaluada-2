using System;

namespace Ejercicio9_VictorLopez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el presupuesto anual del hospital:");
            double Presupuesto = double.Parse(Console.ReadLine());

            double Otorrinolaringologia = (double) 35 / 100;
            double Cardiología = (double) 40 / 100;
            double Pediatría = (double) 25 / 100;

            double Montototal = (Otorrinolaringologia * Presupuesto);
            Console.WriteLine("El monto que recibira el área de Otorrinolaringologia sera: " +"$" + Montototal);
            double Montototal2 = (Cardiología * Presupuesto);
            Console.WriteLine("El monto que recibira el área de Cardiología sera: " +"$" + Montototal2);
            double Montototal3 = (Pediatría * Presupuesto);
            Console.WriteLine("El monto que recibira el área de Pediatría sera: " +"$" + Montototal3);
        }
    }
}
 