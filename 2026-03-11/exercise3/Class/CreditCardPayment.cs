class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine("Pagamento tramite carta di credito => " + amount);
    }
}