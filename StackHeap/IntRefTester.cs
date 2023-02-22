static internal class IntRefTester
{
    public static void IntRefTest()
    {
        int a = 40;
        
        Console.WriteLine("a = " + a);

        IncreaseInt(a);
        
        Console.WriteLine("a = " + a);
    }

    private static void IncreaseInt(int aParameter)
    {
        aParameter += 10;
        Console.WriteLine("a (inside method) = " + aParameter);
    }
}