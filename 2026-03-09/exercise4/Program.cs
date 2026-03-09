using System.Data;

public class Porgram
{
    public static void Main()
    {
        List<IVeicolo> listVeicolo = [];
        int scelta;
        bool flag = true;

        while (flag)
        {
            do {
                Console.Clear();
                Console.WriteLine("Che veicolo desideri creare?\n1. Auto\n2. Moto\n3. Camion\n4. Avvia e mostra tipo\n5. (Esci)");
            } while (!int.TryParse(Console.ReadLine(), out scelta) || scelta is < 1 or > 5);

            switch (scelta) {
                case >= 1 and <= 3:
                    IVeicolo? veicolo = null;
                    if (scelta is 1) { veicolo = VeicoloFactory.CreaVeicolo("auto"); }
                    else if (scelta is 2) { veicolo = VeicoloFactory.CreaVeicolo("moto"); }
                    else if (scelta is 3) { veicolo = VeicoloFactory.CreaVeicolo("camion"); }
                    
                    Console.Clear();
                    if (veicolo is null) {
                        Console.WriteLine("Errore durante processo di instanza.\n");
                    } else { 
                        listVeicolo.Add(veicolo);
                        Console.WriteLine("Veicolo aggiunto con successo.\n");
                    }
                    ContinueAndClear();
                    break;
                case 4:
                    Console.Clear(); 
                    if (listVeicolo.Count is 0) {
                        Console.WriteLine("Lista veicoli attualmente vuota.\n");
                        } else { 
                            Console.WriteLine(new string('-', 25));
                            foreach (var v in listVeicolo) {
                                v.Avvia();
                                v.MostraTipo();
                                Console.WriteLine(new string('-', 25));
                            }
                        }
                        ContinueAndClear();
                    break;
                case 5:
                    flag = false;
                    Console.Clear();
                    Console.WriteLine("Sessione terminata.\nPremere un tasto per terminare...");
                    Console.ReadKey(true);
                    break;
            }
        }
    }

    public static void ContinueAndClear()
    {
        Console.WriteLine("Premere un tasto per continuare...");
        Console.ReadKey(true);
        Console.Write("\x1b[3j");
        Console.Clear();
    }
}