using System;

public abstract class Account
{
    private List<DepositMovement> _listOfDeposits = new List<DepositMovement>();
    private List<ExpenseMovement> _listOfExpenses = new List<ExpenseMovement>();
    private List<Movement> _listOfMovements = new List<Movement>();
    private bool _status;
    private double _balance;
    private double _initialBalance;
    private int _accountNumber;
    private string _cutOffDate;
    private string _accountOwner;
    private string _description;
    private string _bank;


    public Account(){}
    //Getters and Setters
    public bool GetStatus(){return _status;}
    public double GetBalance(){return _balance;}
    public double GetInitialBalance(){return _initialBalance;}
    public int GetAccountNumber(){return _accountNumber;}
    public string GetCutOffDate(){return _cutOffDate;}
    public string GetAccountOwner(){return _accountOwner;}
    public string GetDescription(){return _description;}
    public string GetBank(){return _bank;}
    public void SetStatus(bool status){_status = status;}
    public void SetBalance(double balance){_balance = balance;}
    public void SetInitialBalance(double initbalance){_initialBalance = initbalance;}
    public void SetAccountNumber(int accountnumber){_accountNumber = accountnumber;}
    public void SetCutOffDate(string cutoff){_cutOffDate = cutoff;}
    public void SetAccountOwner(string accountnowner){_accountOwner = accountnowner;}
    public void SetDescription(string description){_description = description;}
    public void SetBank(string bank){_bank = bank;}
    //Methods for Accounts

    //Public Methods
    public void ApplyDesposit(double incomeBalance)
    {
        _balance = _balance + incomeBalance;
    }
    public void ApplyExpense(double outcomebalance)
    {
        _balance = _balance - outcomebalance;
    }
    public void GetBalanceSummary()
    {
        Console.WriteLine($"Your Initial Balance was: {_initialBalance}\nYour Current Balance is {_balance}");
        Console.WriteLine($"Since you registered your account you have: {_listOfDeposits.Count()} Deposits for ${GetTotalIncome()}");
        Console.WriteLine($"Since you registered your account you have: {_listOfExpenses.Count()} Expenses for ${GetTotalOutcome()}");
    }
    public void GetMovementsSummary()
    {
        FuseMovements();
        foreach(Movement movement in _listOfMovements){movement.MovementSummary();}
    }
    public void AccountSummary()
    {
        
    }

    //Local Methods
    private double GetTotalIncome()
    {
        double _totalIncome = 0;
        foreach(DepositMovement deposit in _listOfDeposits)
        {
            _totalIncome = _totalIncome + deposit.GetMovementAmount();
        }

        return _totalIncome;
    }
    private double GetTotalOutcome()
    {
        double _totalOutcome = 0;
        foreach(ExpenseMovement expense in _listOfExpenses)
        {
            _totalOutcome = _totalOutcome + expense.GetMovementAmount();
        }
        return _totalOutcome;
    }
    private void FuseMovements()
    {
        foreach (DepositMovement deposit in _listOfDeposits){_listOfMovements.Add(deposit);}
        foreach (ExpenseMovement expense in _listOfExpenses){_listOfMovements.Add(expense);}

    }

}