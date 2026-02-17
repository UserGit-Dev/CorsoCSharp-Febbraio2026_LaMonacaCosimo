// 1. Somma di Due Numeri
Console.Write("Inserisci il primo numero: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Inserisci il secondo numero: ");
int num2 = int.Parse(Console.ReadLine()!);
int somma = num1 + num2;
Console.WriteLine("La somma è: " + somma);

Console.WriteLine();

// 2. Calcolo di un Prezzo Scontato
Console.Write("Inserisci il prezzo iniziale: ");
double prezzo = double.Parse(Console.ReadLine()!);
Console.Write("Inserisci la percentuale di sconto (es. 20): ");
int percentualeSconto = int.Parse(Console.ReadLine()!);
double sconto = (prezzo / 100) * percentualeSconto;
double prezzoFinale = prezzo - sconto;
Console.WriteLine($"Prezzo scontato: {prezzoFinale}€");

Console.WriteLine();

// 3. Controllo di un Numero Positivo
Console.Write("Inserisci un numero (anche decimale): ");
float numInput = float.Parse(Console.ReadLine()!);
bool isPositive = numInput > 0;
Console.WriteLine("Il numero è positivo? " + isPositive);