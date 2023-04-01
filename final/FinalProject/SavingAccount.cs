using System;

class SavingAccount:Account
{
    //Variable that works only with Saving account
    private double _interestRate;
    private int _periodsPerYear;
    private double _monthlyDeposit;
    private double _futureEarnings;
    //Constructor to create a new saving account
    
    public SavingAccount(double balance, string number,string cutoffdate, string owner, string description, string bank, double interest, double monthly, int periods):base(balance,number,cutoffdate,owner,description,bank)
    {
        SetBalance(balance);
        SetAccountNumber(number);
        SetCutOffDate(cutoffdate);
        SetAccountOwner(owner);
        SetDescription(description);
        SetBank(bank);
        SetInterestRate(interest);
        SetMonthlyDeposit(monthly);
        SetPeriods(periods);
        SetInitialBalance(balance);
        SetStatus(true);
        SetType("Saving");
    }
    //Method to calculate future earnings
    public double CalculateEarnings(int years)
    {
        _futureEarnings = GetBalance();
        for(int i=0; i<(years * _periodsPerYear); i++)
        {
            _futureEarnings = _futureEarnings + _monthlyDeposit + (_interestRate / _periodsPerYear * (_futureEarnings + _monthlyDeposit));
        }
        return _futureEarnings;
    }
    //Method to print Account summary for savings accounts
    public override void AccountSummary()
    {
        if(GetStatus()){SetReadeableStatus("Active");}
        else{SetReadeableStatus("Inactive");}
        FuseMovements();
        Console.WriteLine($"Account type: {GetAType()}\nAccount Number: {GetAccountNumber()}\nBank: {GetBank()}\nCutOff Date: {GetCutOffDate()} of each Month\nStatus: {GetReadeableStatus()}\nInterest Rate Per Month: {GetInterestRate()}");
    }
    //Method to print Balance Summary for savings accounts
    public override void GetBalanceSummary()
    {
        Console.WriteLine($"Your Initial Balance was: {GetInitialBalance()}\nYour Current debt is {GetBalance()}\nYour monthly interest is: {GetInterestRate()}");
        Console.WriteLine($"Since you registered your account you have: {CountOfDeposits()} Deposits for ${GetTotalIncome()}");
        Console.WriteLine($"Since you registered your account you have: {CountOfExpenses()} Expenses for ${GetTotalOutcome()}");
    }
    public override void AddExpense(double amount, string date, string name, string description,int id,string company) //Add expense to the list
    {
        SetNewExpense(amount,date,name,description,id,company);
        SetBalance(GetBalance() - amount);
    }
    public override void AddDeposit(double amount, string date, string name, string description,int id,string origin) //Add Deposit to the List
    {
        SetNewDeposit(amount,date,name,description,id,origin);
        SetBalance(GetBalance() + amount);
    }
    //Generate string with account data to export to a file
    public override string GenerateSaveString()
    {
        SetSaveString($"{GetType()}*{GetAccountNumber()}*{GetBank()}*{GetCutOffDate()}*{GetDescription()}*{GetAccountOwner()}*{GetBalance()}*{GetStatus()}*{GetInterestRate()}*{GetMonthlyDeposit()}*{GetPeriods()}*");
        return GetSaveString();
    }

    //Setters Getters
    public double GetInterestRate(){return _interestRate;}
    public double GetMonthlyDeposit(){return _monthlyDeposit;}
    public double GetFutureEarnings(){return _futureEarnings;}
    public int GetPeriods(){return _periodsPerYear;}
    public void SetInterestRate(double interest){ _interestRate = interest;}
    public void SetMonthlyDeposit(double monthly){ _monthlyDeposit = monthly;}
    public void SetFutureEarnings(double future){ _futureEarnings = future;}
    public void SetPeriods(int periods){ _periodsPerYear = periods;}

}