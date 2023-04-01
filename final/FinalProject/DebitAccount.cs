using System;

class DebitAccount:Account
{
    //Constructor to create a new Debit account which is the same to original constructor
    public DebitAccount(double balance, string number,string cutoffdate, string owner, string description, string bank):base(balance,number,cutoffdate,owner,description,bank)
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
    //Method to print Account summary for debit accounts
    public override void AccountSummary()
    {
        if(GetStatus()){SetReadeableStatus("Active");}
        else{SetReadeableStatus("Inactive");}
        FuseMovements();
        Console.WriteLine($"Account type: {GetAType()}\nAccount Number: {GetAccountNumber()}\nBank: {GetBank()}\nCutOff Date: {GetCutOffDate()} of each Month\nStatus: {GetReadeableStatus()}");
    }
    //Method to print Balance Summary for debit accounts
    public override void GetBalanceSummary()
    {
        Console.WriteLine($"Your Initial Balance was: {GetInitialBalance()}\nYour Current Balance is {GetBalance()}");
        Console.WriteLine($"Since you registered your account you have: {CountOfDeposits()} Deposits for ${GetTotalIncome()}");
        Console.WriteLine($"Since you registered your account you have: {CountOfExpenses()} Expenses for ${GetTotalOutcome()}");
    }
    public override void AddExpense(double amount, string date, string name, string description,int id,string company) //Add expense to the list
    {
        SetNewExpense(amount,date,name,description,id,company);
        SetBalance(GetBalance() - amount);
    }
    public override void AddDeposit(double amount, string date, string name, string description,int id, string origin) //Add Deposit to the List
    {
        SetNewDeposit(amount,date,name,description,id,origin);
        SetBalance(GetBalance() + amount);
    }
    //Generate string with account data to export to a file
    public override string GenerateSaveString()
    {
        SetSaveString($"{GetType()}*{GetAccountNumber()}*{GetBank()}*{GetCutOffDate()}*{GetDescription()}*{GetAccountOwner()}*{GetBalance()}*{GetStatus()}*");
        return GetSaveString();
    }
}