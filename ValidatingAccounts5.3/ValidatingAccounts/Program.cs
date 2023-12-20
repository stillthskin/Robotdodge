using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Account Johns = new Account("John Doe", 200000);
        Account Janes = new Account("Jane Dine", 200000);
         Bank MyBank = new Bank();
         MenuOption userSelection;
        do
        {
            userSelection = ReadUserOption();
            Console.WriteLine("you have selected "+ userSelection);
            switch(userSelection)
            {
                case MenuOption.Widthraw:
                DoWidthraw(MyBank);
                break;
                case MenuOption.Deposit:
                DoDeposit(MyBank);
                //Console.WriteLine("Test Name...");
                break;
                case MenuOption.Print:
                DoPrint(MyBank);
                break;
                case MenuOption.NewAccount:
                Console.WriteLine("Enter name: ");
                string name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Starting Balance: ");
                int startingBalance = Convert.ToInt32(Console.ReadLine());
                Account newUserAccount = new Account(name,startingBalance);
                MyBank.AddAcount(newUserAccount);
                break;
            
            }
} while (userSelection != MenuOption.Quit);
    
    }
     private static MenuOption ReadUserOption()
{
      int option;

    Console.WriteLine("Please select what task you would like to perform: 1. Deposit, *** 2. Widthraw *** 3. Print *** 4. Quit");
    do
    {
        Console.WriteLine("Chose between 1-4");
        try{
        option = Convert.ToInt32(Console.ReadLine());
        }
        catch{
            option = -1;
        }
    } 
    while (option<1 || option>3);
    return (MenuOption)(option - 1);
}
private static void DoDeposit(Bank toBank)
{
Account toAccount = FindAccount(toBank);
if (toAccount == null) return;
  Console.WriteLine("Enter amount to deposit: ");
  decimal depositAmout;
  depositAmout = Convert.ToDecimal(Console.ReadLine());
  depositAmout = Convert.ToDecimal(Console.ReadLine());
  DepositTransactions newWidthraw = new DepositTransactions(toAccount, depositAmout);
  newWidthraw.Execute();
  newWidthraw.Print();
}
private static void DoWidthraw(Bank toBank)
{
Account fromAccount = FindAccount(toBank);
if (fromAccount == null) return;
  Console.WriteLine("Enter amount to widthraw: ");
  decimal widthrawAmout;
  widthrawAmout = Convert.ToDecimal(Console.ReadLine());
  widthrawTransactions newWidthraw = new widthrawTransactions(fromAccount, widthrawAmout);
  newWidthraw.Execute();
  newWidthraw.Print();
}
private static void DoPrint(Bank toBank)
{
Account toAccount = FindAccount(toBank);
if (toAccount == null) return;
Account Johns = new Account("John Doe", 200000);
Account Janes = new Account("Jane Dine", 200000);
TransferTransactions newtransaction = new TransferTransactions(Johns,Janes, 400 );
newtransaction.Print();
}
private static Account FindAccount(Bank fromBank)
{
Console.Write("Enter account name: ");
String name = Console.ReadLine();
Account result = fromBank.GetAccount(name);
if ( result == null )
{
Console.WriteLine($"No account found with name {name}");
}
return result;
}
}
    public enum MenuOption
        {
            Widthraw,
            Deposit,
            Print,
            NewAccount,
            Quit
        }
