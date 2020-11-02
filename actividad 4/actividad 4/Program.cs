using System;

namespace actividad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*este es el primer codigo en el cual se pide al usuario que ingrese su nombre de usuario y contraseña,
             * mas sin embargo solamente tiene 3 intentos para asi colocar bien su contraseña si no su cuenta se cancelara*/
            /*
            int i; string usuario, contraseña;
                for (i = 0; i < 3; i++)
                {
                        Console.WriteLine("ingresa tu nombre de usuario: ");
                        usuario = Console.ReadLine();
                        Console.WriteLine("ingresa tu contraseña: ");
                        contraseña = Console.ReadLine();
                    if (usuario == "juancho" && contraseña == "123tamarindo")
                    {
                        Console.WriteLine("bienbenido :)");
                        i = 3;
                    }
                    else
                    {
                        Console.WriteLine("buen intento ");
                        Console.WriteLine("al tercer intento se cancelara tu cuenta");
                        if (i < 2)
                        {
                        Console.WriteLine("tienes un intento mas :) ");
                        }
                        else
                        {
                        Console.WriteLine("lo siento tu cuenta fue cancelada :( ");
                        }

                    }

                   
                }*/
            /*este es el segundo codigo el cual le pide al usuario que ingrese el numero de numeros enteros que va a ingresar
             * y asi comparar y decirle cuantos de sus numeros son mayores o iguales a 1000*/
            int i,n,ncap,nmam;
            Console.WriteLine("ingresa el numero de numeros enteros ingresaras");
            n = int.Parse(Console.ReadLine());
            for (i = 0,nmam=0; i < n;i++)
            {
                Console.WriteLine("ingresa un numero entero: ");
                ncap = int.Parse(Console.ReadLine());
                if (ncap >= 1000)
                {
                    nmam++;
                }
            }
            Console.WriteLine("la cantidad de numeros enteros mayores que 1000 es: {0}", nmam);
        }
    }
}