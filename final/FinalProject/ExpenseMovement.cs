using System;

class ExpenseMovement : Movement
{
    private string _expenseCompany;
    public ExpenseMovement(){}
    public ExpenseMovement(double amount, string date, string name, string description,int id,string company):base(amount,date,name,description,id)
    {
        SetMovementAmount(amount);
        SetMovementDate(date);
        SetMovementName(name);
        SetMovementDescription(description);
        SetExpenseCompany(company);
        SetMovementType("Expense");
        SetAccountID(id);
    }
    public void SetExpenseCompany(string company){_expenseCompany = company;}
    public string GetExpenseCompany(){return _expenseCompany;}
    public override string GenerateSaveString()
    {
        SetSaveString($"{GetMovementType()}*{GetMovementAmount()}*{GetMovementDate()}*{GetMovementName()}*{GetMovementDescription()}*{GetExpenseCompany()}*{GetAccountID()}*");
        return GetSaveString();
    }

}