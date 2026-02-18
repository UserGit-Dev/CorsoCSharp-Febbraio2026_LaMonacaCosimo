// 1.
int tentativi = 3;
string password = "1234";

while (tentativi > 0)
{
    Console.WriteLine("Inserisci la password corretta: ");
    Console.WriteLine($"Tentivi -> {tentativi}");
    Console.Write("Password: ");
    string inPassword = Console.ReadLine()!;

    if (inPassword == password) {
        Console.Clear();
        Console.WriteLine("Password indovinata!");
        Console.WriteLine();
    } else if (inPassword != password && tentativi == 1)
    {
        tentativi--;
        Console.Clear();
        Console.WriteLine("Password inserita non corretta. Sessione conclusa.");
        Console.WriteLine();
    } 
    else {
        tentativi--;
        Console.Clear();
        Console.WriteLine("Password inserita non corretta, riprova.");
        Console.WriteLine();
    }
}

Console.WriteLine();

// 2. 
bool flag1 = true;
int totale = 0;

while (flag1)
{
    Console.Write("Inserisci numero da aggiungere (int): ");
    int numAggiungere = int.Parse(Console.ReadLine()!);

    if (numAggiungere == 0)
    {
        flag1 = false;
        Console.Clear();
        Console.WriteLine($"Operazione conclusa, totale: {totale}");
        Console.WriteLine();
    } else
    {
        totale += numAggiungere;
        Console.Clear();
        Console.WriteLine($"Somma aggiunta, totale: {totale}");
        Console.WriteLine();
    }
}