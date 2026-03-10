class ConPanna : DecoratoreBevanda
{
    public ConPanna(IBevanda bevanda) : base(bevanda) {}

    public override double Costo() => 3.25;
    public override string Descrizione() => "Bevanda con panna";
}