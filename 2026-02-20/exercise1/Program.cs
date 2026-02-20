class Program
{
    static void Main(string[] args)
    {
        /* // 1.
        int numToDouble;
        Console.Write("Inserisci il numero da raddoppiare: ");
        numToDouble = int.Parse(Console.ReadLine()!);

        Console.Write($"{numToDouble} * 2 = ");
        Raddoppia(ref numToDouble);
        Console.WriteLine(numToDouble); */

        /* // 2.
        int giorno;
        int mese;
        int anno;
        Console.WriteLine("\nInserisci la data da correggere...");
        Console.Write("Giorno: ");
        giorno = int.Parse(Console.ReadLine()!);
        Console.Write("Mese: ");
        mese = int.Parse(Console.ReadLine()!);
        Console.Write("Anno: ");
        anno = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"\nData inserita: {giorno}/{mese}/{anno}");
        AggiustaData(ref giorno, ref mese, ref anno);
        Console.WriteLine($"Data corretta: {giorno}/{mese}/{anno}"); */
        
        /* // 3.  
        int dividendo;
        int divisore;
        int quoziente;
        int resto;
        Console.Write("\nInserisci il dividendo: ");
        dividendo = int.Parse(Console.ReadLine()!);
        Console.Write("Inserisci il divisore: ");
        divisore = int.Parse(Console.ReadLine()!);
        Dividi(dividendo, divisore, out quoziente, out resto);
        Console.WriteLine($"Dividendo {dividendo}, Divisore {divisore} -> Quoziente {quoziente}, Resto {resto}"); */

        /* // 4.
        string stringa; 
        Console.Write("\nInserisci stringa da analizzare: ");
        stringa = Console.ReadLine()!;
        AnalizzaParola(stringa); */

        /* // 5.
        int turniCounter = 0;
        int bonus = 5;
        double punteggioCorrente = 0;     
        double punteggioTotale = 0;
        double media = 0;  
        Console.WriteLine("\nInserisci punteggio (1 di 3): ");
        punteggioCorrente = double.Parse(Console.ReadLine()!);
        AggiornaPunteggio(ref turniCounter, bonus, ref punteggioCorrente, ref punteggioTotale, out media);
        Console.WriteLine("\nInserisci punteggio (2 di 3): ");
        punteggioCorrente = double.Parse(Console.ReadLine()!);
        AggiornaPunteggio(ref turniCounter, bonus, ref punteggioCorrente, ref punteggioTotale, out media);
        Console.WriteLine("\nInserisci punteggio (3 di 3): ");
        punteggioCorrente = double.Parse(Console.ReadLine()!);
        AggiornaPunteggio(ref turniCounter, bonus, ref punteggioCorrente, ref punteggioTotale, out media);
        Console.WriteLine($"\nRisultati\nPunteggio totale: {punteggioTotale}\nMedia punteggio: {media}"); */

        /* // 6.
        double voto1;
        double bonus1;
        double voto2;
        double bonus2;
        double mediaStudente;

        Console.Write("\nPunteggio studente\nInserisci il primo voto (1 di 2): ");
        voto1 =  double.Parse(Console.ReadLine()!);
        Console.Write("Inserisci bonus: ");
        bonus1 =  double.Parse(Console.ReadLine()!);
        Console.Clear();
        Console.Write("Inserisci il secondo voto (2 di 2): ");
        voto2 =  double.Parse(Console.ReadLine()!);
        Console.Write("Inserisci bonus: ");
        bonus2 =  double.Parse(Console.ReadLine()!);
        Console.Clear();
        bool risultato = ElaboraStudente(ref voto1, bonus1, ref voto2, bonus2, out mediaStudente);
        if (risultato) Console.WriteLine($"Media: {mediaStudente} -> Studente è promosso.");
        else Console.WriteLine($"Media: {mediaStudente} -> Studente bocciato."); */

        /* // 7.
        int[] nums = new int[3];
        int min;
        int max;
        int media;
        for (int i = 0; i <3; i++)
        {
            Console.Write($"Inserisci il {i+1}° numero: ");
            nums[i] = int.Parse(Console.ReadLine()!);
        }
        media = AnalizzaSerieDiNumeri(nums, out min, out max);
        Console.WriteLine($"La media tra il numero minimo {min} e il numero massimo {max} è {media}."); */

        /* // 8.
        Console.Write("\nInserisci voto studente: ");
        double otto_voto = double.Parse(Console.ReadLine()!);
        bool otto_risultato = AggiornaVoti(otto_voto);
        if (otto_risultato) Console.WriteLine($"Voto {otto_voto} -> Tutto Ok!");
        else Console.WriteLine($"Voto {otto_voto} -> Tutto male!"); */
    }

    static void Raddoppia(ref int num)
    {
        num *= 2;
    }

    static void AggiustaData(ref int giorno, ref int mese, ref int anno)
    {
        if (giorno > 30)
        {
            giorno = 1; 
            mese++;
        }
        if (mese > 12) 
        {
            mese = 1; 
            anno++;
        }
    }

    static void Dividi(int dividendo, int divisore, out int quoziente, out int resto)
    {
        quoziente = dividendo / divisore;
        resto = dividendo % divisore;
    }

    static void AnalizzaParola(string stringa)
    {
        string vocali = "aeiou";
        string consonanti = "bcdfghjklmnpqrstvwxyz";
        int numVocali = 0;
        int numConsonanti = 0;
        int numSpazi = 0;

        foreach(char carattere in stringa)
        {
            if (vocali.ToLower().Contains(carattere)) numVocali++;
            if (consonanti.ToLower().Contains(carattere)) numConsonanti++;
            if (char.IsWhiteSpace(carattere)) numSpazi++;
        }

        Console.WriteLine($"La frase \"{stringa}\" contiene: \n1. Vocali -> {numVocali}\n2. Consonanti -> {numConsonanti}\n3. Spazi vuoti -> {numSpazi}");
    } 

    static void AggiornaPunteggio(ref int turniCounter, int bonus, ref double punteggioCorrente, ref double punteggioTotale, out double media)
    {
        punteggioCorrente += bonus;
        punteggioTotale += Math.Round(punteggioCorrente, 2);
        turniCounter++;

        if (turniCounter == 3) { media = Math.Round(punteggioTotale / 3, 2); }
        else { media = 0; }
    }

    static bool ElaboraStudente(ref double voto1, double bonus1, ref double voto2, double bonus2, out double mediaStudente)
    {
        if (bonus1 > 10 || bonus1 < 1 || bonus2 > 10 || bonus2 < 1) 
        { 
            Console.Clear();
            Console.WriteLine("Errore, il bonus deve esserecompreso da 1 a 10. Media azzerata.");
            mediaStudente = 0; 
            return false; 
        }

        double totale = voto1 + bonus1 + voto2 + bonus2;
        mediaStudente = totale / 2;

        return mediaStudente >= 6;  
    }

    static int AnalizzaSerieDiNumeri(int[] nums, out int min, out int max)
    {
        min = nums[0];
        max = nums[0];

        foreach (int num in nums)
        {
            if (num > max) { max = num; }        
            if (num < min) { min = num; }
        }

        return (min + max) / 2;
    }

    static bool AggiornaVoti(double otto_voto)
    {
        if (otto_voto < 0) return false;
        while (otto_voto > 30) { otto_voto /= 10; }

        // "Bonus di impegno"
        // Uso un for: per ogni decina completa del voto (es. 23 => due iterazioni)
        double decineComplete = otto_voto / 10;
        for (int i = 0; i < decineComplete; i++)
        {
            // ovviamento aumento solo se il voto non supera 30
            if (otto_voto < 30) { otto_voto++; }
        }

        return true;
    }
}