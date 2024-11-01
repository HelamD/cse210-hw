class Checklist : Goal {

    private int TargetCount {get; set;}
    private int CurrentCount {get; set;}
    private int BonusPoints {get; set;}


    public Checklist( string name, string description, int points, int targetCount, int bonusPoints) : base (name, description, points)
    {
        TargetCount = targetCount;
        
        BonusPoints = bonusPoints;
    
    }

    public Checklist() {}

    public override string SaveString()
    {
        return $"{base.SaveString()},{TargetCount},{CurrentCount},{BonusPoints}";
    }

    public override void LoadParts(string[] parts)
    {
        base.LoadParts(parts);
        TargetCount = int.Parse(parts[5]);
        CurrentCount = int.Parse(parts[5]);
        BonusPoints = int.Parse(parts[5]);
    }

    public override int RecordScore()
    {
        CurrentCount ++;
        if (CurrentCount >= TargetCount)
        {
            Completed = true;
            return Points + BonusPoints;
        }
        return Points;
    }

    public override string DisplayStatus()
    {
        return $"{base.DisplayStatus()} Completed {CurrentCount}/ {TargetCount}";
    }
}