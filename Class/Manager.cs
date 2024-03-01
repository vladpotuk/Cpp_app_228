using System.Xml.Linq;

public class Manager : Worker
{
    public Manager(string name, int salary) : base(name, "Manager", salary)
    {
    }

    public override void Print()
    {
        Console.WriteLine($"Name: {name}, Position: {position}, Salary: {salary}");
        Console.WriteLine("I'm the Manager.");
    }
}
