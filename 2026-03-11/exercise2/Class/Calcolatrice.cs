class Calcolatrice
{
    private IStrategiaOperazione _strategia;

    public Calcolatrice(IStrategiaOperazione strategia) => _strategia = strategia;

    public double Calcola(double a, double b) => _strategia.Calcola(a, b);
    public void ImpostaStrategia(IStrategiaOperazione strategia) => _strategia = strategia;
}