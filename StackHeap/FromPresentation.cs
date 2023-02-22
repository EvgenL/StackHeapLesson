static internal class FromPresentation
{
    private static void MyMethod()
    {
        // { value = 10 }; - это синтаксический сахар
        // то же самое, что и сказать:
        // valueType.value = 10;
        
        MyStruct valueType = new MyStruct() { value = 10 }; 
        MyClass referenceType = new MyClass() { value = 10 };
        PrintValues(valueType, referenceType);
        
        // Обычно прибавляем - всё работает
        valueType.value += 10;
        referenceType.value += 10;
        PrintValues(valueType, referenceType);

        // Передаём Значимый Тип - он копируется, меняется в методе, после выхода из метода копия теряется
        Increase(valueType);
        // Передаём Ссылочный Тип - он передаётся по ссылке, изменяется после метода
        Increase(referenceType);
        PrintValues(valueType, referenceType);

        // Передаём Значимый Тип через ref - он передаётся по ссылке 
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

    private static void ModifyByReference(ref MyStruct valueType)
    {
        valueType.value = 42;
    }

    // overload (перегрузка). Когда у метода одинаковое название, но разные параметры.
    private static void Increase(MyStruct valueType)
    {
        valueType.value += 10;
    }

    // overload (перегрузка). Когда у метода одинаковое название, но разные параметры.
    private static void Increase(MyClass referenceType)
    {
        referenceType.value += 10;
    }

    private static void ModifyInInt(in int number)
    {
        // number = 1;
    }

    private static void PrintValues(MyStruct valueType, MyClass referenceType)
    {
        Console.WriteLine("valueType: " + valueType.value);
        Console.WriteLine("referenceType: " + referenceType.value);
        Console.WriteLine();
    }
}