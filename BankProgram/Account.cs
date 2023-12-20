using System;
public class Account
{
    private decimal _balance;
    private string _name;
    
    public Account(string name, decimal startingBalance)
{
        _name = name;
        _balance = startingBalance;
}
     public void Print(){
        Console.WriteLine("Name is: " + _name);
        Console.WriteLine("Your account balance is: " + _balance);
    }
    public void Deposit(decimal amountToAdd)
{
    _balance = _balance + amountToAdd;
}
    public void Widthraw(decimal amountToDeduct)
{
_balance = _balance - amountToDeduct;
}
    public string Name
{
get { return _name; }
}
    public decimal Balance
{
get { return _balance; }
}
}
