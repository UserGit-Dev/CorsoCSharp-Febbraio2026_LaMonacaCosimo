class ModuloMarketing : IObserver
{
    public void NotificaCreazione(string nomeUtente)
    {
        Console.WriteLine($"Marketing => Utente: {nomeUtente} - Iscritto alle offerte promozionali.");
    }
}