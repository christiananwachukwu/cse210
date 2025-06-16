class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("16 Jun 2025", 30, 4.8),
            new Cycling("16 Jun 2025", 45, 20.0),
            new Swimming("16 Jun 2025", 30, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
