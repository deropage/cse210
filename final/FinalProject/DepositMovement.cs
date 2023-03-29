using System;

class DepositMovement:Movement
{
    private string _depositOrigin;
    public DepositMovement(){}
    public DepositMovement(double amount, string date, string name, string description,string origin):base(amount,date,name,description)
    {
        SetMovementAmount(amount);
        SetMovementDate(date);
        SetMovementName(name);
        SetMovementDescription(description);
        SetOrigin(origin);
    }
    public void SetOrigin(string origin){_depositOrigin = origin;}
    public string GetOrigin(){return _depositOrigin;}

}