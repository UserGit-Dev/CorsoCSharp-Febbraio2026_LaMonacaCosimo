public sealed class ConfigurazioneSistema
{
    private static Lazy<ConfigurazioneSistema> _lazyInstance = new(() => new ConfigurazioneSistema());
    private Dictionary<string, string> _dicConfiguration = new(StringComparer.OrdinalIgnoreCase); 

    public static ConfigurazioneSistema LazyInstance => _lazyInstance.Value;

    private ConfigurazioneSistema() {}

    public void Imposta(string chiave, string valore) => _dicConfiguration[chiave] = valore;
    public string Leggi(string chiave) => _dicConfiguration.GetValueOrDefault(chiave, "Configurazione non trovata.");
    public void StampaTutte()
    {
        if (_dicConfiguration.Count is 0) { Console.WriteLine("Lista attualmente vuota."); return; }
        foreach (var kv in _dicConfiguration) Console.WriteLine(kv.Value);
    }
}