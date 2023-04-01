using System;

class ExpenseMovement : Movement
{
    private string _expenseCompany; //Variable to keep track of where the expense happened
    public ExpenseMovement(){}
    //Main constructor for expense movement
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
    //Overided method to create a string to export to a file
    public override string GenerateSaveString()
    {
        SetSaveString($"{GetMovementType()}*{GetMovementAmount()}*{GetMovementDate()}*{GetMovementName()}*{GetMovementDescription()}*{GetExpenseCompany()}*{GetAccountID()}*");
        return GetSaveString();
    }
    //Setters and Getters
    public void SetExpenseCompany(string company){_expenseCompany = company;}
    public string GetExpenseCompany(){return _expenseCompany;}


}