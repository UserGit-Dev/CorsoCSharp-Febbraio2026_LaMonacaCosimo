class CentroMeteo : ISoggetto
{
    private string _statoMeteo = string.Empty;
    
    private List<IObserver> _listObserver = [];
    public List<IObserver> ListObserver => _listObserver;

    public void Notifica()
    {
        foreach (var obs in _listObserver) { obs.Aggiorna(); }
    }

    public void Registra(IObserver osservatore)
    {
        _listObserver.Add(osservatore);
    }

    public void Rimuovi(IObserver osservatore)
    {
        _listObserver.Remove(osservatore);
    }

    public void AggiornaStato(string statoMeteo)
    {
        _statoMeteo = statoMeteo;
        Notifica();
    }
}