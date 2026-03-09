public sealed class ConfigurazioneSistema
{
    private static ConfigurazioneSistema _instance;
    private Dictionary<string, string> _impostazioni;

    private ConfigurazioneSistema()
    {
        _impostazioni = [];
        Console.WriteLine("--- Inizializzazione Sistema di Configurazione ---");
    }

    public static ConfigurazioneSistema Instance
    {
        get => _instance ??= new ConfigurazioneSistema();
    }

    public void Imposta(string chiave, string valore)
    {
        _impostazioni[chiave] = valore;
    }

    public string Leggi(string chiave)
    {
        return _impostazioni.TryGetValue(chiave, out var valore) ? valore : "Chiave non trovata";
    }

    public void StampaTutte()
    {
        Console.WriteLine("\nConfigurazioni Attuali:");
        foreach (var entry in _impostazioni)
        {
            Console.WriteLine($"- {entry.Key}: {entry.Value}");
        }
    }
}