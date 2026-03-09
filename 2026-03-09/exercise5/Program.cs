class Program
{
    static void Main()
    {
        List<IShape> listShape = [];
        bool flag = true;
        while (flag) {
            int scelta;
            do {
                Console.Clear();
                Console.WriteLine("Seleziona:\n1. Crea un cerchio\n2. Crea un quadrato\n3. Stampa\n4. (Esci)");
            } while (!int.TryParse(Console.ReadLine()!, out scelta) || scelta is < 1 or > 4);

            switch (scelta) {
                case >= 1 and <= 2:
                    Console.Clear();
                    if (scelta is 1) {
                        ConcreteShapeCreatorA concreteShapeCreatorA = new();
                        var shape = concreteShapeCreatorA.CreateShape("circle");
                        if (shape is null) {
                            Console.WriteLine("Errore durante l'istanza della figura desiderata.");
                        } else {
                            listShape.Add(shape);
                            Console.WriteLine("Figura creata con successo.");
                        }
                    } else if (scelta is 2) {
                        ConcreteShapeCreatorB concreteShapeCreatorB = new();
                        var shape = concreteShapeCreatorB.CreateShape("square");
                        if (shape is null) {
                            Console.WriteLine("Errore durante l'istanza della figura desiderata.");
                        } else {
                            listShape.Add(shape);
                            Console.WriteLine("Figura creata con successo.");
                        }
                    }
                    ContinueAndClear();
                    break;
                case 3:
                    Console.Clear();
                    if (listShape.Count is 0 ) {
                        Console.WriteLine("Lista figure attualmente vuota.");
                    } else {
                        Console.WriteLine(new string('-', 30));
                        foreach (var forma in listShape) { forma.Draw(); Console.WriteLine(new string('-', 30)); }
                    }
                    ContinueAndClear();
                    break;
                case 4:
                    flag = false;
                    Console.Clear();
                    Console.WriteLine("Sessione terminata.");
                    ContinueAndClear();
                    break;
            }
        }
    }

    public static void ContinueAndClear()
    {
        Console.WriteLine("\nPremere un tasto per continuare...");
        Console.ReadKey(true);
        Console.Write("\x1b[3j");
        Console.Clear();
    }
}