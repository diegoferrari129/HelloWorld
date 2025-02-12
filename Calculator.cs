using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Inserisci il primo numero:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Inserisci il secondo numero:");
        string input2 = Console.ReadLine();

        /*
        TryParse: funzione che converte stringa in intero
        out int num1 : assigna il valore della conversione alla variabile num1
        */
        if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
        {
            int sum = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {sum}");
        }
        else
        {
            Console.WriteLine("Attenzione, inserisci solo numeri interi");
        }
    }
}
