using System;

public abstract class Goal
{
    private string _nameOfGoal;
    private string _description;
    private int _pointsToEarn;
    private bool _statusOfGoal;
    private string _statusOfGoalPrint;
    private int _typeOfGoal;
    
    public Goal(){}
    public Goal(string nameOfGoal, string description, int pointsToEarn)
    {
        SetNameOfGoal(nameOfGoal);
        SetDescription(description);
        SetPointsToEarn(pointsToEarn);

    }

    public void SetNameOfGoal(string name)
    {
        _nameOfGoal = name;
    }
    public string GetNameOfGoal()
    {
        return _nameOfGoal;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDescription()
    {
        return _description;
    }

    public void SetPointsToEarn(int points)
    {
        _pointsToEarn = points;
    }
    public int GetPointsToEarn()
    {
        return _pointsToEarn;
    }
    public void SetStatusOfGoal(bool status)
    {
        _statusOfGoal = status;

    }
    public bool GetStatusOfGoal()
    {
        return _statusOfGoal;
    }
    public void SetStatusOfGoalPrint(string status)
    {
        _statusOfGoalPrint = status;

    }
    public string GetStatusOfGoalPrint()
    {
        return _statusOfGoalPrint;
    }

    public abstract void ShowGoal();

}