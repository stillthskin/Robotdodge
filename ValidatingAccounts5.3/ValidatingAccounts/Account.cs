using System;
public class Account
{
    private decimal _balance;
    private string _name;
    public readonly String  Name;
    
    public Account(string name, decimal startingBalance)
{
        _name = name;
        _balance = startingBalance;
}
     public void Print(){
        Console.WriteLine("Name is: " + _name);
        Console.WriteLine("Your account balance is: " + _balance);
    }
    public bool Deposit(decimal amountToDeposit)
    {
        if (amountToDeposit > 0)
        {
            _balance += amountToDeposit;
            return true;
        }
        return false;
        }
    public bool Widthraw(decimal amountToDeduct)
    {
        if (amountToDeduct > 0 && _balance > amountToDeduct)
        {
            _balance -= amountToDeduct;
            return true;
        }
        return false;
}
  //  public string Name
//{
//get { return _name; }
//}
    public decimal Balance
{
get { return _balance; }
}
public string GetName()
    { 
        return _name;
    }
}