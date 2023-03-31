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
    private string _readableStatus;
    private string _accountType;
    private ExpenseMovement _newExpense;
    private DepositMovement _newDeposit;

    public Account(){}
    public Account(double balance, int number,string cutoffdate, string owner, string description, string bank)
    {
        SetBalance(balance);
        SetAccountNumber(number);
        SetCutOffDate(cutoffdate);
        SetAccountOwner(owner);
        SetDescription(description);
        SetBank(bank);
        SetInitialBalance(balance);
        SetStatus(true);
    }
    //Getters and Setters
    public bool GetStatus(){return _status;}
    public double GetBalance(){return _balance;}
    public double GetInitialBalance(){return _initialBalance;}
    public int GetAccountNumber(){return _accountNumber;}
    public string GetCutOffDate(){return _cutOffDate;}
    public string GetAccountOwner(){return _accountOwner;}
    public string GetDescription(){return _description;}
    public string GetBank(){return _bank;}
    public string GetAType(){return _accountType;}
    public string GetReadeableStatus(){return _readableStatus;}
    public void SetStatus(bool status){_status = status;}
    public void SetBalance(double balance){_balance = balance;}
    public void SetInitialBalance(double initbalance){_initialBalance = initbalance;}
    public void SetAccountNumber(int accountnumber){_accountNumber = accountnumber;}
    public void SetCutOffDate(string cutoff){_cutOffDate = cutoff;}
    public void SetAccountOwner(string accountnowner){_accountOwner = accountnowner;}
    public void SetDescription(string description){_description = description;}
    public void SetBank(string bank){_bank = bank;}
    public void SetType(string type){_accountType = type;}
    public void SetReadeableStatus(string status){_readableStatus = status;}

    //Methods for Accounts

    //Public Methods
    public abstract void AccountSummary();
    public abstract void GetBalanceSummary();
    public abstract void AddExpense(double amount, string date, string name, string description,string company);
    public abstract void AddDeposit(double amount, string date, string name, string description,string origin);
    
    public void GetMovementsSummary() // Get total list of movements
    {
        FuseMovements();
        foreach(Movement movement in _listOfMovements){movement.MovementSummary();}
    }
    public double GetTotalIncome()//calculate the total income of deposits
    {
        double _totalIncome = 0;
        foreach(DepositMovement deposit in _listOfDeposits){_totalIncome = _totalIncome + deposit.GetMovementAmount();}
        return _totalIncome;
    }
    public double GetTotalOutcome() // calculate the total outcome from expenses
    {
        double _totalOutcome = 0;
        foreach(ExpenseMovement expense in _listOfExpenses){_totalOutcome = _totalOutcome + expense.GetMovementAmount();}
        return _totalOutcome;
    }
    public void FuseMovements() //Fuse expenses and deposits to list all the movements
    {
        _listOfMovements.Clear();
        foreach (DepositMovement deposit in _listOfDeposits){_listOfMovements.Add(deposit);}
        foreach (ExpenseMovement expense in _listOfExpenses){_listOfMovements.Add(expense);}
    }
    public int CountOfDeposits(){return _listOfDeposits.Count();}
    public int CountOfExpenses(){return _listOfExpenses.Count();}

    //Managing Adding expenses and deposits
    public void SetNewExpense(double amount, string date, string name, string description,string company)
    {
        _newExpense = new ExpenseMovement(amount,date,name,description,company);
        _listOfExpenses.Add(_newExpense);
    }
    public void SetNewDeposit(double amount, string date, string name, string description,string origin)
    {
        _newDeposit = new DepositMovement(amount,date,name,description,origin);
        _listOfDeposits.Add(_newDeposit);

    }


}