using System;

class DepositMovement:Movement
{
    private string _depositOrigin;
    public DepositMovement(){}
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
    public void SetOrigin(string origin){_depositOrigin = origin;}
    public string GetOrigin(){return _depositOrigin;}
    public override string GenerateSaveString()
    {
        SetSaveString($"{GetMovementType()}*{GetMovementAmount()}*{GetMovementDate()}*{GetMovementName()}*{GetMovementDescription()}*{GetOrigin()}*{GetAccountID()}*");
        return GetSaveString();
    }

}