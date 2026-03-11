class BitcoinPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine("Pagamento tramite bitcoin => " + amount);
    }
}