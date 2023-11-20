using System;

public class SimpleGoal : Goal 
{

     // boolean to track whether the simple goal is complete or not
    private bool _IsComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)// constructor
    {
        _IsComplete = false;
    }

    public override void RecordEvent()
    {
        _IsComplete = true; //mark simple goal as complete when recording an event
    }

    public override bool IsComplete()
    {
        return _IsComplete;// check if is complete
    }

    public override string GetStringRepresentation()
    {
        string representation = $"SimpleGoal:{base.GetName()},{base.GetDescription()},{base.GetPoints()},{_IsComplete}";
        return representation;
    }

  
}