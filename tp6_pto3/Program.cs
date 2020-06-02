using System;

namespace tp6_pto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuesta = 1;
            do
            {
                Console.WriteLine("Operaciones \n " +
                    "5.Valor absoluto \n " +
                    "6.Cuadrado \n " +
                    "7.Raiz cuadrada \n " +
                    "8.Seno \n " +
                    "9.Coseno \n " +
                    "10.Parte entera de un tipo float \n " +
                    "Sleccione una opcion");
                
                int operacion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese un numero");
                double operando1 = Convert.ToInt32(Console.ReadLine());
                double resultado = 0;
                switch (operacion)
                {
                    case 5:
                        resultado = Math.Abs(operando1);
                        break;

                    case 6:
                        resultado = Math.Pow(operando1, 2);
                        break;

                    case 7:
                        resultado = Math.Sqrt(operando1);
                        break;

                    case 8:
                        resultado = Math.Sin(operando1);
                        break;

                    case 9:
                        resultado = Math.Cos(operando1);
                        break;

                    case 10:
                        resultado = (int)operando1;
                        break;
                }
               
                Console.WriteLine("\nEl resultado es: " + resultado);

                Console.WriteLine("Ingrese primer numero: ");
                operando1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese segundo numero: ");
                int operando2 = Convert.ToInt32(Console.ReadLine());

                if (operando1 > operando2)
                {
                    Console.WriteLine("El maximo es: " + operando1);
                    Console.WriteLine("El minimo es: " + operando2);
                }
                else if (operando2 > operando1)
                {
                    Console.WriteLine("El maximo es: " + operando2);
                    Console.WriteLine("El minimo es: " + operando1);
                }
                else if (operando2 == operando1)
                {
                    Console.WriteLine("Los numeros son iguales: " + operando1);
                }

                    Console.WriteLine("Presione 1 para seguir calculando");
                respuesta = Convert.ToInt32(Console.ReadLine());
            } while (respuesta == 1);
            return;
        }
    }
}


