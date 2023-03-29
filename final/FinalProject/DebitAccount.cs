using System;

class DebitAccount:Account
{
    public DebitAccount(){}
    public DebitAccount(int balance, int number,string cutoffdate, string owner, string description, string bank):base(balance,number,cutoffdate,owner,description,bank)
    {
        SetBalance(balance);
        SetAccountNumber(number);
        SetCutOffDate(cutoffdate);
        SetAccountOwner(owner);
        SetDescription(description);
        SetBank(bank);
    }

}