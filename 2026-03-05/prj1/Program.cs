class Program : ConsoleUtility
{
    static List<Dipendente> listDipendente = [
        new Dipendente("Franco", "Paoli", "FRNPO", DateOnly.Parse("2000-12-12"), 1, TipoFigura.Amministratore, "BADGE", "PASSWORD", "Mattina", 1500),
    ];

    public static void Main()
    {
        bool flag = true;
        while (flag)
        {
            int scelta;
            
            do {
                Console.Clear();
                Console.WriteLine("Seleziona:\n1. Amministratore\n2. Dipendente\n3. (Esci)");
            } while (!int.TryParse(Console.ReadLine()!, out scelta) || scelta is < 1 or > 3);

            switch (scelta)
            {
                case 1:
                    Console.Clear();
                    ValidazioneDipendente(TipoFigura.Amministratore);
                    break;
                case 2:
                    Console.Clear();
                    ValidazioneDipendente(TipoFigura.Dipendente);                
                    break;
                case 3:
                    flag = false;
                    Console.Clear();
                    Console.WriteLine("Sessione terminata.");
                    ContinueAndClear();
                    break;
            }
        }
    }

    public static void ValidazioneDipendente(TipoFigura tipoScelto)
    {
        if (listDipendente.Count is 0) {
            Console.Clear();
            Console.WriteLine("Problema interno del server. Processo di validazione interrotta.");
            ContinueAndClear();
            return;
        }

        Dipendente? dipendeteTrovato = null;
        string badgeCode;
        
        do {
            Console.Clear();
            Console.WriteLine("Inserisci il codice codice del tuo badge (0: Uscire): ");
            badgeCode = Console.ReadLine()!.ToUpper();
        } while (string.IsNullOrWhiteSpace(badgeCode));
        
        if (badgeCode is "0") {
            Console.Clear();
            Console.WriteLine("Processo di validazione annullata.");
            ContinueAndClear();
            return;
        }

        if (tipoScelto is TipoFigura.Amministratore) {
            string password;

            do {
                Console.Clear();
                Console.WriteLine("Inserisci la tua password: ");
                password = Console.ReadLine()!;
            } while (string.IsNullOrWhiteSpace(password));
            
            foreach(Dipendente dipendente in listDipendente)
            {
                if (dipendente.Ruolo is TipoFigura.Amministratore 
                    && string.Equals(dipendente.BadgeCode, badgeCode, StringComparison.OrdinalIgnoreCase) 
                    && string.Equals(dipendente.Password,password)) 
                { 
                    dipendeteTrovato = dipendente;
                    break; 
                }
            }
        } else if (tipoScelto is TipoFigura.Dipendente) {
            foreach(Dipendente dipendente in listDipendente)
            {
                if (dipendente.Ruolo is TipoFigura.Dipendente 
                    && string.Equals(dipendente.BadgeCode, badgeCode, StringComparison.OrdinalIgnoreCase)) 
                { 
                    dipendeteTrovato = dipendente;
                    break; 
                }
            }
        }

        if (dipendeteTrovato is null) { 
            Console.Clear();
            Console.WriteLine("Errore, i dati forniti non sono corretti.");
            ContinueAndClear();
            return;
        }

        switch (dipendeteTrovato.Ruolo)
        {
            case TipoFigura.Amministratore:
                Console.Clear();
                Console.WriteLine("Procedura di accesso sicuro validata con successo.");
                ContinueAndClear();
                break;
            case TipoFigura.Dipendente:
                Console.Clear();
                Console.WriteLine("Badge validato con successo.");
                ContinueAndClear();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Errore, tipo figura non riconosciuto.");
                ContinueAndClear();
                break;
        }
    }
}