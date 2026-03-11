class Hamburger : IPiatto
{
    public string Descrizione() => "Hamburger";

    public string Prepara() => Descrizione() + " in preparazione";
}