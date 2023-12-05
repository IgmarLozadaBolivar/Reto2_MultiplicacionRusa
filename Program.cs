using System;

namespace Reto2
{
    class TestMultiplicacionRusa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("Bienvenido a Multiplicacion Rusa".ToUpper());
            Console.WriteLine("--------------------------------\n");

            Console.Write("Ingrese un numero multiplicador: ");
            int n1Input = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un numero multiplicando: ");
            int n2Input = Convert.ToInt32(Console.ReadLine());

            int resultado = 0;
            while (n1Input >= 1)
            {
                if (n1Input % 2 != 0)
                {
                    resultado += n2Input;
                }
                n1Input /= 2;
                n2Input *= 2;
            }

            Console.WriteLine($"El resultado es: {resultado}");
        }
    }
}