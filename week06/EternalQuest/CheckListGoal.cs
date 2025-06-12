public class ChecklistGoal : Goal
{
    private int TargetCount;
    private int CurrentCount;
    private int Bonus;

    // ✅ This is the constructor that takes target and bonus as parameters
    public ChecklistGoal(int targetCount, int bonus)
    {
        TargetCount = targetCount;
        Bonus = bonus;
        CurrentCount = 0;
        IsComplete = false;
    }

    // ✅ You still need this empty constructor for loading from file
    public ChecklistGoal() { }

    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            CurrentCount++;
            if (CurrentCount >= TargetCount)
            {
                IsComplete = true;
                Points += Bonus;
            }
        }
    }

    public override string GetStatus()
    {
        return $"[{(IsComplete ? "X" : " ")}] {Name} ({Description}) -- Completed {CurrentCount}/{TargetCount}";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{TargetCount}|{CurrentCount}|{Bonus}|{IsComplete}";
    }

    public override void Deserialize(string data)
    {
        string[] parts = data.Split('|');
        Name = parts[1];
        Description = parts[2];
        Points = int.Parse(parts[3]);
        TargetCount = int.Parse(parts[4]);
        CurrentCount = int.Parse(parts[5]);
        Bonus = int.Parse(parts[6]);
        IsComplete = bool.Parse(parts[7]);
    }
}