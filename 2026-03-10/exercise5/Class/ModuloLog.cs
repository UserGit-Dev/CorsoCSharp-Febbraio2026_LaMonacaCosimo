class ModuloLog : IObserver
{
    public void NotificaCreazione(string nomeUtente)
    {
        Console.WriteLine($"Log => Utente: {nomeUtente} - Registrato con successo.");
    }
}