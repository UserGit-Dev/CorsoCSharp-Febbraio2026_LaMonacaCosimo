class Chef(IPreparazioneStrategia prepStrat) : IPreparazioneStrategia
{
    private IPreparazioneStrategia _prepStrat = prepStrat;

    public void SetStrat(IPreparazioneStrategia prepStrat) => _prepStrat = prepStrat;
    public void PreparaPiatto() => _prepStrat.PreparaPiatto();
}