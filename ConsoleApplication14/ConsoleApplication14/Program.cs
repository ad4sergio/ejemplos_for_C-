using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        { /*Enunciado 4:
            Elaborar un Programa que permita ingresar 20 promedios finales de una unidad didáctica,
            asi mismo debera de permitir ingresar el seco del alumno. 
           * El programa debera de calcular e imprimir lo siguiente:
            A Cantidad de masculinos aprobados 
            B Cantidad de Femeninos Aprobados 
            C Cantidad de masculinos Desaprobados 
            D Cantidad de Femeninos Desaprobados. */

        //Iteraciones = 20 
        //Contar aprobados y desaprobados, luego contar masculino o femenino
        //Nota mínima= 11
        //sexo m ó f

        //Declarar e inicializar contadores
            int nMasculinoAprobado=0,nFemeninoAprobado=0,nMasculinoDesaprobado=0,nFemeninoDesaprobado=0;


            for (int i = 1; i <= 20;i++)
            {
                Console.WriteLine("___________________________________");
                Console.WriteLine("Ingrese nota de alumno "+i);
                int nota = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese sexo(m/f) de alumno "+i);
                string sexo = Console.ReadLine();

                //Evaluar datos ingresados
                //Si es aprobado
                if (nota >= 11)
                {
                    if (sexo.Equals("m")) { nMasculinoAprobado++;}
                    else { nFemeninoAprobado++;}
                }
                //En caso sea desaprobado
                else
                {
                    if (sexo.Equals("m")) { nMasculinoDesaprobado++;}
                    else { nFemeninoDesaprobado++;}
                }
            }
            Console.WriteLine("___________________________________");
            Console.WriteLine("RESULTADOS: ");
            Console.WriteLine(" A) Cantidad de masculinos aprobados: "+nMasculinoAprobado);
            Console.WriteLine(" B) Cantidad de Femeninos aprobados: "+nFemeninoAprobado);
            Console.WriteLine(" C) Cantidad de masculinos desaprobados: " + nMasculinoDesaprobado);
            Console.WriteLine(" D) Cantidad de Femeninos desaprobados: " + nFemeninoDesaprobado);
            Console.ReadLine();


        }
    }
}
