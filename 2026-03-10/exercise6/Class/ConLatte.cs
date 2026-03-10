class ConLatte(IBevanda bevanda) : DecoratoreBevanda(bevanda)
{
    public override double Costo() => 3.50;
    public override string Descrizione() => "Bevanda con latte.";
}