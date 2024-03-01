using System.Xml.Linq;

public class Security : Worker
{
    public Security(string name, int salary) : base(name, "Security", salary)
    {
    }

    public override void Print()
    {
        Console.WriteLine($"Name: {name}, Position: {position}, Salary: {salary}");
        Console.WriteLine("I'm the Security personnel.");
    }
}
