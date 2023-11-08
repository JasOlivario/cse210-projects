public class MathAssignment : Assignment
{
    private double _section;
    private string _problems;

    public MathAssignment(string studentName, string topic, double section, string problems) : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{GetSummary()} \n Section: {_section} Problems: {_problems}";
    }
}