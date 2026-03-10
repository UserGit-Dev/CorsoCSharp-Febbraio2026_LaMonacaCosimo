class Program
{
    static void Main()
    {
        CentroMeteo centroMeteo = new();
        centroMeteo.Registra(new DisplayConsole());
        centroMeteo.Registra(new DisplayMobile());

        string statoMeteo;

        do {
            Console.Clear();
            Console.Write("Inserisci stato meteo: ");
            statoMeteo = Console.ReadLine()!;
        } while (string.IsNullOrWhiteSpace(statoMeteo));

        Console.Clear();
        centroMeteo.AggiornaStato(statoMeteo);
        Console.WriteLine("\nPreme un tasto per continuare...");
        Console.ReadKey(true);
    }
}