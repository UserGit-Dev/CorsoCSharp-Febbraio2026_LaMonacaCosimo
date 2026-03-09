class RegistroVeicoli
{
    private static RegistroVeicoli _instance;
    private List<IVeicolo> _listVeicolo = [];

    public static RegistroVeicoli Instance => _instance ??= new RegistroVeicoli();
    public List<IVeicolo> ListVeicolo => _listVeicolo;

    private RegistroVeicoli() { }

    public static RegistroVeicoli GetInstance() { return _instance ??= new RegistroVeicoli(); }
    public void Registra(IVeicolo veicolo) => _listVeicolo.Add(veicolo);
    public void StampaTutti() { foreach(var v in ListVeicolo) Console.WriteLine(v); }
}