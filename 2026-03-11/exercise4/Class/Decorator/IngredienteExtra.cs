abstract class IngredienteExtra(IPiatto piatto) : IPiatto
{
    protected IPiatto _piatto = piatto;

    public abstract string Descrizione();
    public abstract string Prepara();
}