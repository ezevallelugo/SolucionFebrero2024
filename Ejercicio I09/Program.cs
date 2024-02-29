/*
Escribir un programa que imprima por consola un triángulo como el siguiente:

    1234*
    123***
    12*****
    1*******
    *********

El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5.
 */

namespace Ejercicio_I09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;
            Console.WriteLine("Empieza el programa!");
            Console.WriteLine("Cual es la altura que tendra el triangulo?:");
            while (!int.TryParse(Console.ReadLine(), out altura) || altura < 2)
            {
                Console.WriteLine("Error. Ingrese un entero positivo como minimo 2");
            }
            for (int i = 1; i <= altura; i++)
            {
               for (int j = 0; j < altura - i; j++)
               {
                    Console.Write(" ");
               }
               for (int k = 0; k < 2 * i - 1; k++)
               {
                    Console.Write("*");
               }
               Console.WriteLine();
                // Este es un cambio de ultimo minuto 
            }
        }
    }
}