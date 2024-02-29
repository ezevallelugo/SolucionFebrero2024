using System;

class Program
{
    static void Main(string[] args)
    {
        string entrada;

        // Solicitar al usuario que ingrese un dato
        Console.Write("Por favor, ingresa un dato: ");
        entrada = Console.ReadLine();

        // Validar si la entrada es null, una cadena vacía o solo espacios en blanco
        if (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("Error: La entrada no puede estar vacía o contener solo espacios en blanco.");
        }
        else
        {
            Console.WriteLine("Dato ingresado: " + entrada);
        }
    }
}
