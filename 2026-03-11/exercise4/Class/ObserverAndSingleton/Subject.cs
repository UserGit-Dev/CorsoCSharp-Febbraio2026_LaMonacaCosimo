class Subject
{
    private static readonly Lazy<Subject> _instance = new (() => new Subject());
    private string _nomeCliente = string.Empty;
    private List<Observer> _listOb = [];

    public static Subject Instance => _instance.Value;
    public string NomeCliente { set { _nomeCliente = value; Notify(); } }

    public void Attach(Observer ob) { _listOb.Add(ob); }
    public void Detach(Observer ob) { _listOb.Remove(ob); }
    public void Notify() { foreach(var ob in _listOb) ob.Update(_nomeCliente); }
}