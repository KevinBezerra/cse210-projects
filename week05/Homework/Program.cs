using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
        MathAssignment mathAssignment = new MathAssignment("7.3","8-19","Roberto Rodriguez", "Fractions");
        WritingAssignment writingAssignment = new WritingAssignment("The Causes of World War II", "Mary Waters","European History");
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}