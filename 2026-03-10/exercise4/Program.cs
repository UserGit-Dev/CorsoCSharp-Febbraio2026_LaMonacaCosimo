class Program
{
    static void Main()
    {
        // Effettuo attach di due "INewsSubscriber"
        NewsAgency.Instance.Attach(new MobileApp());
        NewsAgency.Instance.Attach(new EmailClient());
        string news;

        do {
            Console.Clear();
            Console.Write("Inserisci titolo della news: ");
            news = Console.ReadLine()!;
        } while (string.IsNullOrWhiteSpace(news));

        Console.Clear();
        NewsAgency.Instance.News = news;
        Console.WriteLine("\nPremere un tasto per terminare...");
        Console.ReadKey(true);
        Console.Clear();
    }
}