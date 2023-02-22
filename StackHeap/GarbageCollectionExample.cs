namespace StackHeap;

public class GarbageCollectionExample
{
    public static void GarbrageCollection()
    {
        // Принудительно собрать мусор
        GC.Collect();
        
        // Сколько раз собирали мусор в каждом из 3х поколений
        Console.WriteLine("GC.CollectionCount 0: " + GC.CollectionCount(0));
        Console.WriteLine("GC.CollectionCount 1: " + GC.CollectionCount(1));
        Console.WriteLine("GC.CollectionCount 2: " + GC.CollectionCount(2));
        
        // Сколько памяти использует приложение        
        Console.WriteLine("GetTotalMemory(true): " + GC.GetTotalMemory(true));
    }
}