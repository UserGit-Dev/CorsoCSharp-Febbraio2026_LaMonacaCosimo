class RegistroVeicoli
{
    private static readonly Lazy<RegistroVeicoli> _instance = new(() => new RegistroVeicoli());
    private List<IVeicolo> _listVeicolo = [];

    public static RegistroVeicoli Instance => _instance.Value;
    public List<IVeicolo> ListVeicolo => _listVeicolo;

    private RegistroVeicoli() { }

    public void Registra(IVeicolo veicolo) => _listVeicolo.Add(veicolo);
    public void StampaTutti() { foreach(var v in ListVeicolo) Console.WriteLine(v); }
}