using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Enunciado 3:
              Elaborar un programa que permita ingresar el promedio final de 20 alumnos 
             * de la unidad didáctica de Fundamentos de Programación. 
             * Determinar e imprimir la cantidad de aprobados y cantidad de desaprobados */
            
            //Nota mínima = 11
            //Iteraciones = 20 (veces que se ejecutará)
            //Contar aprobados y desaprobados
            int nAprobados = 0, nDesaprobados = 0;

            for (int i = 1; i <= 20; i++)
            {   //Ingresar 20 notas
                Console.WriteLine("Ingrese calificación "+i);
                int nota = int.Parse(Console.ReadLine());
                
                //Contar la notas de aprobados y desaprobados 
                if (nota >= 11) { nAprobados++;}
                else { nDesaprobados++;}
                
            }

            //Mostrar las cantidades
            Console.WriteLine("Resultados: ");
            Console.WriteLine("Número de Aprobados es: "+nAprobados);
            Console.WriteLine("Número de Desaprobados es: "+nDesaprobados);
            Console.ReadKey();
        }
    }
}
