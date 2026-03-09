class Program
{
    static void Main()
    {
        var a = EsempioA();
        var b = EsempioB();
        
        Console.WriteLine("Esempio A & Esempio B puntano alla stessa istanza? => " + (ReferenceEquals(a, b) ? "Si" : "No"));
    }

    static Logger EsempioA() {
        var a = Logger.GetInstance();
        a.ScriviMessaggio("Esempio A");
        return a;
    }
    static Logger EsempioB() {
        var b = Logger.GetInstance();
        b.ScriviMessaggio("Esempio B");
        return b;
    }
}