namespace StackHeap;

public class GarbageCollectionExample
{
    public static void GarbrageCollection()
    {
        InternalMethod();
        
        GC.Collect();
        
        Console.WriteLine("GC.CollectionCount 0: " + GC.CollectionCount(0));
        Console.WriteLine("GC.CollectionCount 1: " + GC.CollectionCount(1));
        Console.WriteLine("GC.CollectionCount 2: " + GC.CollectionCount(2));
        Console.WriteLine("GetTotalMemory(false): " + GC.GetTotalMemory(false));
        Console.WriteLine("GetTotalMemory(true): " + GC.GetTotalMemory(true));
    }
    
    public static void InternalMethod()
    {
        var inst = new DisposableClass();
        Console.WriteLine("GetGeneration(0): " + GC.GetGeneration(inst));
        Console.WriteLine("inst created: " + inst);
    }
}

public class DisposableClass : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("I was disposed!");
    }
}