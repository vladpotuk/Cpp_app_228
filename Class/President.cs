using System.Xml.Linq;

public class President : Worker
{
    public President(string name, int salary) : base(name, "President", salary)
    {
    }

    public override void Print()
    {
        Console.WriteLine($"Name: {name}, Position: {position}, Salary: {salary}");
        Console.WriteLine("I'm the President!");
    }
}
