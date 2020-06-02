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
                Console.WriteLine("Operaciones \n 1.Sumar \n 2.Restar \n 3.Multiplicar \n 4.Dividir \n Sleccione una opcion");
                int operacion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese primer operando");
                int operando1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese segundo operando");
                int operando2 = Convert.ToInt32(Console.ReadLine());
                switch (operacion) 
                {
                case 1:
                    int suma = operando1 + operando2;
                    Console.WriteLine("Resultado de suma: " + suma);
                    break;
                case 2:
                    int resta = operando1 - operando2;
                    Console.WriteLine("Resultado de resta: " + resta);
                    break;
                case 3:
                    int multiplicacion = operando1 * operando2;
                    Console.WriteLine("Resultado de multiplicacion: " + multiplicacion);
                    break;
                case 4:
                    float division = 4.55555F;
                    division = operando1 / operando2;
                    Console.WriteLine("Resultado de division: " + division);
                    break;
                }
                Console.WriteLine("Presione 1 para seguir calculando");
                respuesta = Convert.ToInt32(Console.ReadLine());
            }while(respuesta == 1);
            return;
        }
    }
}

/*Ejercicio 2. Construir un programa que sea una calculadora que permita al usuario             
 * realizar las 4 operaciones básicas (Sumar, Restar, Multiplicar y Dividir) a partir de un              
 * menú para seleccionar la opción a elegir y luego que le pida dos números y que               
 * devuelva el resultado de la operación seleccionada. Además una vez que termine de             
 * realizar la operación que le pregunte si desea realizar otro cálculo. 
 */
