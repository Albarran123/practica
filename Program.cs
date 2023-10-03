using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora Básica");
        Console.WriteLine("Seleccione una operación:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");

        int opcion = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el primer número: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());

        double resultado = 0;

        switch (opcion)
        {
            case 1:
                resultado = numero1 + numero2;
                break;
            case 2:
                resultado = numero1 - numero2;
                break;
            case 3:
                resultado = numero1 * numero2;
                break;
            case 4:
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir por cero.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Opción no válida, por favor ingresar un dato valido.");
                return;
        }

        Console.WriteLine("El resultado es: " + resultado);
    }
}  