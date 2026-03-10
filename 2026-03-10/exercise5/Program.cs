class Program
{
    public static void Main()
    {
        GestoreCreazioneUtente.Instance.Registra(new ModuloLog());
        GestoreCreazioneUtente.Instance.Registra(new ModuloMarketing());

        string nomeUtente;

        do {
            Console.Clear();
            Console.WriteLine("Inserisci il nome dell'utente da registrare: ");
            nomeUtente = Console.ReadLine()!;
        } while (string.IsNullOrWhiteSpace(nomeUtente));

        Console.Clear();
        GestoreCreazioneUtente.Instance.CreaUtente(nomeUtente);
    }
}