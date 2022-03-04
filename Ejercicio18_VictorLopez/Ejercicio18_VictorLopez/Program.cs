namespace Ejercicio18_VictorLopez
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Calcule la distancia entre dos puntos dados(X1, Y1), (X2, Y2), deberá solicitar dichos datos
            // al usuario.

            Double x1, x2, y1, y2, result;

            // Data input
            Console.Write("Digite el valor de x1: ");
            
            x1 = Double.Parse(Console.ReadLine());
            Console.Write("Digite el valor de y1: ");
            y1 = Double.Parse(Console.ReadLine());

            Console.Write("Digite el valor de x2: ");
            x2 = Double.Parse(Console.ReadLine());
            Console.Write("Digite el valor de y2: ");
            y2 = Double.Parse(Console.ReadLine());

            // Calculate result
            result = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)), 2);
            
            Console.Write($"La distancia es: {result}");
        }
    }
}