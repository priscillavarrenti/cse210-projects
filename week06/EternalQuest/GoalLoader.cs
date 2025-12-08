public static class GoalLoader
{
    public static Goal Load(string line)
    {
        string[] p=line.Split(',');

        string type = p[0];

        if (type == "SimpleGoal")
        {
            return new SimpleGoal(
                p[1], p[2], int.Parse(p[3]), bool.Parse(p[4])
            );
        }
        if (type == "EternalGoal")
        {
            return new EternalGoal(
                p[1], p[2], int.Parse(p[3])
            );
        }

        if (type == "ChecklistGoal")
        {
            return new ChecklistGoal( 
                p[1], p[2], int.Parse(p[3]),
                int.Parse(p[4]), int.Parse(p[5]), int.Parse(p[6])
            );
        }
        return null;
    }
}