interface ISoggetto {
    public void Registra(IObserver osservatore);
    public void Rimuovi(IObserver osservatore);
    public void Notifica();
}