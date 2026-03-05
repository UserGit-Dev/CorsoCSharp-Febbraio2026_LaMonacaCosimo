class CorsoOnline : Corso
{
    private string _piattaforma = string.Empty;
    private string _linkAccesso = string.Empty;

    public string Piattaforma { get => _piattaforma; set => _piattaforma = value; }
    public string LinkAccesso { get => _linkAccesso; set => _linkAccesso = value; }
    
    public CorsoOnline(string nomeDocente, string materia, string titolo, int durataOre, string piattaforma, string linkAccesso) : base(nomeDocente, materia, titolo, durataOre)
    {
        Piattaforma = piattaforma;
        LinkAccesso = linkAccesso;
    }

    public override void ErogaCorso() 
    {
        Console.WriteLine($"Avvio sessione sulla piattaforma {Piattaforma}...");
        Console.WriteLine($"Link per partecipare: {LinkAccesso}");
        Console.WriteLine($"Il docente {Nome} è online.");
    }

    public override void StampaDettagli() 
    {
        Console.WriteLine($"Corso online: {Titolo}");
        Console.WriteLine($"Docente: {Nome} ({Materia})");
        Console.WriteLine($"Piattaforma: {Piattaforma} | Durata: {DurataOre} ore");
    }
}