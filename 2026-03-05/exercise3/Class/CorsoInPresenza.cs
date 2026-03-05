class CorsoInPresenza : Corso
{
    private string _aula = string.Empty;
    private int _numeroPosti;

    public string Aula { get => _aula; set => _aula = value; }
    public int NumeroPosti { 
        get => _numeroPosti; 
        set {
            if (value is < 1) throw new ArgumentException("Errore di inizializzazione. Num. posti (Min: 1)");
            else _numeroPosti = value; 
        }
    }
    
    public CorsoInPresenza(string nomeDocente, string materia, string titolo, int durataOre, string aula, int numeroPosti) : base(nomeDocente, materia, titolo, durataOre)
    {
        Aula = aula;
        NumeroPosti = numeroPosti;
    }

    public override void ErogaCorso() 
    {
        Console.WriteLine($"Apertura aula {Aula} in corso...");
        Console.WriteLine($"Il docente {Nome} sta accogliendo gli studenti (Posti totali: {NumeroPosti}).");
    }

    public override void StampaDettagli() 
    {
        Console.WriteLine($"Corso in presenza: {Titolo}");
        Console.WriteLine($"Docente: {Nome} ({Materia})");
        Console.WriteLine($"Sede: Aula {Aula} | Durata: {DurataOre} ore");
    }
}