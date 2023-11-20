using System;

//goal is an abstract class representing a generic goal
public abstract class Goal 
{
    //private fields to store goal details
    private string _shortName;
    private string _description;
    private string _points;

    //constructor for Goal class
    public Goal(string name, string description, string points, bool health = true)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //abstract method to be implemented by derived classes for recording events
    public abstract void RecordEvent();

    //abstract method to be implemented by derived classes for checking completion status
    public abstract bool IsComplete();

    //virtual method providing a default implementation for getting a details string
    public virtual string GetDetailsString()
    {

        if (IsComplete())
        {
            return($"[x] {_shortName} ({_description})"); //mark done when completed goal
        } 
        else 
        {
            return($"[ ] {_shortName} ({_description})"); //display empty checkbox for incomplete goal
        }
    }


    public abstract string GetStringRepresentation();

    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }

    //getter method for retrieving the goal's points as an integer
    public int GetPoints()
    {
        int point = int.Parse(_points);
        return point;
    }

    //setter method for updating the goal's points
    public void SetPoints(int points)
    {
        _points = points.ToString();
    } 
}
