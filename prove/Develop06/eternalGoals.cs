class EternalGoal : Goal {

    public EternalGoal (string name, string description, int points) : base (name, description, points) {}


    public override int RecordScore()
    {
        return Points;
    }
    
}