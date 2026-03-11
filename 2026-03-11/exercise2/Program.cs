class Program
{
    static void Main()
    {
        AggiungiOsservatori();
        string nomeCliente;
        double a, b;
        int sceltaOp;

        do {
            Console.Clear();
            Console.WriteLine(new string('=', 10) + " Terminale " + new string('=', 10));
            Console.Write("\nInserisci il tuo nome: ");
            nomeCliente = Console.ReadLine()!;
        } while (string.IsNullOrWhiteSpace(nomeCliente));
        do {
            Console.Clear();
            Console.WriteLine("Inserisci il primo numero:");
        } while (!double.TryParse(Console.ReadLine()!, out a) || a is < 1);
        do {
            Console.Clear();
            Console.WriteLine("Inserisci il secondo numero:");
        } while (!double.TryParse(Console.ReadLine()!, out b) || b is < 1);

        do {
            Console.Clear();
            Console.WriteLine("Scegliere operazione (num):\n1. Addizione\n2. Sottrazione\n3. Moltiplicazione\n4. Divisione");
        } while (!int.TryParse(Console.ReadLine()!, out sceltaOp) || sceltaOp is < 1 or > 4);

        Operazione(sceltaOp, a, b);
        Soggetto.Instance.Notify(nomeCliente);
        Console.WriteLine("\nPremere un tasto per terminare...");
        Console.ReadKey(true);
        Console.Clear();
    }

    public static void Operazione(int sceltaOp, double a, double b) {
        Console.Clear();
        Calcolatrice calcolatrice;

        switch (sceltaOp)
        {
            case 1:
                calcolatrice = new Calcolatrice(new SommaStrategia());
                Console.WriteLine($"Risultato: {calcolatrice.Calcola(a, b)}\n");
                break;
            case 2:
                calcolatrice = new Calcolatrice(new SottrazioneStrategia());
                Console.WriteLine($"Risultato: {calcolatrice.Calcola(a, b)}\n");
                break;
            case 3:
                calcolatrice = new Calcolatrice(new MoltiplicazioneStrategia());
                Console.WriteLine($"Risultato: {calcolatrice.Calcola(a, b)}\n");
                break;
            case 4:
                calcolatrice = new Calcolatrice(new DivisioneStrategia());
                Console.WriteLine($"Risultato: {calcolatrice.Calcola(a, b)}\n");
                break;
        }
    }

    public static void AggiungiOsservatori() {
        Soggetto.Instance.Attach(new Osservatore("Aldo"));
        Soggetto.Instance.Attach(new Osservatore("Giovanni"));
        Soggetto.Instance.Attach(new Osservatore("Giacomo"));
    }
}