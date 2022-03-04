namespace Ejercicio10_VictorLopez
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Calcular el número de segundos que hay en un número determinado de días
            Console.WriteLine("Calculador de segundos que hay en un determinado número de días");

            Double days = 0;
            Double seconds = 0;

            bool invalid = true;
            while (invalid)
            {
                try
                {
                    // Data input
                    Console.Write("Digite el número de días: ");
                    days = Double.Parse(Console.ReadLine());
                    if ((days is >= 0) == false)
                    {
                        throw new FormatException();
                    }

                    // Calc
                    seconds = 86400 * days;
                    invalid = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Introduzca un número válido de días");
                }
            }

            // Out
            Console.WriteLine($"{days} días equivalen a {seconds} segundos.");
        }
    }
}