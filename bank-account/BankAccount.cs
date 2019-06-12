using System;

public class BankAccount
{
    bool isOpen;
    decimal balance;

    public BankAccount()
    {
        balance = 0; isOpen = false;
    }
    public void Open()
    {
        isOpen = true;   
    }

    public void Close()
    {
        isOpen = false;
    }

    public decimal Balance
    {
        get
        {
            if(!isOpen)throw new InvalidOperationException();
            return balance;
        }
        set
        {
            balance = Balance;
        }
    }

    public void UpdateBalance(decimal change)
    {
        lock(this){balance += change;}
    }
}
