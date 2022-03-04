using System;

namespace Ejercicio5_VictorLopez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el monto total de su cuenta bancaria: ");
            double montototal = double.Parse(Console.ReadLine());
            double porcentajeUsado = 0;
            
            
            Console.Write("\nIngrese el porcentaje que recibirá el hijo 1: ");
            double hijo1 = double.Parse(Console.ReadLine()) / 100;
            porcentajeUsado += hijo1;
            if (porcentajeUsado >= 1)
            {
                Console.WriteLine("Cuenta bancaria asignada al 100%, si continúa estará sobre los límites");
            }


            Console.Write("\nIngrese el porcentaje que recibirá el hijo 2: ");
            double hijo2 = double.Parse(Console.ReadLine()) / 100;
            porcentajeUsado += hijo2;
            if (porcentajeUsado >= 1)
            {
                Console.WriteLine("Cuenta bancaria asignada al 100%, si continúa estará sobre los límites");
            }
            
            
            Console.Write("\nIngrese el porcentaje que recibirá el hijo 3: ");
            double hijo3 = double.Parse(Console.ReadLine()) / 100;
            porcentajeUsado += hijo3;
            if (porcentajeUsado >= 1)
            {
                Console.WriteLine("Cuenta bancaria asignada al 100%, si continúa estará sobre los límites");
            }
            
            
            Console.Write("\nIngrese el porcentaje que recibirá el hijo 4: ");
            double hijo4 = double.Parse(Console.ReadLine()) / 100;
            porcentajeUsado += hijo4;
            if (porcentajeUsado >= 1)
            {
                Console.WriteLine("Cuenta bancaria asignada al 100%, si continúa estará sobre los límites");
            }
            
            
            double Montohijo1 = (hijo1 * montototal);
            Console.Write("El monto que recibira el primer hijo sera: " + "$" + Montohijo1);
            double Montohijo2 = (hijo2 * montototal);
            Console.Write("\nEl monto que recibira el segundo hijo sera: " + "$" + Montohijo2);
            double Montohijo3 = (hijo3 * montototal);
            Console.Write("\nEl monto que recibira el tercer hijo sera: " + "$" + Montohijo3);
            double Montohijo4 = (hijo4 * montototal);
            Console.Write("\nEl monto que recibira el cuarto hijo sera: " + "$" + Montohijo4);
            
            if (porcentajeUsado >= 1)
            {
                Console.WriteLine("\nLe faltarían $" + (montototal * (porcentajeUsado - 1)) + " para completar la herencia.");
            }

        }
    }
}
