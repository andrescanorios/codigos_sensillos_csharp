using System;

namespace ejercicios_basicos_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1,v2,suma, resta, multiplicacion, division;
            string num1, num2;
            Console.WriteLine("ingresa el primer numero: ",v1);
            num1 = Console.ReadLine();
            v1 = Convert.ToInt32(num1);
            Console.WriteLine("ingresa el segundo numero: ");
            num2 = Console.ReadLine();
            v2 = Convert.ToInt32(num2);
            suma = v1 + v2;
            multiplicacion = v1 * v2;
            resta = v1 - v2;
            division = v1 / v2;
            Console.WriteLine("la suma de los 2 numeros es: ", suma);
            Console.WriteLine("la resta de los 2 numeros es: ", resta);
            Console.WriteLine("la multiplicacion de los 2 numeros es: ", multiplicacion);
            Console.WriteLine("la division de los 2 numeros es: ", division);
        }
    }
}
