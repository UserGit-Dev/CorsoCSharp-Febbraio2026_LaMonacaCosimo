class Observer(string nome)
{
    private string _nome = nome;

    public void Update(string nomeCliente) => Console.WriteLine($"Ciao {_nome}, ti avviso che il cliente {nomeCliente} sta effettuando un'ordine.");
}