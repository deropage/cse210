using System;

class EternalGoal : Goal
{
    public EternalGoal(string nameOfGoal, string description, int pointsToEarn):base(nameOfGoal, description,pointsToEarn)
    {

    }
    public override void ShowGoal()
    {
        if(GetStatusOfGoal()){SetStatusOfGoalPrint("X");}
        else{ SetStatusOfGoalPrint(" ");}
        Console.WriteLine($"[{GetStatusOfGoalPrint()}] {GetNameOfGoal()} ({GetDescription()})");
    }

    public override void RecordEvent()
    {
    }
    
}