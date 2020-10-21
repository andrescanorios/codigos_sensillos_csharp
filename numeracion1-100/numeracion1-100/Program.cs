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
            /*
             * este es el segundo codigo la suma y el promedio
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
            */
            int i, msiete = 0, mensiete = 0, nota;
            for(i=1; i <= 10; i++)
            {
                Console.Write("ingresa calificacion: ");
                nota = int.Parse(Console.ReadLine());
                if (nota >= 7)
                {
                    msiete = msiete + 1;
                }
                else
                {
                    mensiete = mensiete + 1;
                }
            }
            Console.WriteLine("Cantidad de alumnos con promedio mayor o igual a 7: {0}",msiete);
            Console.WriteLine("Cantidad de alumnos con promedio menor a 7: {0}", mensiete);
        }
    }
}
