class Pagamento(IPaymentStrategy strategy)
{
    private IPaymentStrategy _strategy = strategy;

    public void SetStrategy(IPaymentStrategy strategy) => _strategy = strategy;
    public void SetPayment(decimal pay) { _strategy.Pay(pay); }
}