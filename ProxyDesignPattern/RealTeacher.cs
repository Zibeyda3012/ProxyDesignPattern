namespace ProxyDesignPattern;

public class RealTeacher : ITeacher
{
    private string _studentName;

    public RealTeacher(string studentName)
    {
        this._studentName = studentName;
    }
    public void CheckParticipation()
    {
        Console.WriteLine("Real teacher: checking participation of " + _studentName);
    }

    public void CheckTask()
    {
        Console.WriteLine("Real teacher: checking tasks of " + _studentName);
    }

    public void GiveTask()
    {
        Console.WriteLine("Real teacher: giving tasks to " + _studentName);
    }
}
