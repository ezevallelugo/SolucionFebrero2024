/*
Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
*/

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main()
        {
            double numero;
            double numeroCuadrado;
            double numeroCubo;

            Console.WriteLine("Empieza el programa!");        
            Console.WriteLine($"Escriba un numero entero:");
                
            while (!double.TryParse(Console.ReadLine(), out numero) || numero <= 0)
            {                          
                Console.WriteLine("ERROR. ¡Reingresar número!");                             
            }

            numeroCuadrado = Math.Pow(numero, 2);
            numeroCubo = Math.Pow(numero, 3);


            Console.WriteLine($"Numero al cuadrado: {numeroCuadrado:F2}");
            Console.WriteLine($"Numero al cubo: {numeroCubo:F2}");

           /*
            * Se debe usar el decimal para valores fraccionarios precisos como precios y demas.
            * Se debe usar el float o double para valores fraccionarios no precisos, sino rapidos. Aunque double abarca 
            * un rango mayor de datos y mas precision comparandolo con float, para el uso de recursos limitados se implementa el float.
            */


        }
    }
}