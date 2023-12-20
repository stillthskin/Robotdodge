using System;
using SplashKitSDK;

public class widthrawTransactions{
 Account _account;
 decimal _amount;
 bool _reversed = false;
 private bool _excecuted = false;
private bool _success = false;

 public widthrawTransactions(Account account, decimal amount){
     _account = account;
     _amount = amount;
 }
   public bool Excecuted
    {
        get { 
            return _excecuted; 
            }
    }
    public bool Success
    {
        get { 
            return _success; 
            }
    }
    public bool Reversed
    {
        get { 
            return _reversed; 
            }
    }
    public void Execute()
    {
        if ( _excecuted )
        {
            throw new Exception("Cannot execute this transaction as it has already been");
        }
        _excecuted = true;
        _success = _account.Widthraw(_amount);
        }
    public void Rollback()
    {
        while(!_excecuted){
            if(! _excecuted){
                throw new Exception("Cannot execute this transaction as it has already been excecuted");
            }
            if(_reversed){
                throw new Exception("Transaction alredy reversed");
            }
            _reversed = true;
            _success = _account.Deposit(_amount);
        }

    }
    public void Print()
    {
        if(_success){
            Console.WriteLine("The transaction was succesful");
        }

    }
}