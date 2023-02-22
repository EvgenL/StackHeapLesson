using StackHeap;

public class Program
{
    private int array;
    
    public static void Main(params string[] args)
    {
        // CppTest();
        PassByReferenceTest();
        // IntRefTest();
        // ClassRefTest();
        // GarbageCollectionExample.GarbrageCollection();
    }

    private static void CppTest()
    {
        var ob = new MyClass();
        
        // ob.....
        // free(ob);
    }

    private static void PassByReferenceTest()
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

    private static void IncreaseByRef(ref int valueToChange)
    {
        valueToChange += 42;
    }

    private static void IncreaseByOut(out int valueToInitialize)
    {
        valueToInitialize = 0;
        valueToInitialize += 42;
    }

    private static void PassByIn(in int valueToInitialize)
    {
        // valueToInitialize = 0;
    }

    private static void ClassRefTest()
    {
        var wallet = new Wallet();
        wallet.moneyAmount = 100;

        Console.WriteLine("I have money: " + wallet.moneyAmount);

        AddMoney(wallet);
        
        Console.WriteLine("I have money: " + wallet.moneyAmount);
    }

    private static void AddMoney(Wallet wallet)
    {
        wallet.moneyAmount += 1000000;
    }

    public class Wallet
    {
        public int moneyAmount;
    }
    
    
    
    
    
    
    

    private static void IntRefTest()
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


    private static void MyMethod()
    {
        MyStruct valueType = new MyStruct() { value = 10 };
        MyClass referenceType = new MyClass() { value = 10 };
        PrintValues(valueType, referenceType);
        
        valueType.value += 10;
        referenceType.value += 10;
        PrintValues(valueType, referenceType);

        Increase(valueType);
        Increase(referenceType);
        PrintValues(valueType, referenceType);
        
        ModifyByReference(ref valueType);
        int number = 1;
        ModifyInt(ref number);
        
        Console.WriteLine(valueType);
        Console.WriteLine(number);
    }

    private static void ModifyInt(ref int number)
    {
        number += 1;
    }


    private static void ModifyOutInt(out int number)
    {
        number = 1;
    }

    // private static void ModifyInInt(in int number)
    // {
    //     number = 1;
    // }

    private static void ModifyByReference(ref MyStruct valueType)
    {
        valueType.value = 42;
    }

    private static void Increase(MyStruct valueType)
    {
        valueType.value += 10;
    }

    // overload
    private static void Increase(MyClass referenceType)
    {
        referenceType.value += 10;
    }

    private static void PrintValues(MyStruct valueType, MyClass referenceType)
    {
        Console.WriteLine("valueType: " + valueType.value);
        Console.WriteLine("referenceType: " + referenceType.value);
        Console.WriteLine();
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