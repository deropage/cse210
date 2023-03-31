using System;

class SavingAccount:Account
{
    private double _interestRate;
    private int _periodsPerYear;
    private double _monthlyDeposit;
    private double _futureEarnings;
    
    public SavingAccount(double balance, int number,string cutoffdate, string owner, string description, string bank, double interest, double monthly, int periods):base(balance,number,cutoffdate,owner,description,bank)
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
        SetType("Savings");
    }

    public double CalculateEarnings(int years)
    {
        _futureEarnings = GetBalance();
        for(int i=0; i<(years * _periodsPerYear); i++)
        {
            _futureEarnings = _futureEarnings + _monthlyDeposit + (_interestRate / _periodsPerYear * (_futureEarnings + _monthlyDeposit));
        }
        return _futureEarnings;
    }

    public override void AccountSummary()
    {
        if(GetStatus()){SetReadeableStatus("Active");}
        else{SetReadeableStatus("Inactive");}
        FuseMovements();
        Console.WriteLine($"Account type: {GetAType()}\nAccount Number: {GetAccountNumber()}\nBank: {GetBank()}\nCutOff Date: {GetCutOffDate()} of each Month\nStatus: {GetReadeableStatus()}\nInterest Rate Per Month: {GetInterestRate()}");
    }
    public override void GetBalanceSummary()
    {
        Console.WriteLine($"Your Initial Balance was: {GetInitialBalance()}\nYour Current debt is {GetBalance()}\nYour monthly interest is: {GetInterestRate()}");
        Console.WriteLine($"Since you registered your account you have: {CountOfDeposits()} Deposits for ${GetTotalIncome()}");
        Console.WriteLine($"Since you registered your account you have: {CountOfExpenses()} Expenses for ${GetTotalOutcome()}");
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