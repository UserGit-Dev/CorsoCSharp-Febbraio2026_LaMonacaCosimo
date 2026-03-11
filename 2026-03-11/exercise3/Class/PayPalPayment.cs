class PayPalPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine("Pagamento tramite PayPal => " + amount);
    }
}