static class PiattoFactory
{
    public static IPiatto? CreaPiatto(string tipo)
    {
        return tipo switch
        {
            "Pizza" => new Pizza(),
            "Hamburger" => new Hamburger(),
            "Insalata" => new Insalata(),
            _ => null,
        };
    }
}