/*
Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

Validar que el dato ingresado por el usuario sea un número.

Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

Si ingresa "salir", cerrar la consola.

Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
 */

namespace Ejercicio_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {                
                Console.Write("Ingresa un número o escribe 'salir' para salir: ");
                string entrada = Console.ReadLine();                
                if (entrada.ToLower() == "salir")
                {
                    Console.WriteLine("¡Hasta luego!");
                    break;
                }                
                if (!int.TryParse(entrada, out int numero))
                {
                    Console.WriteLine("Error: La entrada no es un número válido.");
                    continue;
                }                              
                Console.WriteLine($"Números primos hasta {numero}:");
                for (int i = 2; i <= numero; i++)
                {
                    if (EsPrimo(i))
                    {
                        Console.Write(i + " ");
                    }
                }                
                Console.Write("¿Desea volver a operar? (s/n): ");
                string respuesta = Console.ReadLine();
                continuar = (respuesta.ToLower() == "s");
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