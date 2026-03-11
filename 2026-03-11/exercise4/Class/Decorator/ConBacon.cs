class ConBacon(IPiatto piatto) : IngredienteExtra(piatto)
{
    public override string Descrizione() =>  _piatto.Descrizione() + ", con bacon";
    public override string Prepara() =>  _piatto.Prepara();
}