/*
Escribir un programa que determine si un año es bisiesto.

Un año es bisiesto si es múltiplo de 4. 
Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. 
Por ejemplo: el año 2000 es bisiesto pero 1900 no.

Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
 */


namespace Ejercicio_I06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anioUno;
            int anioDos;
            bool bandera = false;
            Console.WriteLine("Empieza el programa!");
            Console.WriteLine("Ingrese un año de inicio");
            while (!int.TryParse(Console.ReadLine(), out anioUno) || anioUno < 1 || anioUno > 2024)
            {
                Console.WriteLine("Error. Ingrese un anio entre 1 y 2024");
            }            
            Console.WriteLine("Ingrese un año de fin");
            while (!int.TryParse(Console.ReadLine(), out anioDos) || anioDos < anioUno || anioDos > 2024)
            {
                Console.WriteLine("Error. Ingrese un anio entre el anterior ingresado y 2024");
            }
            for (int i = anioUno; i < anioDos + 1; i++) 
            {
                if (i % 4 == 0)
                {
                    bandera = true;
                    Console.WriteLine($"Anio bisiesto: {i}");
                }
            }
            if (bandera == false)
            {
                Console.WriteLine("No hay anio bisiesto");
            }
        }
    }
}