namespace Ejercicio7_VictorLopez
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            Dado como dato el sueldo bruto de un trabajador, calcular el descuento total y el sueldo
            neto, tomando en cuenta las siguientes deducciones:
            a.Renta 9 %
            b.AFP 6 %
            c.ISSS 3.5 %
            */

            Double totalSalary = 0;
            Double netSalary = 0;

            Console.WriteLine("Calculador de sueldo bruto");

            // Data input
            bool invalid = true;
            while (invalid)
            {
                try
                {
                    Console.Write("Digite su sueldo total en dólares americanos: ");
                    totalSalary = Double.Parse(Console.ReadLine());
                    invalid = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Digite un número válido");
                }
            }

            // Calc
            netSalary = Math.Round(totalSalary - ((totalSalary * 0.09) + (totalSalary * 0.06) + (totalSalary * 0.035)),
                2);

            // Out
            Console.WriteLine($"El salario neto es: ${netSalary}");
        }
    }
}