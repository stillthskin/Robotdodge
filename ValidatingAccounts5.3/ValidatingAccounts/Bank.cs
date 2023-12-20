using System.Collections.Generic;
using System;
using SplashKitSDK;

public class Bank
{
    public static List<Account> _account= new List<Account>();
   
    public void AddAcount(Account account)
    {
        _account.Add(account);

    }
    public Account GetAccount(string name)
    {
        for (int i = 0; i < _account.Count; i++)
        {
            if(name ==_account[i].GetName())
            {
             return _account[i];
            }
           
    }
return null;
    }
}