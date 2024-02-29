/*
Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas),
hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.

Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.
 */

namespace Ejercicio_I07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreEmpleado;
            int valorPorHora;
            int antiguedad;
            int cantidadHoras;
            int cantidadEmpleados;

            Console.WriteLine("Empieza el programa!");
            Console.WriteLine("Cuanto empleados desea ingresar?:");
            while (!int.TryParse(Console.ReadLine(), out cantidadEmpleados) || cantidadEmpleados < 1) 
            {
                Console.WriteLine("Error. Ingrese una cantidad positiva valida");
            }
            for (int i = 0; i < cantidadEmpleados; i++) 
            {
                do
                {
                    Console.WriteLine("Escriba el nombre del empleado:");
                    nombreEmpleado = Console.ReadLine();
                }
                while (!EsNombreValido(nombreEmpleado));
                
                Console.WriteLine("Escriba el valor por hora:");
                while (!int.TryParse(Console.ReadLine(), out valorPorHora) || valorPorHora < 1)
                {
                    Console.WriteLine("Error. Ingrese un monto valido positivo");
                }
                Console.WriteLine("Escriba los anios de antiguedad:");
                while (!int.TryParse(Console.ReadLine(), out antiguedad) || antiguedad < 1)
                {
                    Console.WriteLine("Error. Ingrese una cantidad de anios valida positiva");
                }
                Console.WriteLine("Escriba una cantidad de horas trabajadas en el mes:");
                while (!int.TryParse(Console.ReadLine(), out cantidadHoras) || cantidadHoras < 1)
                {
                    Console.WriteLine("Error. Ingrese una cantidad de horas valida y positiva");
                }
                double resultadoBruto = (cantidadHoras * valorPorHora) + (antiguedad * 150);
                double resultadoNeto = resultadoBruto * (1 - 0.13);
                Console.WriteLine(@$"
                Nombre: {nombreEmpleado} 
                Antiguedad: {antiguedad} 
                Cantidad de horas: {cantidadHoras}
                Valor por hora: {valorPorHora} 
                Total a pagar en bruto ((cantidadHoras * valorPorHora) + (antiguedad * $150)): {resultadoBruto} 
                Total a pagar en neto (descuento de 13%): {resultadoNeto}");
            }
        }
        static bool EsNombreValido(string nombre)
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                retorno = false;
            }
            foreach (char caracter in nombre)
            {
                if (char.IsDigit(caracter) || char.IsSymbol(caracter))
                {                    
                    retorno = false;
                }
            }
            if (retorno == false) 
            {
                Console.WriteLine("Error. Ingrese un nombre valido");
            }
            return retorno;
        }
    }
}