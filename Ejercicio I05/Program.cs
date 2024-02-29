﻿/*
Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.

El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15.
El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.

Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
 */

namespace Ejercicio_I05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroEntero;
            
            
            
            Console.WriteLine("Hola! Ingrese un numero entero positivo para calcular el centro numerico:");
            while (!int.TryParse(Console.ReadLine(), out numeroEntero) || numeroEntero <= 0)
            {
                Console.WriteLine("Error. Ingrese un numero entero positivo valido");
            }
            
            for (int centroNumerico = 2; centroNumerico < numeroEntero; centroNumerico++)
            {
                int sumaUno = 0;
                for (int i = 0; i < centroNumerico; i++)
                {
                    sumaUno += i;
                }
                int sumaDos = 0;
                for (int j = centroNumerico + 1; j <= sumaUno; j++)
                {
                    if (sumaUno == sumaDos || sumaDos > sumaUno)
                    {
                        break;
                    }
                    sumaDos += j;
                }

                if (sumaUno == sumaDos) 
                {                    
                    Console.WriteLine($"El centro numerico es: {centroNumerico}");                    
                }                
            }
            Console.WriteLine("Fin del programa");
        }
    }
}