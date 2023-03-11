using System;

class SimpleGoal : Goal
{
    public SimpleGoal(){}
    public SimpleGoal(string nameOfGoal, string description, int pointsToEarn):base(nameOfGoal, description, pointsToEarn)
    {

    }

    public override void ShowGoal()
    {
        if(GetStatusOfGoal()){SetStatusOfGoalPrint("X");}
        else{ SetStatusOfGoalPrint(" ");}
        Console.WriteLine($"[{GetStatusOfGoalPrint()}] {GetNameOfGoal()} ({GetDescription()})");
    }
    
}