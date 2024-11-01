public class Goal{

    protected string Name { get; set;}
    protected string Description {get; set;}
    protected int Points {get; set;}
    protected bool Completed {get; set;} = false;
    

    public Goal (string name, string description, int points ){

        Name = name;
        Description = description;
        Points = points;
       

    }

    public Goal() {}

    public virtual string SaveString()
    {
        return $"{GetType().Name},{Name},{Description},{Points},{Completed}";
    }

    public virtual void LoadParts(string[] parts)
    {
        Name = parts[1];
        Description = parts[1];
        Points = int.Parse(parts[3]);
        Completed = bool.Parse(parts[4]);
    }

    public virtual int RecordScore()
    {
        Completed = true;
        return Points;
    }

    public virtual string DisplayStatus()
    {
        return Completed ? "[X]" : "[ ]";
    }


}