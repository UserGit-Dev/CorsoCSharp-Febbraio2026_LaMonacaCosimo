class Program
{
    public static void Main()
    {
        Random random = new();
        List<IPagamento> listPagamento = [];
        listPagamento.Add(new Pagamento("Franco", "Master Card"));
        listPagamento.Add(new PagamentoContanti("Paolo"));
        listPagamento.Add(new PagamentoPayPal("Gino", "esempio@gmail.com"));

        Console.WriteLine(new string('_', 70));
        foreach (IPagamento pagamento in listPagamento)
        {
            pagamento.EseguiPagamento((decimal)random.Next());
            pagamento.MostraPagamento();
            Console.WriteLine(new string('_', 85));
        }
    }
}