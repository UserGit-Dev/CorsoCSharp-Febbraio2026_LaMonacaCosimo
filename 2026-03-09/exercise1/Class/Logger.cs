class Logger
{
    private static Logger? Log { get; set; }

    private Logger() { }

    public static Logger GetInstance() => Log ??= new Logger();

    public void ScriviMessaggio(string messaggio) { 
        Console.WriteLine($"{DateTime.Now}: {messaggio}");
    }
}