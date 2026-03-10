class Stampante : IDispositivo
{
    public void Avvia() { Console.WriteLine("La stampante si sta accendendo."); }

    public void MostraTipo() { Console.WriteLine("Tipo: Stampante"); }
}