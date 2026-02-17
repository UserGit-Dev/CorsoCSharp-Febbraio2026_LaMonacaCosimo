string giorno = "lunedì";

switch (giorno)
{
    case "lunedì":
        Console.WriteLine("Inizio settimana");
        break;
    case "venerdì":
        Console.WriteLine("Quasi weekend");
        break;
    default:
        Console.WriteLine("Altro giorno");
        break;
}

Console.WriteLine();

// 1.
Console.Write("Inserisci un numero da 1 a 7: ");
int numero = int.Parse(Console.ReadLine()!);

switch (numero)
{
    case 1:
        Console.WriteLine("Lunedì");
        break;
    case 2:
        Console.WriteLine("Martedì");
        break;
    case 3:
        Console.WriteLine("Mercoledì");
        break;
    case 4:
        Console.WriteLine("Giovedì");
        break;
    case 5:
        Console.WriteLine("Venerdì");
        break;
    case 6:
        Console.WriteLine("Sabato");
        break;
    case 7:
        Console.WriteLine("Domenica");
        break;
    default:
        Console.WriteLine("Errore: il numero deve essere compreso tra 1 e 7.");
        break;
}

Console.WriteLine();

// 2.
Console.WriteLine("Quale area vuoi calcolare? (quadrato, cerchio, triangolo)");
string figura = Console.ReadLine()!;

switch (figura)
{
    case "quadrato":
        Console.Write("Inserisci il lato: ");
        double lato = double.Parse(Console.ReadLine()!);
        double areaQuadrato = lato * lato;
        Console.WriteLine($"L'area del quadrato è: {areaQuadrato}");
        break;
    case "cerchio":
        Console.Write("Inserisci il raggio: ");
        double raggio = double.Parse(Console.ReadLine()!);
        double areaCerchio = 3.14 * raggio * raggio;
        Console.WriteLine($"L'area del cerchio è: {areaCerchio}");
        break;
    case "triangolo":
        Console.Write("Inserisci la base: ");
        double baseT = double.Parse(Console.ReadLine()!);
        Console.Write("Inserisci l'altezza: ");
        double altezza = double.Parse(Console.ReadLine()!);
        double areaTriangolo = (baseT * altezza) / 2;
        Console.WriteLine($"L'area del triangolo è: {areaTriangolo}");
        break;
    default:
        Console.WriteLine("Figura non riconosciuta. Riprova con quadrato, cerchio o triangolo.");
        break;
}

// 3. 
Console.WriteLine("Scegli un'opzione:");
Console.WriteLine("1 - Controlla se un numero è pari o dispari");
Console.WriteLine("2 - Controlla se un numero è maggiore di 10");

int scelta = int.Parse(Console.ReadLine()!);

switch (scelta)
{
    case 1:
        Console.Write("Inserisci un numero: ");
        int numero1 = int.Parse(Console.ReadLine()!);

        if (numero1 % 2 == 0)
            Console.WriteLine("Il numero è pari");
        else
            Console.WriteLine("Il numero è dispari");
        break;
    case 2:
        Console.Write("Inserisci un numero: ");
        int numero2 = int.Parse(Console.ReadLine()!);
        if (numero2 > 10)
            Console.WriteLine("Il numero è maggiore di 10");
        else
            Console.WriteLine("Il numero è minore o uguale a 10");
        break;
    default:
        Console.WriteLine("Scelta non valida");
        break;
}
