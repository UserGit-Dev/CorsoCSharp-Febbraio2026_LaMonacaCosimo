// 1.
Console.WriteLine("Inserire un voto da 1 a 10: ");
int valutazione = int.Parse(Console.ReadLine()!);

if (valutazione >= 1 && valutazione < 5) { Console.WriteLine($"{valutazione} -> Insufficiente"); }
else if (valutazione >= 5 && valutazione <= 6) { Console.WriteLine($"{valutazione} -> Sufficiente"); }
else if (valutazione >= 7 && valutazione <= 8) { Console.WriteLine($"{valutazione} -> Buono"); }
else if (valutazione >= 9 && valutazione <= 10) { Console.WriteLine($"{valutazione} -> Ottimo"); }

Console.WriteLine();

// 2.
Console.WriteLine("Inserisci altezza (double): ");
double altezza = double.Parse(Console.ReadLine()!);
Console.WriteLine("Inserisci peso: ");
double peso = double.Parse(Console.ReadLine()!);
double bmi = peso / (altezza * altezza);

if (bmi < 18.5) { Console.WriteLine($"BMI: {bmi:F2} -> Sottopeso"); }
else if (bmi < 25) { Console.WriteLine($"BMI: {bmi:F2} -> Normopeso"); }
else if (bmi < 30) { Console.WriteLine($"BMI: {bmi:F2} -> Sottopeso"); }
else if (bmi >= 30) { Console.WriteLine($"BMI: {bmi:F2} -> Obesità"); }

Console.WriteLine();

// 3.
Console.Write("Inserisci la temperatura in Celsius: ");
double celsius = double.Parse(Console.ReadLine()!);

Console.WriteLine("Scegli la scala di destinazione:");
Console.WriteLine("1 - Fahrenheit");
Console.WriteLine("2 - Kelvin");
Console.WriteLine("3 - Rankine");
Console.Write("Inserisci la tua scelta: ");
string scelta = Console.ReadLine()!;

if (scelta == "1") {
    double fahrenheit = (celsius * 9 / 5) + 32;
    Console.WriteLine($"Risultato: {celsius}°C = {fahrenheit}°F");
} else if (scelta == "2") {
    double kelvin = celsius + 273.15;
    Console.WriteLine($"Risultato: {celsius}°C = {kelvin}K");
} else if (scelta == "3") {
    double rankine = (celsius + 273.15) * 9 / 5;
    Console.WriteLine($"Risultato: {celsius}°C = {rankine}°R");
} else {
    Console.WriteLine("Errore: Scelta non valida.");
}