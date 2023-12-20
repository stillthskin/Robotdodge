using System;
using SplashKitSDK;

public class TransferTransactions{
Account _toAccount;
Account _fromAccount;
 decimal _amount = 0;
 bool _reversed = false;
 private bool _excecuted = false;
private bool _success = false;

 public TransferTransactions(Account fromAccount, Account toAccount, decimal amount){
     _fromAccount = fromAccount;
     _toAccount = toAccount;
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
        _success = _toAccount.Deposit(_amount);
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
            _success = _fromAccount.Widthraw(_amount);
        }

    }
    public void Print()
    {
        if(_success){
            Console.WriteLine("Transfered successfull from" + _fromAccount+" to "+_toAccount);
        }

    }
}