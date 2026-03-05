class PagamentoContanti : AnagraficaBase, IPagamento
{
    public PagamentoContanti(string nome) : base(nome) {}

    public void EseguiPagamento(decimal import) { 
        Console.WriteLine($"Nome: {Nome} => Pagamento di {import} euro in contanti)"); 
    }
    public void MostraPagamento(){ Console.WriteLine("Metodo: Contanti"); }
}