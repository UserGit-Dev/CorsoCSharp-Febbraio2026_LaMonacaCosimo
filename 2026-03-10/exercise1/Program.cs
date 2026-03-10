class Program
{
    static List<IDispositivo> listDispositivo = [];
    static void Main()
    {
        bool flag = true;
        while (flag) {
            int scelta;

            do {
                Console.Clear();
                Console.WriteLine("Seleziona:\n1. Crea (Computer)\n2. Crea (Stampante)\n3. Accendi e mostra tipo (Tutti)\n4. Imposta (Config)\n" 
                    + "5. Leggi (Config)\n6. Stampa tutto (Config)\n7. ModuloA e ModuloB stessa istanza? (Verifica)\n8. (Esci)");
            } while (!int.TryParse(Console.ReadLine()!, out scelta) || scelta is < 1 or > 8);
            

            switch (scelta)
            {
                case >= 1 and <= 2:
                    Console.Clear();
                    CreaDispositivo(scelta);
                    ContinueAndClear();
                    break;
                case 3:
                    Console.Clear();
                    AccendiMostraTipo();
                    ContinueAndClear();
                    break;
                case 4:
                    Console.Clear();
                    ImpostaConfig();
                    ContinueAndClear();
                    break;
                case 5:
                    Console.Clear();
                    LeggiConfig();
                    ContinueAndClear();
                    break;
                case 6:
                    Console.Clear();
                    StampaConfig();
                    ContinueAndClear();
                    break;
                case 7:
                    Console.Clear();
                    VerificaInstModuloAB();
                    ContinueAndClear();
                    break;
                case 8:
                    flag = false;
                    Console.Clear();
                    Console.WriteLine("Sessione terminata.");
                    ContinueAndClear();
                    break;
            }
        }
    }

    public static void CreaDispositivo(int scelta)
    {
        string dispositivoScelto = scelta switch { 1 => "computer", 2 => "stampante", _ => string.Empty };
        IDispositivo? dispositivoCreato = DispositivoFactory.CreaDispositivo(dispositivoScelto);

        if (dispositivoCreato is  null) { 
            Console.WriteLine("Errore durante la creazione del dispositivo"); 
            return; 
        }
        
        listDispositivo.Add(dispositivoCreato);
        Console.Clear();
        Console.WriteLine("Dispositivo creato con successo.");
    }

    public static void AccendiMostraTipo()
    {
        if (listDispositivo.Count is 0) { Console.WriteLine("Lista attualmente vuota."); return; }

        Console.WriteLine(new string('-', 30));
        foreach (var device in listDispositivo)
        {
            device.Avvia();
            device.MostraTipo();
            Console.WriteLine(new string('-', 30));
        }
    }

    public static void ImpostaConfig()
    {
        string chiave , valore;

        do {
            Console.Clear();
            Console.WriteLine("Inserisci la chiave (Nuova/Presente): ");
            chiave = Console.ReadLine()!;
        } while (string.IsNullOrWhiteSpace(chiave));
        
        do {
            Console.Clear();
            Console.WriteLine("Inserisci il valore (Aggiungere/Sostituire): ");
            valore = Console.ReadLine()!;
        } while (string.IsNullOrWhiteSpace(valore));

        // Test di ModuloA
        ModuloA.LazyInstance.Imposta(chiave, valore);
        Console.Clear();
        Console.WriteLine("Configurazione aggiunta/sovrascritta con successo.");
    }

    public static void LeggiConfig()
    {
        string chiave;

        do {
            Console.Clear();
            Console.WriteLine("Inserisci la chiave della configurazione da leggere: ");
            chiave = Console.ReadLine()!;
        } while (string.IsNullOrWhiteSpace(chiave));

        Console.Clear();
        // Secondo test di ModuloA
        Console.WriteLine(ModuloA.LazyInstance.Leggi(chiave));
    }

    public static void StampaConfig()
    {
        // Test ModuloB
        ModuloB.LazyInstance.StampaTutte();
    }

    public static void VerificaInstModuloAB() {
        Console.WriteLine("MoluloA e ModuloB si appoggiano sulla stessa istanza? => " 
            + (ReferenceEquals(ModuloA.LazyInstance, ModuloB.LazyInstance) ? "Si" : "No"));
    }

    public static void ContinueAndClear()
    {
        Console.WriteLine("\nPremere un tasto per continuare...");
        Console.ReadKey(true);
        Console.Write("\x1b[3j");
        Console.Clear();
    }
}