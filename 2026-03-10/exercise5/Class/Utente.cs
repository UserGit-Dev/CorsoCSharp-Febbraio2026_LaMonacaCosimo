class Utente(string nome)
{
    private readonly string _nome = nome;

    public override string ToString() { return $"Nome: {_nome}"; }
}