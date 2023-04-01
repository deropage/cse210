using System;

public abstract class Movement
{
    private double _movementAmount;
    private string _movementDate;
    private string _movementName;
    private string _movementDescription;
    private string _movementType;
    private int _accountID;
    private string _saveString;
    
    public Movement(){}
    public Movement(double amount, string date, string name, string description, int accountID)
    {
        SetMovementAmount(amount);
        SetMovementDate(date);
        SetMovementName(name);
        SetMovementDescription(description);
        SetAccountID(accountID);
    }

    public void MovementSummary()
    {
        Console.WriteLine($"{_movementDate} - {_movementName} for {_movementAmount}\n {_movementDescription}");
    }
    public abstract string GenerateSaveString();

    //Getters and Setters
    public double GetMovementAmount(){return _movementAmount;}
    public string GetMovementDate(){return _movementDate;}
    public string GetMovementName(){return _movementName;}
    public string GetMovementDescription(){return _movementDescription;}
    public string GetMovementType(){return _movementType;}
    public int GetAccountID(){return _accountID;}
    public string GetSaveString(){return _saveString;}
    public void SetMovementAmount(double mAmount){_movementAmount = mAmount;}
    public void SetMovementDate(string date){_movementDate = date;}
    public void SetMovementName(string name){_movementName = name;}
    public void SetMovementDescription(string description){_movementDescription = description;}
    public void SetMovementType(string type){_movementType = type;}
    public void SetAccountID(int ID){_accountID = ID;}
    public void SetSaveString(string newdata){_saveString = newdata;}



}