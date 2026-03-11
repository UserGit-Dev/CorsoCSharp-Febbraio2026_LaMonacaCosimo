class ConFormaggio(IPiatto piatto) : IngredienteExtra(piatto)
{
    public override string Descrizione() =>  _piatto.Descrizione() + ", con formaggio";
    public override string Prepara() =>  _piatto.Prepara();
}