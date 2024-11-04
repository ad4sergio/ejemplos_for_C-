using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enunciado 1 :
             Realizar un programa que permita el ingreso de 10 números desde el teclado,
             el cual debera de mostrar y calcular, cantidad de positivos, 
             cantidad de negativos y cantidad de ceros
            */
            //iteraciones=10
            //contador nPositivos, nNegativos y nCeros

            //1.contadores a usar
            int nPositivos = 0, nNegativos=0, nCeros=0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingresa el número "+i+" : ");
                int numero = int.Parse(Console.ReadLine());
                //Evaluar si es + - ó 0
                if (numero >0) { nPositivos++;}
                else if (numero < 0) {nNegativos++; }
                else { nCeros++;}
            }

            //SALIDA de contadores
            Console.WriteLine("Cantidad de números positivos es: " + nPositivos);
            Console.WriteLine("Cantidad de números positivos es: " + nNegativos);
            Console.WriteLine("Cantidad de números positivos es: " + nCeros);
            Console.ReadKey(); //pausa para que no cierre la consola

        }
    }
}
