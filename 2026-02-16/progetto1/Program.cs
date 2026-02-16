using System;
using System.Collections;

/* Classe principale */
class Program()
{
    public readonly string reado = "A";

    /* Metodo "Main" per l'avvio del ciclo di vita dell'applicazione */ 
    static void Main(string[] args)
    {
        /* Richiamo funzione per stampare a schermo la stringa "Hello World" */
        Console.WriteLine("Hello World");
        int contatore;
        contatore = 1;

        ArrayList a = [1, 2, 3];
        float aa = 1.4f;
        double aaa = 1.1d;

       const int esempio = 1;
       const float PIGRECO = 1.34f; 
       
        //Console.WriteLine("Il risultato è: " + esempio + " e " + PIGRECO + " e " + read); 
        string testo = "1";
        //int testoa = (int) testo;

        ConsoleKeyInfo input = Console.ReadKey();
        Console.WriteLine(input.KeyChar);
        
        int num = 5;
        Console.WriteLine(--num);
    }
}