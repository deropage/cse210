using System;

class ExpenseMovement : Movement
{
    private string _expenseCompany;
    public ExpenseMovement(){}
    public ExpenseMovement(double amount, string date, string name, string description,string company):base(amount,date,name,description)
    {
        SetMovementAmount(amount);
        SetMovementDate(date);
        SetMovementName(name);
        SetMovementDescription(description);
        SetExpenseCompany(company);
    }

    public void SetExpenseCompany(string company){_expenseCompany = company;}
    public string GetExpenseCompany(){return _expenseCompany;}

}