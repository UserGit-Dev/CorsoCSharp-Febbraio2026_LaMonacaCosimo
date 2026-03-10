class DispositivoFactory
{
    public static IDispositivo? CreaDispositivo(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "computer":
                return new Computer();
            case "stampante":
                return new Stampante();
            case "":
                return null;
            default:
                return null;
        }
    }
}