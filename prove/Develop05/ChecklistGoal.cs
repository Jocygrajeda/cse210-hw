using System;



public class ChecklistGoal : Goal 
{
    //tracks the number of finished tasks
    protected int  _amountCompleted;

    //the target of finished tasks 
    private int _target;

    //bonus if they finished the amount of times the user put
    private int _bonus;

    public ChecklistGoal(string name, string description, string points,int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    //check for goal completion
    public override void RecordEvent()
    {
       _amountCompleted++;

       if (_target == _amountCompleted)
       {
        //receiving the bonus if completed ?/?
        int totalPoints = GetPoints() + _bonus;
        SetPoints(totalPoints);
       }
       
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
           
            return true;
        
        } else

        {

        return false;
        }
    }

    public override string GetStringRepresentation()
    {
        string representation = $"ChecklistGoal:{base.GetName()},{base.GetDescription()},{base.GetPoints()},{_bonus},{_target},{_amountCompleted}";

        return representation;
    }

    // Returns a string with details about the ChecklistGoal including completion status
    public override string GetDetailsString()
    {
        return ($"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}");
    }

    public void SetAmount(int amount)
    {
        _amountCompleted = amount;
    }


}