using System;

class DebitAccount:Account
{
    public DebitAccount(){}
    public DebitAccount(double balance, int number,string cutoffdate, string owner, string description, string bank):base(balance,number,cutoffdate,owner,description,bank)
    {
        SetBalance(balance);
        SetAccountNumber(number);
        SetCutOffDate(cutoffdate);
        SetAccountOwner(owner);
        SetDescription(description);
        SetBank(bank);
        SetInitialBalance(balance);
        SetStatus(true);
        SetType("Debit");
    }
    public override void AccountSummary()
    {
        if(GetStatus()){SetReadeableStatus("Active");}
        else{SetReadeableStatus("Inactive");}
        FuseMovements();
        Console.WriteLine($"Account type: {GetAType()}\nAccount Number: {GetAccountNumber()}\nBank: {GetBank()}\nCutOff Date: {GetCutOffDate()} of each Month\nStatus: {GetReadeableStatus()}");
    }
    public override void GetBalanceSummary()
    {
        Console.WriteLine($"Your Initial Balance was: {GetInitialBalance()}\nYour Current Balance is {GetBalance()}");
        Console.WriteLine($"Since you registered your account you have: {CountOfDeposits()} Deposits for ${GetTotalIncome()}");
        Console.WriteLine($"Since you registered your account you have: {CountOfExpenses()} Expenses for ${GetTotalOutcome()}");
    }
}