class Osservatore(string nome)
{
    private string _nome = nome;
    public void React(string nomeCliente) => Console.WriteLine($"Ciao {_nome}, ti avvisiamo che l'utente \"{nomeCliente}\" ha effettuato un'operazione di calcolo.");
}