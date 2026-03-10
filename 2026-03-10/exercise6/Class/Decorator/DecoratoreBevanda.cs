abstract class DecoratoreBevanda : IBevanda
{
    private IBevanda _bevanda;
    
    public DecoratoreBevanda(IBevanda bevanda) { _bevanda = bevanda; }

    public virtual double Costo() => _bevanda.Costo();
    public virtual string Descrizione() => _bevanda.Descrizione();
}