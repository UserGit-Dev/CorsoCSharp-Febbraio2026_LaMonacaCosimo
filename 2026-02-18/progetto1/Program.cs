// 1.
bool flag = true;
double saldo = 0;

while (flag)
{
    Console.WriteLine("Benvenuto!");
    Console.WriteLine("Effettua una delle seguenti operazioni: ");
    Console.WriteLine("1. Visualizza saldo");
    Console.WriteLine("2. Deposita denaro");
    Console.WriteLine("3. Preleva denaro");
    Console.WriteLine("4. Esci");

    int opzione = int.Parse(Console.ReadLine()!);

    if (opzione != 4)
    {
        switch (opzione)
        {
            case 1:
                Console.Clear();
                Console.WriteLine($"Saldo attaule: {saldo}€");
                Console.WriteLine();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Inserire quantitativo da depositare: ");
                saldo += double.Parse(Console.ReadLine()!);
                Console.Clear();
                Console.WriteLine($"Operazione completata, saldo attaule: {saldo}€");
                Console.WriteLine();
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Inserire il quantitativo da prelevare: ");
                double qntPrelievo = double.Parse(Console.ReadLine()!);
                if (qntPrelievo < saldo) {
                    saldo -= qntPrelievo;
                    Console.Clear();
                    Console.WriteLine($"Prelievo effettuato con successo, saldo attaule: {saldo}€");
                    Console.WriteLine();
                    break;
                } else {    
                    Console.Clear();
                    Console.WriteLine("Errore, somma da prelevare troppo elevata.");
                    Console.WriteLine();
                    break;
                }
            default:
                Console.Clear();
                Console.WriteLine("Errore, opzione non disponibile!");
                Console.WriteLine();
                break;
        }
    }
    else { 
        flag = false;
        Console.Clear();
        Console.WriteLine("Operazione conclusa. Arrivederci!"); 
    }
}