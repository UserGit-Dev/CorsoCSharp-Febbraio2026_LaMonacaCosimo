class Insalata : IPiatto
{
    public string Descrizione() => "Insalata";

    public string Prepara() => Descrizione() + " in preparazione";
}