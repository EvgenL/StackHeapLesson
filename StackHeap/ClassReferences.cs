static internal class ClassReferences
{
    public static void ClassRefTest()
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
}

public class Wallet
{
    public int moneyAmount;
}