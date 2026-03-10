class ConCioccolato : DecoratoreBevanda
{
    public ConCioccolato(IBevanda bevanda) : base(bevanda) {}

    public override double Costo() => 3.75;
    public override string Descrizione() => "Bevanda al cioccolato.";
    
}