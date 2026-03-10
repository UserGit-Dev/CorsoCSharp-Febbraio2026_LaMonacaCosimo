class GestoreCreazioneUtente : ISoggetto
{
    private static readonly Lazy<GestoreCreazioneUtente> _instance = new (() => new GestoreCreazioneUtente());
    private List<IObserver> _listObserver = [];

    public static GestoreCreazioneUtente Instance => _instance.Value;

    public void CreaUtente(string nome) { UserFactory.Crea(nome); Notifica(nome); }
    public void Notifica(string nomeUtente) 
    {
        foreach (var ob in _listObserver) ob.NotificaCreazione(nomeUtente);
    }
    public void Registra(IObserver o) { _listObserver.Add(o); }
    public void Rimuovi(IObserver o) { _listObserver.Remove(o); }
}