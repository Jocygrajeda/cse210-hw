public class ChecklistGoal : Goal
{
    private int _requiredTimes;
    private int _completedTimes;

    public int RequiredTimes
    {
        get { return _requiredTimes; }
        set { _requiredTimes = value; }
    }

    public int CompletedTimes
    {
        get { return _completedTimes; }
        set { _completedTimes = value; }
    }

    public ChecklistGoal(string name, int pointValue, int requiredTimes) : base(name, pointValue, "")
    {
        RequiredTimes = requiredTimes;
    }

    // Correct method signature
    public override void RecordProgress()
    {
        if (!IsCompleted())
        {
            _completedTimes++;
        }
    }

    public override string DisplayGoal()
    {
        return $"{base.DisplayGoal()} (Progress: {_completedTimes}/{_requiredTimes})";
    }

    public override int CalculatePoints()
    {
        if (IsCompleted())
        {
            // Add bonus points if the goal is completed
            return PointValue + PointValue;
        }
        return PointValue;
    }

    public override bool IsCompleted()
    {
        return _completedTimes >= _requiredTimes;
    }
}
