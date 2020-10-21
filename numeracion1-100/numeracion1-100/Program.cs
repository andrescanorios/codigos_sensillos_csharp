using System;

namespace numeracion1_100
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * primer codigo con un siclo for en csharp
            for (int i=1; i <= 100; i++)
            {
                Console.Write(i);
                Console.Write("-");
            }
            */
            int i, suma = 0, valor, promedio;
            string linea;
            for (i = 0; i < 10; i++)
            {
                Console.Write("Ingresa el valor: ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                suma = suma + valor;
            }
            Console.WriteLine("La suma es: {0}", suma);
            promedio = suma / 10;
            Console.Write("La promedio es: {0}", promedio);
        }
    }
}
