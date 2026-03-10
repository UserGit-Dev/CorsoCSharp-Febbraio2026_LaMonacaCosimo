static class ModuloA
{
    private static readonly ConfigurazioneSistema _lazyInstance = ConfigurazioneSistema.LazyInstance;
    public static ConfigurazioneSistema LazyInstance => _lazyInstance;
}