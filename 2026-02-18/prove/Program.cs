bool continua = true;
do //prima esegue il codice poi controlla se la condizione è vera
{
    Console.WriteLine("Quanti anni hai: ");
    int anni = int.Parse(Console.ReadLine()!);
    if (anni >= 18) {
        continua = false;
        Console.Clear();
        Console.WriteLine("Sei maggiorenne, arrivederci!");
        Console.WriteLine();
    } else {
        Console.Clear();
        Console.WriteLine("Non sei maggiorenne, ritenta!");
        Console.WriteLine();
    }
}
while (continua);