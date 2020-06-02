using System;
using System.Runtime;

namespace tp6_pto4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Trabajando con cadena de caracteres en tallerdelenguajes1";

            int StartIndex = 20;
            int length = 9;

            Console.WriteLine("------------ Extraer algunos caracteres -----------");
        
            string PalabExtraida = cadena.Substring(StartIndex, length);

            Console.WriteLine("Los caracteres extraidos son: " + PalabExtraida);

            Console.WriteLine("------------ Longitud de la cadena -----------");

            Console.WriteLine("La longitud de la cadena es: " + cadena.Length);

            Console.WriteLine("------------ Concatenar cadenas -----------");

            string cadena2 = ", desde casa";

            string CadenasConcatenadas = cadena + cadena2;

            Console.WriteLine(CadenasConcatenadas);

            Console.WriteLine("------------ Extraer una subcadena -----------");

            string Colores = "Color1=rojo Color2=verde Color3=azul";
            
            int startIndex = 10;
            int length2 = 1;
            
            string subcadena = Colores.Substring(startIndex, length2); ;

            Console.WriteLine("Subcadena Extraida: " + subcadena);

            Console.WriteLine("------------ Calculadora en formato de Texto -----------");


            int resultado;
            Console.WriteLine("Operaciones \n 1.Sumar \n 2.Restar \n 3.Multiplicar \n 4.Dividir \n Sleccione una opcion");
            int operacion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese primer operando");
            int operando1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese segundo operando");
            int operando2 = Convert.ToInt32(Console.ReadLine());
            string sresult;

            switch (operacion)
            {
                case 1:
                    resultado = operando1 + operando2;
                    sresult = resultado.ToString();
                    Console.WriteLine("La suma de " + operando1 + " y de " + operando2 + " es igual a: " + sresult);
                    break;
                case 2:
                    resultado = operando1 - operando2;
                    sresult = resultado.ToString();
                    Console.WriteLine("La resta de " + operando1 + " y de " + operando2 + " es igual a: " + sresult);
                    break;
                case 3:
                    resultado = operando1 * operando2;
                    sresult = resultado.ToString();
                    Console.WriteLine("El producto de " + operando1 + " y de " + operando2 + " es igual a: " + sresult);
                    break;
                case 4:
                    resultado = operando1 / operando2;
                    sresult = resultado.ToString();
                    Console.WriteLine("La division de " + operando1 + " y de " + operando2 + " es igual a: " + sresult);
                    break;
            }

            Console.WriteLine("------------- Recorrido ForEach ------------------");

            foreach (char s in Colores)
            {
                Console.WriteLine("La letra es " + s);
            }


            Console.WriteLine("--------------------- Ocurrencia de una determinada palabra --------------------");

            Console.WriteLine("Escriba una palabra: ");
            string palabra1 = Console.ReadLine();
            Console.WriteLine("Escriba otra palabra: ");
            string palabra2 = Console.ReadLine();
            int tam = palabra2.Length;
            int aux = 0;
            while (palabra1.Contains(palabra2))
            {
                palabra1 = palabra1.Substring(palabra1.IndexOf(palabra2) + tam);
                palabra1 = palabra1.Trim();
                aux++;
            }
            Console.WriteLine("La cantidad de veces que aparece la palabra '" + palabra2 + "' es: " + aux);

            Console.WriteLine("--------------------- Conversion a Minuscula y Mayuscula --------------------");

            cadena = "Taller De Lenguajes 1 TP N6";

            cadena = cadena.ToUpper();
            Console.WriteLine(cadena);

            cadena = cadena.ToLower();
            Console.WriteLine(cadena);


            Console.WriteLine("--------------------- Comparar cadenas --------------------");

            Console.WriteLine("Escriba un texto a comparar con: " + cadena);

            string cad = Console.ReadLine();

            if(String.Compare(cadena.ToLower(), cad.ToLower()) == 0)
            {
                Console.WriteLine("Son iguales");
            }else if((String.Compare(cadena.ToLower(), cad.ToLower()) == 0) == false)
            {
                Console.WriteLine("No son iguales");
            }

            Console.WriteLine("--------------------- Eliminar Guiones con Split --------------------");

            cadena = "Taller-de-lenguajes-tp6-pto4";

            string[] ncadena = cadena.Split("-");

            foreach (string c in ncadena)
            {
                Console.WriteLine("Cadena separada: " + c);
            }

            Console.WriteLine("--------------------- Operar desde una cadena --------------------");

            cadena = "582 + 2";

            ncadena = cadena.Split("+");
            ncadena[0] = ncadena[0].Trim();
            ncadena[1] = ncadena[1].Trim();
            Convert.ToDouble(ncadena[0]);
           
            double suma = Convert.ToDouble(ncadena[0]) + Convert.ToDouble(ncadena[1]);

            Console.WriteLine("La suma de " + Convert.ToDouble(ncadena[0]) + " y de " + Convert.ToDouble(ncadena[1]) + " es igual a: " + suma);
        }
    }
}

