class Dipendente : Persona
{
    private long _id;
    private TipoFigura _ruolo;
    private string _badgeCode = string.Empty;
    private string _password = string.Empty;
    private string _turno = string.Empty;
    private decimal _salario;
    private bool _isPresent = false;

    public long Id { get => _id; set { _id = value; UpdateTimestamp();} }
    public TipoFigura Ruolo { get => _ruolo; set { _ruolo = value; UpdateTimestamp();} }
    public string BadgeCode { get => _badgeCode; set { _badgeCode = value; UpdateTimestamp();} }
    public string Password { get => _password; set { _password = value; UpdateTimestamp();} }
    public string Turno { get => _turno; set { _turno = value; UpdateTimestamp();} }
    public decimal Salario { get => _salario; set { _salario = value; UpdateTimestamp();} }
    public bool IsPresent { get => _isPresent; set { _isPresent = value; UpdateTimestamp();} }

    public Dipendente(string nome, string cognome, string codiceFiscale, DateOnly dataNascita, 
        long id, TipoFigura ruolo, string badgeCode, string password, string turno, decimal salario) : base(nome, cognome, codiceFiscale, dataNascita)
    {
        Id = id; Ruolo = ruolo; BadgeCode = badgeCode; Password = password; Turno = turno; Salario = salario;
    }

    public string ToPrintToDash() { 
        // Calcolo il padding basandosi sulla lunghezza massima tra le proprietà prese in esame
        int pad = Math.Max(Nome.Length, Math.Max(Id.ToString().Length, BadgeCode.Length)) + 1;
        
        // Compongo la riga
        string rigaDati = $"{"|", -3}Nome: {Nome.PadRight(Nome.Length + 3)}{"|", -3}" 
                        + $"Id: {Id.ToString().PadRight(Id.ToString().Length + 3)}{"|", -3}"
                        + $"Badge Code: {BadgeCode.PadRight(BadgeCode.Length + 3)}|";

        // Calcolo la lunghezza totale della riga composta
        int realTotalSpace = rigaDati.Length;
        
        // Genero i bordi basandomi sulla lunghezza reale
        string bordo = new('=', realTotalSpace);
    
        return $"{bordo}\n{rigaDati}\n{bordo}"; 
    }

    public string ToPrintAnagraficaDipendente()
    {
        return $"\nId: {Id}\nBadge (Code): {BadgeCode}\nRuolo: {Ruolo.ToString()}\nPassword: {Password}\n"  
        + $"Turno: {Turno}\nSalario: {Salario}\nPresente?: {IsPresent}\nModificato il: {ModifiedAt}\nCreato il: {CreatedAt}\n";
    }

    public string ToPrintAnagraficaCompleta()
    {
        return $"\nNome: {Nome}\nCognome: {Cognome}\nCodice Fiscale: {CodiceFiscale}\n" 
        + $"DataNascita: {DataNascita}\nId: {Id}\nBadge (Code): {BadgeCode}\nRuolo: {Ruolo.ToString()}\n"
        + $"Password: {Password}\nTurno: {Turno}\nSalario: {Salario}\nPresente?: {IsPresent}\n" 
        + $"Modificato il: {ModifiedAt}\nCreato il: {CreatedAt}\n";
    }
}