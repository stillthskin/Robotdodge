using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Account account = new Account("Jakes Account", 200000);
        account.Print();
        account.Deposit(100);
        account.Print();
    }
}
