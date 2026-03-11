class Pizza : IPiatto
{
    public string Descrizione() => "Pizza";

    public string Prepara() => Descrizione() + " in preparazione";
}