namespace ProxyDesignPattern;

public class ProxyTeacher : ITeacher
{

    private RealTeacher _realTeacher;
    private string StudentName;

    public ProxyTeacher(string studentName)
    {
        this.StudentName = studentName;
    }
    public void CheckParticipation()
    {
        if (StudentName.Length > 3)
        {
            _realTeacher = new RealTeacher(StudentName);
            _realTeacher.CheckParticipation();
        }
    }

    public void CheckTask()
    {
        if (StudentName.Length > 3)
        {
            _realTeacher = new RealTeacher(StudentName);
            _realTeacher.CheckTask();
        }
    }

    public void GiveTask()
    {
        if (StudentName.Length > 3)
        {
            _realTeacher = new RealTeacher(StudentName);
            _realTeacher.GiveTask();
        }
    }
}
