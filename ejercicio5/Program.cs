using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrolle un programa que pida una serie de números y al finalizar
            //que calcule el promedio de dichos números (0 para finalizar) (usar While).

            int cantidadNumeros = 0;
            int suma = 0;

            Console.WriteLine("Ingrese una serie de numeros ó ingrese 0 para finalizar: ");

            int numero = -1; // Inicializar el primer valor que no sea 0

            while (numero != 0)
            {
                Console.Write("Ingrese un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero != 0)
                {
                    suma += numero;
                    cantidadNumeros++;
                }
            }
            if (cantidadNumeros > 0)
            {
                double promedio = (double)suma / cantidadNumeros;
                Console.WriteLine("El promedio de los numeros ingresados es: " + promedio);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se han ingresado numeros.");
                Console.ReadKey();
            }
        }
    }
}
