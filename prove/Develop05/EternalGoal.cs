using System;


//everlasting goal, its never considered complete no matter how many times its marked done
public class EternalGoal : Goal 
{
    public EternalGoal(string name, string description, string points) : base(name, description, points){}


    public override void RecordEvent()
    {
       IsComplete();
    }

    public override bool IsComplete()
    {
        return false;// always returning false since its a everlasting goal
    }

    public override string GetStringRepresentation()
    {
        string representation = $"EternalGoal:{base.GetName()},{base.GetDescription()},{base.GetPoints()}";

        return representation;
    }

    
   
}