class ConSalsa(IPiatto piatto) : IngredienteExtra(piatto)
{
    public override string Descrizione() =>  _piatto.Descrizione() + ", con salsa";
    public override string Prepara() =>  _piatto.Prepara();
}