using System;

namespace Actividad
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Calculadora");
            Console.WriteLine("Ingrese el primer número:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la operación que desea realizar (+, -, /, *):");
            char operacion = char.Parse(Console.ReadLine());
            double resultado = 0;
            switch (operacion)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                default:
                    Console.WriteLine("Operación no válida");
                    break;
            }
            Console.WriteLine("El resultado de la operación es: " + resultado);
            Console.WriteLine("----- EL PROGRAMA FINALIZARA... -----");
        }
    }
}