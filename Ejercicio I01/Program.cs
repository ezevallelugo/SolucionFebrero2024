/*
 Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.   
 */

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main()
        {
            int maximo = 0;
            int minimo = 0;
            float promedio;
            int acumulador = 0;
            

            List<int> listaNumeros = new List<int>();
            Console.WriteLine("Empieza el programa!");
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine($"Escriba un numero ({i+1}):");
                int numero;
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Por favor ingrese un numero valido");
                }
                listaNumeros.Add(numero);                
            }

            minimo = listaNumeros[0];
            maximo = listaNumeros[0];

            foreach (int numero in listaNumeros)
            {
                if (numero > maximo)
                {
                    maximo = numero;
                }
                if (numero < minimo)
                {
                    minimo = numero;
                }
                acumulador += numero;
            }
      
            promedio = acumulador / listaNumeros.Count();
            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine($"Maximo: {maximo}");
            Console.WriteLine($"Minimo: {minimo}");


        }
    }
}