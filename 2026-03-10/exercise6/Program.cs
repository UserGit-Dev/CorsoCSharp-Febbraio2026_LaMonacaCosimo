class Program
{
    public static void Main() {
        IBevanda bevanda = new Caffe();
        ConLatte bevandaSpecial = new(bevanda);

        Console.WriteLine(bevandaSpecial.Descrizione() + " => " + bevandaSpecial.Costo());
        Console.WriteLine("\nPremere un tasto per continuare...");
        Console.ReadKey(true);
        Console.Clear();
    }
}