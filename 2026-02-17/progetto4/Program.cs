using System;

public class Program
{
    public static void Main(string[] args)
    {
        /* // 1.
        Console.WriteLine("Inserisci un numero intero: ");
        int num = int.Parse(Console.ReadLine()!);

        if (num % 2 == 0) {
            Console.WriteLine($"Il numero è pari -> {num}");
        } else {
            Console.WriteLine($"Il numero è dispari -> {num}");
        }

        Console.WriteLine();

        // 2.
        const string password = "password";

        Console.WriteLine("Inserisci la password: ");
        string inPassword = Console.ReadLine()!;

        if (password == inPassword)
        {
            Console.WriteLine("Accesso consentito");
        } else
        {
            Console.WriteLine("Accesso negato");
        }

        Console.WriteLine(); */

        // 3.
        Console.WriteLine("Inserire il tipo di operazione logica (addizione o sottrazione)");
        string operatore = Console.ReadLine()!;

        if (operatore != "+" && operatore != "-")
        {
            Console.WriteLine("Operatore non valido!");
        } else {
            Console.WriteLine("Inserire il primo numero: ");
            double num1 = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Inserire il secondo numero: ");
            double num2 = double.Parse(Console.ReadLine()!);

            if (operatore == "+") {
                Console.WriteLine($"Addzione: {num1 + num2}");
            } else if (operatore == "-") {
                if (num1 > num2) { Console.WriteLine($"Sottrazione: {num1 - num2}"); }
                else { Console.WriteLine($"Sottrazione: {num2 - num1}"); }
            }
        }
    }
}
