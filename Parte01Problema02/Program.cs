using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte01Problema02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("INSTRUCCIONES");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("01. Siempre presione ENTER para avanzar");
            Console.WriteLine("02. Para salir del programa en cualquier momento escriba SALIR (respete las mayúsculas)");
            Console.WriteLine("03. Ingrese números, presione ENTER para agregar al arreglo");            
            Console.WriteLine("04. Cuando esté listo, escriba LISTO (respete las mayúsculas), para que se procese el arreglo y muestre el resultado");
            Console.WriteLine("-------------------------------------");

            string word = Console.ReadLine();
            const string ReadyWord = "LISTO";
            const string ExitWord = "SALIR";
            const string MessageOnlyPositiveNumber = "Debe ingresar solamente números positivos";
            CompleteRange _CompleteRange = new CompleteRange();
            List<int> FirstArray = new List<int>();
            List<int> ArrayResult = new List<int>();
            int Number = 0;

            while (word != ReadyWord)
            {

                if (ExitWord == word)
                {
                    break;
                }

                Number = 0;

                bool ResultOfCast = int.TryParse(word, out Number);

                if (ResultOfCast)
                {
                    if (Number > 0)
                    {
                        FirstArray.Add(Number);
                    }
                    else
                    {
                        Console.WriteLine(MessageOnlyPositiveNumber);
                    }

                }
                else
                {
                    Console.WriteLine(MessageOnlyPositiveNumber);
                }

                Console.WriteLine("Ingrese el siguiente número");
                word = Console.ReadLine();
            } 

                if (ExitWord != word)
            {
                if (FirstArray.Count > 0)
                {
                    Console.WriteLine("-------------------------------------");

                    ArrayResult = _CompleteRange.build(FirstArray);

                    Console.WriteLine("EL RESULTADO ES:");

                    foreach (int currentNumber in ArrayResult)
                    {
                        Console.WriteLine(currentNumber.ToString());
                    }
                }
                
            }

            GoOut();

        }

        static void GoOut()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("GRACIAS POR UTILIZAR EL PROGRAMA, para salir presione alguna tecla");
            Console.ReadKey();
        }
    }
}
