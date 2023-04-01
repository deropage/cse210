using System;

class DepositMovement:Movement
{
    private string _depositOrigin; //Variable to keep track the origin of the deposit
    public DepositMovement(){}
    //Main constructor for deposit movement
    public DepositMovement(double amount, string date, string name, string description,int id,string origin):base(amount,date,name,description,id)
    {
        SetMovementAmount(amount);
        SetMovementDate(date);
        SetMovementName(name);
        SetMovementDescription(description);
        SetOrigin(origin);
        SetMovementType("Deposit");
        SetAccountID(id);
    }
    //Overided method to create a string to export to a file
    public override string GenerateSaveString()
    {
        SetSaveString($"{GetMovementType()}*{GetMovementAmount()}*{GetMovementDate()}*{GetMovementName()}*{GetMovementDescription()}*{GetOrigin()}*{GetAccountID()}*");
        return GetSaveString();
    }

    //Setters and Getters
    public void SetOrigin(string origin){_depositOrigin = origin;}
    public string GetOrigin(){return _depositOrigin;}

}