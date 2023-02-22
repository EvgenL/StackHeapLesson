using StackHeap;

// Точка входа
public class Program
{
    // Точка входа
    public static void Main(params string[] args)
    {
        // Как работает в С++
        CppTest();
        
        // Передача по ссылкам
        ValuesAndReferences.PassByReferenceTest();
        
        // Передача примитива в метод - он копируется
        IntRefTester.IntRefTest();
        
        // Передача класса в метод - передаётся по ссылке и меняется из метода
        ClassReferences.ClassRefTest();
        
        // Примеры сборщика мусора
        GarbageCollectionExample.GarbrageCollection();
    }

    private static void CppTest()
    {
        var ob = new MyClass();
        
        // ob.....
        
        // В С++ мы должны сами освобождать память. В C# за нас это делает сборщик мусора.
        // free(ob);
    }
}


public class MyClass
{
    public int value;
}

public struct MyStruct
{
    public int value;
}