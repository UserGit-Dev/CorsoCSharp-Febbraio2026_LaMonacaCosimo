class Program
{
    static void Main()
    {
        var inst1 = Logger.Instance;
        var inst2 = Logger.Instance;

        inst1.Log("1");
        inst1.Log("2");
        inst1.Log("3");
        inst2.Log("4");
        inst2.Log("5");
        inst2.Log("6");

        Console.WriteLine("Instanza 1");
        inst1.PrintLog();
        Console.WriteLine("\nInstanza 2");
        inst2.PrintLog();

        Console.WriteLine("\nInstanza 1 e 2 puntano alla stessa instanza? => " + (ReferenceEquals(inst1, inst2) ? "Si" : "No"));
    }
}