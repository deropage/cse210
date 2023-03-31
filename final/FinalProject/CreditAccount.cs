using System;

class CreditAccount :Account
{
    private double _interestRate;
    private double _availableCredit;
    private double _totalCreditAmount;
    private double _paymentInterest;
    public CreditAccount(){}
    public CreditAccount(double balance, int number,string cutoffdate, string owner, string description, string bank, double interest, double total):base(balance,number,cutoffdate,owner,description,bank)
    {
        SetBalance(balance);
        SetAccountNumber(number);
        SetCutOffDate(cutoffdate);
        SetAccountOwner(owner);
        SetDescription(description);
        SetBank(bank);
        SetInitialBalance(balance);
        SetStatus(true);
        SetType("Credit");
        SetInterestRate(interest);
        SetTotalCredit(total);
        SetAvailableCredit(_totalCreditAmount - balance);
    }

    public double CalculateInterest()
    {
        _paymentInterest = GetBalance() * _interestRate;
        return _paymentInterest;
    }
    public override void AccountSummary()
    {
        if(GetStatus()){SetReadeableStatus("Active");}
        else{SetReadeableStatus("Inactive");}
        FuseMovements();
        Console.WriteLine($"Account type: {GetAType()}\nAccount Number: {GetAccountNumber()}\nBank: {GetBank()}\nCutOff Date: {GetCutOffDate()} of each Month\nStatus: {GetReadeableStatus()}\nInterest Rate Per Month: {GetInterestRate()}\nTotal Credit Available: {GetTotalCredit()}");
    }
    public override void GetBalanceSummary()
    {
        Console.WriteLine($"Your Initial Balance was: {GetInitialBalance()}\nYour Current debt is {GetBalance()}\nThe total Credit amount is: {GetTotalCredit()}\nYour monthly interest is: {GetInterestRate()}");
        Console.WriteLine($"Since you registered your account you have: {CountOfDeposits()} Deposits for ${GetTotalIncome()}");
        Console.WriteLine($"Since you registered your account you have: {CountOfExpenses()} Expenses for ${GetTotalOutcome()}");
    }

    //Setters Getters
    public double GetInterestRate(){return _interestRate;}
    public double GetAvailableCredit(){return _availableCredit;}
    public double GetTotalCredit(){return _totalCreditAmount;}
    public void SetInterestRate(double interest){_interestRate = interest;}
    public void SetAvailableCredit(double availableCredit){_availableCredit = availableCredit;}
    public void SetTotalCredit(double total){_totalCreditAmount = total;}

}