class Program
{
    static void Main()
    {
        President president = new President("John", 100000);
        Security security = new Security("Alice", 50000);
        Manager manager = new Manager("Bob", 80000);
        Engineer engineer = new Engineer("Eva", 70000);

        president.Print();
        Console.WriteLine();

        security.Print();
        Console.WriteLine();

        manager.Print();
        Console.WriteLine();

        engineer.Print();
    }
}
