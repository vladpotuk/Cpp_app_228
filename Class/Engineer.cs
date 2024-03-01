using System.Xml.Linq;

public class Engineer : Worker
{
    public Engineer(string name, int salary) : base(name, "Engineer", salary)
    {
    }

    public override void Print()
    {
        Console.WriteLine($"Name: {name}, Position: {position}, Salary: {salary}");
        Console.WriteLine("I'm the Engineer.");
    }
}
