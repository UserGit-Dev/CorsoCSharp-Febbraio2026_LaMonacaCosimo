interface ISoggetto
{
    public void Registra(IObserver o);
    public void Rimuovi(IObserver o);
    public void Notifica(string nomeUtente);
}