// 1.
Console.Write("Inserisci una frase: ");
string frase1 = Console.ReadLine()!;
int qnt = 0;

foreach (char carattere in frase1)
{
    qnt++;
}

Console.WriteLine($"Quantità caratteri: {qnt}");
Console.WriteLine();

// 2.
Console.Write("Inserisci una frase: ");
string frase2 = Console.ReadLine()!;
Console.WriteLine(frase2.Replace(" ", ""));

Console.WriteLine();

// 3.
Console.Write("Inserire stringa: ");
string frase3 = Console.ReadLine()!.ToLower();
string vocali = "aeiou";
int qntVocaliPresenti = 0;

foreach (char carattere in frase3)
{
    if (vocali.Contains(carattere)) {
        qntVocaliPresenti++;
    }
}

Console.WriteLine($"Quantità vocali -> {frase3}: {qntVocaliPresenti}");
Console.WriteLine();

// 4.
Console.Write("Inserisci password da convalidare: ");
string password = Console.ReadLine()!;
int charCounter = 0;
bool isCharUpper = false;
bool isCharDigit = false; 

if (!password.StartsWith(" ") && !password.EndsWith(" ")) {
    foreach (char carattere in password) {
        charCounter++;
        if (char.IsUpper(carattere)) {
            isCharUpper = true;
        } else if (char.IsDigit(carattere)) {
            isCharDigit = true;
        }
    }  
} 

if (isCharUpper && isCharDigit) {
    Console.WriteLine($"La password -> {password} è valida!");
} else {
    Console.WriteLine("La password inserita non è valida.");
}

Console.WriteLine();

// 5.
Console.Write("Inserisci una stringa da analizzare: ");
string stringa = Console.ReadLine()!;
int charCounter1 = 0;
bool isLetter = false;
bool isWhiteSpace = false;
bool isPunctuation = false;

foreach (char carattere in stringa) {
    charCounter1++;
    if (char.IsLetter(carattere)) { isLetter = true; }
    else if (char.IsWhiteSpace(carattere)) { isWhiteSpace = true; }
    else if (char.IsPunctuation(carattere)) { isPunctuation = true; }
}

if (isLetter && isWhiteSpace && isPunctuation) {
    Console.WriteLine($"La stringa -> {stringa} è valida!");
} else {
    Console.WriteLine("La stringa inserita non è valida.");
}

