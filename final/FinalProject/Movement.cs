using System;

class Movement
{
    private double _movementAmount;
    private string _movementDate;
    private string _movementName;
    private string _movementDescription;
    
    public Movement(){}
    public Movement(double amount, string date, string name, string description)
    {
        SetMovementAmount(amount);
        SetMovementDate(date);
        SetMovementName(name);
        SetMovementDescription(description);
    }

    //Getters and Setters
    public double GetMovementAmount(){return _movementAmount;}
    public string GetMovementDate(){return _movementDate;}
    public string GetMovementName(){return _movementName;}
    public string GetMovementDescription(){return _movementDescription;}
    public void SetMovementAmount(double mAmount){_movementAmount = mAmount;}
    public void SetMovementDate(string date){_movementDate = date;}
    public void SetMovementName(string name){_movementName = name;}
    public void SetMovementDescription(string description){_movementDescription = description;}

    public void MovementSummary()
    {
        Console.WriteLine($"{_movementDate} - {_movementName} for {_movementAmount}\n {_movementDescription}");
    }

    


}