using System;
using System.Reflection;

namespace tp6_pto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un Numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El num es: " + numero);
            int digito;

            while (numero > 0)
            {
                digito = numero % 10;
                numero /= 10;
                Console.WriteLine(digito);
            }
        }
    }
}
