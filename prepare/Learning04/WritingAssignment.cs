public class WritingAssignment : Assignment
{
    private string _essay;


    public WritingAssignment(string studentName, string topic, string essay) : base(studentName, topic)
    {
        _essay = essay;
    }

    public string GetWritingInformation()
    {
        return $" {GetSummary()} \n {_essay} by {GetName()}";
    }
}