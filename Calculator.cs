using System;

namespace Example
{
    class Calculator
    {
        static void Main()
        {
            Console.WriteLine("Inserisci il primo numero:");
            int num1 = ValidateAndRead();

            Console.WriteLine("Inserisci il secondo numero:");
            int num2 = ValidateAndRead();

            int sum = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {sum}");
        }

        static int ValidateAndRead()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Errore: Devi inserire un numero.");
                    continue;
                }

                if (int.TryParse(input, out int number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Attenzione, inserisci solo numeri interi.");
                }
            }
        }
    }
}