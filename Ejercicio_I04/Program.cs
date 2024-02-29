/*
Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.

El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

Escribir una aplicación que encuentre los 4 primeros números perfectos.
*/

namespace Ejercicio_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Console.WriteLine("Inicio del programa");
            for (int i = 0; i < 10; i++) 
            {
                if (EsPrimo(i)) 
                {
                    double resultadoPotencia = Math.Pow(2, i -1);
                    double resultadoResta = Math.Pow(2, i) - 1;
                    double resultado = resultadoPotencia * resultadoResta;
                    Console.WriteLine(resultado);
                    contador++;
                }
                if (contador == 4)
                {
                    break;
                }
            }
        }

        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;
            if (numero <= 3)
                return true;
            if (numero % 2 == 0 || numero % 3 == 0)
                return false;
            int i = 5;
            while (i * i <= numero)
            {
                if (numero % i == 0 || numero % (i + 2) == 0)
                    return false;
                i += 6;
            }
            return true;
        }
    }
}