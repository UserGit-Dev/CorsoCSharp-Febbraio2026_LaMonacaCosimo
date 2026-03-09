class ModuloA
{
    private readonly ConfigurazioneSistema _config = ConfigurazioneSistema.Instance;
    public ConfigurazioneSistema Config => _config;

    public void Esegui()
    {
        Config.Imposta("Lingua", "Italiano");
        Config.Imposta("Tema", "Dark");
        Console.WriteLine("ModuloA ha impostato Lingua e Tema.");
    }
}

class ModuloB
{
    private readonly ConfigurazioneSistema _config = ConfigurazioneSistema.Instance;
    public ConfigurazioneSistema Config => _config;

    public void Esegui()
    {
        Console.WriteLine($"ModuloB legge Tema: {Config.Leggi("Tema")}");
        Config.Imposta("Timeout", "30s");
    }
}

class Program
{
    static void Main()
    {
        ModuloA modA = new();
        ModuloB modB = new();

        modA.Esegui();
        modB.Esegui();

        ConfigurazioneSistema.Instance.StampaTutte();
        Console.WriteLine("Modulo A e Modulo B stanno agendo sulla stessa istanza di configurazione? => " 
            + (ReferenceEquals(modA.Config, modB.Config) ? "Si" : "No"));
    }
}