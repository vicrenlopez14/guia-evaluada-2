namespace Ejercicio13_VictorLopez
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
                Un estudiante desea calcular su promedio en base a 3 calificaciones de una asignatura
                    (debe ser capaz de introducir notas con decimales). El usuario debe ser capaz que proveer 
                    al sistema de 3 notas. Debe validar que la nota ingresada esté entre 0 y 10. Al final, indique al 
                usuario en qué categoría se encuentra:
                0 a 2 – Rendimiento Nulo.
                2 a 4 – Rendimiento Bajo.
                4 a 6 – Rendimiento Regular
                7 a 8 – Rendimiento Bueno
                8 a 10 – Rendimiento Muy Bueno
            */

            // Vars
            Double gradesAggregate = 0;
            Double average = 0;

            Console.WriteLine("Calculador promedio y clasificación");
            Console.WriteLine("Provea las notas del estudiante");

            // Get the grades
            for (int i = 0; i < 3;)
            {
                try
                {
                    // Data input
                    Console.Write($"Ingrese la nota {i + 1}: ");
                    Double input = Double.Parse(Console.ReadLine());

                    // Has to be between 0 and 10
                    if (input is >= 0 and <= 10)
                    {
                        gradesAggregate += input;
                        i++;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Ingrese un número entre el 1 y el 10");
                }
            }

            // Calc
            average = Math.Round(gradesAggregate / 3, 2);

            // Out
            Console.WriteLine($"El promedio es: {average}");
        }
    }
}