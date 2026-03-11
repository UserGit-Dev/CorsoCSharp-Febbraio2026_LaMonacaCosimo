class Soggetto
{
    private static readonly Lazy<Soggetto> _instance = new (() => new Soggetto());
    List<Osservatore> _listOsservatori = [];

    public static Soggetto Instance => _instance.Value;

    public void Attach(Osservatore ob) { _listOsservatori.Add(ob); }
    public void Detach(Osservatore ob) { _listOsservatori.Remove(ob); }
    public void Notify(string nomeCliente) { foreach(var ob in _listOsservatori) ob.React(nomeCliente); }
}