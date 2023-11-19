
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int pointValue, string description) : base(name, pointValue, description)
    {
    }

    public int MarkCompleted()
    {
        // Add logic for marking the goal as completed
        // Return the points earned, or 0 if the goal is already completed
        return 0;
    }

    // Override other methods as needed
}
