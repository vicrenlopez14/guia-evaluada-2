using System;

namespace Ejercicio14_victorLopez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el usuario: ");
            string usuario = Console.ReadLine();
            Console.WriteLine("Ingrese la contraseña: ");
            string contraseña = Console.ReadLine();
            if (usuario == "administrador" && contraseña == "ricaldone2022")

            {

                Console.WriteLine("Bienvenido");

            }

            else
            {

                Console.WriteLine("Datos inválidos, vuelva a intentarlo");
            }




        }

    }
}
