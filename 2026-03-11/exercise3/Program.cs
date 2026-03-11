class Program
{
    static void Main()
    {
        int scelta;
        
        do {
            Console.Clear();
            Console.WriteLine(new string('=', 10) + " Terminale " + new string('=', 10));
            Console.WriteLine("\nSeleziona:\n1. Pagamento (Carta Credito)\n2. Pagamento (PayPal)\n3. Pagamento (Bitcoin)\n4. (Esci)");
        } while (!int.TryParse(Console.ReadLine()!, out scelta) || scelta is < 1 or > 4);

        switch (scelta)
        {
            case >= 1 and <= 3:
                Pagamento(scelta);
                ContinueAndClear();
                Console.Clear();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Sessione terminata.");
                ContinueAndClear();
                break;
        }
    }

    public static void Pagamento(int scelta)
    {
        Pagamento pagamento;
        decimal cifra;

        do {
            Console.Clear();
            Console.Write("Inserisci la somma: ");
        } while (!decimal.TryParse(Console.ReadLine()!, out cifra) || cifra is < 1);
        
        Console.Clear();

        switch (scelta)
        {
            case 1:
                pagamento = new Pagamento(new CreditCardPayment());
                pagamento.SetPayment(cifra);
                break;
            case 2:
                pagamento = new Pagamento(new PayPalPayment());
                pagamento.SetPayment(cifra);
                break;
            case 3:
                pagamento = new Pagamento(new BitcoinPayment());
                pagamento.SetPayment(cifra);
                break;
        }

        Console.WriteLine("Transazione avvenuta con successo.");
    }

    public static void ContinueAndClear()
    {
        Console.WriteLine("\nPremere un tasto per continuare...");
        Console.ReadKey(true);
        Console.Write("\x1b[3j");
        Console.Clear();
    }
}