using System.Numerics;

class Program
{
    public static void Main(string[] args)
    {
        //ExerciseOne();
        //ExerciseTwo();
        //ExerciseThree();
        //ExerciseFour();
        //ExerciseFive();
        ExerciseSix();
    }

    public static void ExerciseOne()
    {
        int qnt;

        do {
            Console.Clear();
            Console.Write("Quanti numeri vuoi inserire?: ");
        } while(!int.TryParse(Console.ReadLine()!, out qnt));

        int[] vector = new int[qnt];
        int temp;

        for (int i = 0 ; i < vector.Length; i++)
        {
            do {
            Console.Clear();
            Console.Write($"Inserisci il {i + 1}° numero: ");
            } while(!int.TryParse(Console.ReadLine()!, out temp));
            vector[i] = temp;
        }

        int sum = 0;
        foreach (int i in vector) { sum += i; }
        Console.WriteLine($"La somma totale è: { sum }");
        Console.Write("\nPremi un qualsiasi tasto per continuare!");
        Console.ReadKey();
        Console.Clear();
    }

    public static void ExerciseTwo()
    {   
        Console.WriteLine($"Premi un qualsiasi tasto per generare 10 numeri casuali (tra 0 e 100).");
        Console.ReadKey();
        Random random = new();
        int[] vector = new int[10];

        for (int i = 0; i < vector.Length; i++)
        {
            vector[i] = random.Next(1, 101);
        }

        int min = vector[0];
        int max = vector[0];

        foreach (int n in vector)
        {
            if (n < min) min = n;
            else if (n > max) max = n;
        }

        
        Console.WriteLine($"\nNumeri generati: {string.Join(", ", vector)}");
        Console.WriteLine($"Min: {min}\nMax: {max}");
        Console.Write("\nPremi un qualsiasi tasto per continuare!");
        Console.ReadKey();
        Console.Clear();
    }

    public static void ExerciseThree()
    {     
        int qnt;

        do {
            Console.Clear();
            Console.Write("Quanti numeri vuoi inserire?: ");
        } while(!int.TryParse(Console.ReadLine()!, out qnt));

        int[] vector = new int[qnt];
        int[] inverseVector = new int[qnt];
        int temp;

        for (int i = 0; i < vector.Length; i++)
        {
            do {
            Console.Clear();
            Console.Write($"Inserisci il {i + 1}° numero: ");
            } while(!int.TryParse(Console.ReadLine()!, out temp));
            vector[i] = temp;
        }

        for (int i = 0; i < vector.Length; i++)
        {
            inverseVector[inverseVector.Length - 1 - i] = vector[i];
        }

        int numToFind;
        int idxPos;
        
        do {
            Console.Clear();
            Console.Write($"Inserisci il numero da cercare: ");
            } while(!int.TryParse(Console.ReadLine()!, out numToFind));

        idxPos = vector.IndexOf(numToFind);

        if (idxPos != -1) Console.WriteLine($"Numero trovato all'indice: {idxPos}");
        else Console.WriteLine($"Numero non trovato.");

        Console.WriteLine($"\nArray originale: {string.Join(", ", vector)}");
        Console.WriteLine($"Array invertito: {string.Join(", ", inverseVector)}");
        Console.Write("\nPremi un qualsiasi tasto per continuare!");
        Console.ReadKey();
        Console.Clear();
    }

    public static void ExerciseFour()
    {
        int righe;
        int colonne;
        int[,] matrix;

        do
        {
            Console.Clear();
            Console.Write("Inserisci il numero di righe: ");  
        } while (!int.TryParse(Console.ReadLine()!, out righe));

        do
        {
            Console.Clear();
            Console.Write("Inserisci il numero di colonne: ");  
        } while (!int.TryParse(Console.ReadLine()!, out colonne));

        matrix = new int[righe, colonne];

        // Inserimento
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int temp;
                
                do
                {
                    Console.Clear();
                    Console.Write($"Inserisci il {i + 1}° numero della {j + 1}° colonna: "); 
                } while (!int.TryParse(Console.ReadLine()!, out temp));

                matrix[i, j] = temp;
            }
        }

        int sommaTotale = 0;

        // Calcolo la somma delle righe e il totale generale
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int sommaRiga = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sommaRiga += matrix[i, j];
                sommaTotale += matrix[i, j]; // Accumulo anche per il totale
            }
            Console.WriteLine($"Somma della riga {i + 1}: {sommaRiga}");
        }

        // Calcolo somma colonne
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int sommaColonna = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sommaColonna += matrix[i, j];
            }
            Console.WriteLine($"Somma della colonna {j + 1}: {sommaColonna}");
        }

        // 3. Stampa totale generale
        Console.WriteLine($"\nSomma totale di tutti gli elementi: {sommaTotale}");
        Console.Write("\nPremi un qualsiasi tasto per continuare!");
        Console.ReadKey();
        Console.Clear();
    }

    public static void ExerciseFive()
    {
        Random random = new();
        int[,] matrix1 = new int[4,4];
        int[,] matrix2 = new int[4,4];
        int[] matrix1SommaRighe = new int[matrix1.GetLength(0)];
        int[] matrix2SommaRighe = new int[matrix1.GetLength(0)];

        // Uso uno per tutti e due (le dimensioni sono identiche)
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                matrix1[i,j] = random.Next(1, 51);
                matrix2[i,j] = random.Next(1, 51);
            }
        }

        // Stampa tabella 1° matrice
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            Console.WriteLine("---------------------");
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                matrix1SommaRighe[i] += matrix1[i, j];
                Console.Write($"| {matrix1[i, j], 2} ");
            }  
            Console.WriteLine("|");
        }
        Console.WriteLine("---------------------");
        
        Console.WriteLine();

        // Stampa tabella 2° matrice
        for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            Console.WriteLine("---------------------");
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                matrix2SommaRighe[i] += matrix2[i, j];
                Console.Write($"| {matrix2[i, j], 2} ");
            }  
            Console.WriteLine("|");
        }
        Console.WriteLine("---------------------");

        int punteggioMatrix1 = 0;
        int punteggioMatrix2 = 0;

        Console.WriteLine("\nRisultati");
        // Uso uno per tutti e due (le dimensioni sono identiche)
        for (int i = 0; i < matrix1SommaRighe.Length; i++)
        {   
            Console.Write($"Riga {i + 1}. Matrice 1: {matrix1SommaRighe[i]} vs Matrice 2: {matrix2SommaRighe[i]} -> ");
            if (matrix1SommaRighe[i] > matrix2SommaRighe[i])
            {
                punteggioMatrix1++; 
                Console.WriteLine("Vince matrice 1!");
            } else {
                punteggioMatrix2++; 
                Console.WriteLine("Vince matrice 2!");
            }
        }

        Console.WriteLine($"Vincitore assoluto: {(punteggioMatrix1 > punteggioMatrix2 ? "Matrice 1" : "Matrice 2")}");
        Console.Write("\nPremi un qualsiasi tasto per continuare!");
        Console.ReadKey();
        Console.Clear();
    }

    public static void ExerciseSix()
    {
        Console.WriteLine($"Premi un qualsiasi tasto per generare matrice 5x5 con numeri casuali (tra 1 e 20).");
        Console.ReadKey();
        Console.WriteLine();
        Random random = new();
        int[,] matrix = new int[5,5];

        // Uso uno per tutti e due (le dimensioni sono identiche)
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = random.Next(1, 21);
            }
        }

        int diagMain = 0;
        int diagSec = 0;

        // Stampa matrice + calcolo diagonale principale
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.WriteLine("--------------------------");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                // Sommo la diagonale principale (i == j)
                if (j == i) diagMain += matrix[i,j];

                // 2. Sommo la diagonale secondaria
                if (j == matrix.GetLength(0) - 1 - i) diagSec += matrix[i, j];

                Console.Write($"| {matrix[i,j], 2} ");
            }
            Console.WriteLine("|");
        }
        Console.WriteLine("--------------------------");

        // Calcolo diagonale secondaria
        for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
        {
            for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
            {
                if (j == i) diagSec += matrix[i,j]; 
            }
        }

        Console.WriteLine($"\nRisultati\nDiagonale principale (totale): {diagMain}\nDiagonale secondaria (totale): {diagSec}\n");
        Console.WriteLine($"Maggiore: {(diagMain > diagSec ? "Diagonale principale" : "Diagonale secondaria")}");
        Console.Write("\nPremi un qualsiasi tasto per continuare!");
        Console.ReadKey();
        Console.Clear();
    }
}