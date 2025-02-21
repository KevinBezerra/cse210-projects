using System;

class Program
{
    static void Main(string[] args)
    {
        Activity running = new Running(3.0, 30);
        Activity cycling = new Cycling(20.0, 45);
        Activity swimming = new Swimming(40, 30);

        Console.WriteLine(running.GetSummary());
        Console.WriteLine(cycling.GetSummary());
        Console.WriteLine(swimming.GetSummary());
    }
}