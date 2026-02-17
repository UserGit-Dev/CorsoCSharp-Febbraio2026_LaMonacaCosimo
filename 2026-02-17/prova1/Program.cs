Console.WriteLine("Inserisci il primo numero: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Inserisci il secondo numero: ");
int b = int.Parse(Console.ReadLine()!);

if (a > b){
    Console.WriteLine($"{a} è più grande di {b}");
} else {
    Console.WriteLine($"{b} è più grande di {a}");
}

Console.WriteLine();

// Ciclo While
bool continua = true;
while (continua) //finché "continua" rimane true il codice viene ripetuto
{
    Console.WriteLine("Ciclo in esecuzione");
    // continua = bool.Parse(Console.ReadLine()!);
    continua = bool.Parse(Console.ReadLine()!);
}

int continua2 = 0;
while (continua2 < 10) //finché "continua" rimane true il codice viene ripetuto
{
    Console.WriteLine("Ciclo in esecuzione");
    continua2 += 1;
    Console.WriteLine(continua2);
}
