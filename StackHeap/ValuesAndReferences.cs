static internal class ValuesAndReferences
{
    public static void PassByReferenceTest()
    {
        int a = 0;
        int b = 0;
        int c = 0;


        IncreaseByRef(ref a);
        IncreaseByOut(out b);
        PassByIn(in c);

        Console.WriteLine("A = " + a);
        Console.WriteLine("B = " + b);
        Console.WriteLine("C = " + c);
    }

    // ref: Изменение переменной внутри метода, изменит её вне метода. 
    // До передачи в метод, нужно инициализировать пер.
    private static void IncreaseByRef(ref int valueToChange)
    {
        valueToChange += 42;
    }

    // out: Изменение переменной внутри метода, изменит её вне метода. 
    // В методе нужно инициализировать пер.
    private static void IncreaseByOut(out int valueToInitialize)
    {
        valueToInitialize = 0;
        valueToInitialize += 42;
    }

    // in: Изменение переменной внутри метода запрещено. 
    // До метода нужно инициализировать пер.
    private static void PassByIn(in int valueToInitialize)
    {
        // valueToInitialize = 0;
    }
}