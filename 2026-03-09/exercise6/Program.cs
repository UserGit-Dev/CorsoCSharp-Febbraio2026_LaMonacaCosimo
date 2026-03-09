class Program
{
    static void Main()
    {
        List<IVeicolo> listVeicolo = [];
        bool flag = true;
        while (flag) {
            int scelta;
            do {
                Console.Clear();
                Console.WriteLine(new string('=', 5) + " Terminale " + new string('=', 5) + "\n");
                Console.WriteLine("Seleziona:\n1. Crea (Auto)\n2. Crea (Moto)\n3. Crea (Camion)\n4. Avvia e mostra tipo (Tutti)\n5. Lista veicoli\n6. (Esci)");
            } while (!int.TryParse(Console.ReadLine()!, out scelta) || scelta is < 1 or > 6);

            switch (scelta) {
                case >= 1 and <= 3:
                    Console.Clear();
                    string tipo = scelta switch { 1 => "Auto", 2 => "Moto", 3 => "Camion" };
                    IVeicolo nuovoVeicolo = VeicoloFactory.CreaVeicolo(tipo);

                    if (nuovoVeicolo != null) {
                        RegistroVeicoli.Instance.Registra(nuovoVeicolo);
                        Console.WriteLine($"{tipo} creata e registrata con successo.");
                    } else {
                        Console.WriteLine("Errore: Creazione fallita.");
                    }
                    ContinueAndClear();
                    break;
                case 4:
                    Console.Clear();
                    if (RegistroVeicoli.Instance.ListVeicolo.Count is 0 ) {
                        Console.WriteLine("Lista veicoli attualmente vuota.");
                    } else {
                        Console.WriteLine(new string('-', 35));
                        foreach (var veicolo in RegistroVeicoli.Instance.ListVeicolo) { 
                            veicolo.Avvia(); 
                            veicolo.MostraTipo(); 
                            Console.WriteLine(new string('-', 35)); 
                        }
                    }
                    ContinueAndClear();
                    break;
                case 5:
                    Console.Clear();
                    RegistroVeicoli.Instance.StampaTutti();
                    ContinueAndClear();
                    break;
                case 6:
                    flag = false;
                    Console.Clear();
                    Console.WriteLine("Sessione terminata.");
                    ContinueAndClear();
                    break;
            }
        }
    }

    public static void ContinueAndClear()
    {
        Console.WriteLine("\nPremere un tasto per continuare...");
        Console.ReadKey(true);
        Console.Write("\x1b[3j");
        Console.Clear();
    }
}