using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Account Johns = new Account("John Doe", 200000);
         MenuOption userSelection;
        do
        {
            userSelection = ReadUserOption();
            Console.WriteLine("you have selected "+ userSelection);
            switch(userSelection)
            {
                case MenuOption.Widthraw:
                DoWidthraw(Johns);
                break;
                case MenuOption.Deposit:
                DoDeposit(Johns);
                //Console.WriteLine("Test Name...");
                break;
                case MenuOption.Print:
                DoPrint(Johns);
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
private static void DoDeposit(Account account)
{
  Console.WriteLine("Enter amount to deposit: ");
  decimal depositAmout;
  depositAmout = Convert.ToDecimal(Console.ReadLine());
  account.Deposit(depositAmout);
}
private static void DoWidthraw(Account account)
{
  Console.WriteLine("Enter amount to widthraw: ");
  decimal widthrawAmout;
  widthrawAmout = Convert.ToDecimal(Console.ReadLine());
  account.Deposit(widthrawAmout);
}
private static void DoPrint(Account account)
{
 account.Print();
}
}
    public enum MenuOption
        {
            Widthraw,
            Deposit,
            Print,
            Quit
        }
