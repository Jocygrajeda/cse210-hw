public class Goal
{
    private string _name;
    private int _pointValue;
    private string _description;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int PointValue
    {
        get { return _pointValue; }
        set { _pointValue = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public Goal(string name, int pointValue, string description)
    {
        Name = name;
        PointValue = pointValue;
        Description = description;
    }

    public virtual string DisplayGoal()
    {
        return $"Name: {Name}, Points: {PointValue}, Description: {Description}";
    }

    public virtual int CalculatePoints()
    {
        return PointValue;
    }

    // Added this method in the base class
    public virtual void RecordProgress()
    {
        // Implementation for recording progress
    }

    public virtual bool IsCompleted()
    {
        return false;
    }
}
