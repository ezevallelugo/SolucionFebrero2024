/*
Escribir un programa que imprima por consola un triángulo como el siguiente:

*
***
*****
*******
*********

El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. 
Para el ejemplo anterior, la altura ingresada fue de 5.
 */

namespace Ejercicio_I08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;
            string cadena = "*";
            Console.WriteLine("Empieza el programa!");
            Console.WriteLine("Cual es la altura que tendra el triangulo?:");
            while (!int.TryParse(Console.ReadLine(), out altura) || altura < 2)
            {
                Console.WriteLine("Error. Ingrese un entero positivo como minimo 2");
            }
            for (int i = 0; i < altura; i++) 
            {
                Console.WriteLine(cadena);
                cadena = cadena + "*";
            }
        }
    }
}