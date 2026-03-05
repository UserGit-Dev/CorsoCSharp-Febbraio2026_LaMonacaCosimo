class Persona
{
    private string _nome = string.Empty;
    private string _cognome = string.Empty;
    private string _codiceFiscale = string.Empty;
    private DateOnly _dataNascita;
    private DateTime _createdAt;
    private DateTime _modifiedAt;
    
    public string Nome { get => _nome; protected set { _nome = value; UpdateTimestamp();} }
    public string Cognome { get => _cognome; protected set { _cognome = value; UpdateTimestamp();} }
    public string CodiceFiscale { get => _codiceFiscale; protected set { _codiceFiscale = value; UpdateTimestamp();} }
    public DateOnly DataNascita { get => _dataNascita; protected set { _dataNascita = value; UpdateTimestamp();} }
    public DateTime CreatedAt { get => _createdAt; private set => _createdAt = value; }
    public DateTime ModifiedAt { get => _modifiedAt; private set => _modifiedAt = value; }

    public Persona(string nome, string cognome, string codiceFiscale, DateOnly dataNascita) 
    { 
        Nome = nome; Cognome = cognome; CodiceFiscale = codiceFiscale; DataNascita = dataNascita;

        DateTime utcNow = DateTime.UtcNow; // Variabile temporanea
        CreatedAt = utcNow; ModifiedAt = utcNow; // Così avranno la stessa data
    }

    protected void UpdateTimestamp() 
    {
        ModifiedAt = DateTime.UtcNow;
    }

    public string ToPrintAnagraficaPersona()
    {
        return $"\nNome: {Nome}\nCognome: {Cognome}\nCodice Fiscale: {CodiceFiscale}\nData di Nascita: {DataNascita}\n" 
        + $"Modificato il: {ModifiedAt}\nCreato il: {CreatedAt}\n";
    }
}