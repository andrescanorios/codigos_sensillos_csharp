using System;

namespace multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabla;
            Console.WriteLine("Introduce el valor de la tabla: ");
            tabla = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(tabla, " X ", i, " = ", tabla * i);
            }
        }
    }
}
