using System.Reflection.PortableExecutable;

public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssignment(string section, string problems, string name, string topic) 
    : base(name, topic) 
    {
        _textbookSection = section;
        _problems  = problems;

    }

    public string GetHomeworkList()
    {
        return $"Student: {GetStudentName()}\nTopic: {GetTopic()}\nSection {_textbookSection} Problems {_problems}";
    }
}