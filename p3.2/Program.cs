class Worker
{
    private string Name { get; set; }
    private string Surname { get; set; }
    private double Rate { get; set; }
    private int Days { get; set; }
    public Worker(string name, string surname, double rate, int days)
    {
        Name = name;
        Surname = surname;
        Rate = rate;
        Days = days;
    }
    public string GetName()
    {
        return Name;
    }
    public string GetSurname()
    {
        return Surname;
    }
    public double GetRate()
    {
        return Rate;
    }
    public int GetDays()
    {
        return Days;
    }

    public double Salary()
    {
        return Rate * Days;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("имя работника: ");
        string name = Console.ReadLine();
        Console.WriteLine("фамилия работника: ");
        string surname = Console.ReadLine();
        Console.WriteLine("ставка за день работы: ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("количество отработанных дней:");
        int days = Convert.ToInt32(Console.ReadLine());
        Worker worker = new Worker(name, surname, rate, days);
        Console.WriteLine($"\nзарплата работника {worker.GetName()} {worker.GetSurname()} составляет: {worker.Salary()}");
    }
}