using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {  /*Enunciado 2:
            *Realizar un programa que me permita el ingreso de un número desde el teclado, 
            *el programa debera de calcular e imprimir la tabla de multiplicar del número ingresado
             */
            //iteraciones = 12 (tabla de multiplicar)

            //INGRESO DE DATOS
            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Se mostrará la Tabla del número " + numero);
            //EJECUCIÓN DEL CICLO
            for (int i = 1; i <= 12; i++)
            { 
             //Calcular el producto de la multiplicación
               int producto=numero*i; 
            //Mostrar producto de la multiplicación
               Console.WriteLine(numero + " x " + i + " = " + producto);
            }

            Console.WriteLine("_____________________________________________");
            Console.ReadKey();
            
        }
    }
}
