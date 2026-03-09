class Logger
{
    private static Logger? _instance;
    List<string> _internalList;

    public static Logger Instance => _instance ??= new Logger();

    private Logger() { _internalList = []; }

    public void Log(string message)
    {
        _internalList.Add(message);
    }

    public void PrintLog() {
        foreach(string log in _internalList) Console.WriteLine(log);
    }
}