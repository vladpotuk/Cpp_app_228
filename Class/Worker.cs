using System;

public abstract class Worker
{
    protected string name;
    protected string position;
    protected int salary;

    public Worker(string name, string position, int salary)
    {
        this.name = name;
        this.position = position;
        this.salary = salary;
    }

    public abstract void Print();
}
