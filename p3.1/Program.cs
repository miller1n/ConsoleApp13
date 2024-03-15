class Worker
{
    public string Name;
    public string Surname;
    public double Rate;
    public int Days;
    public Worker(string name, string surname, double rate, int days)
    {
        Name = name;
        Surname = surname;
        Rate = rate;
        Days = days;
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
        Console.WriteLine("количество отработанных дней: ");
        int days = Convert.ToInt32(Console.ReadLine());
        Worker worker = new Worker(name, surname, rate, days);
        Console.WriteLine($"\nзарплата работника {worker.Name} {worker.Surname} составляет: {worker.Salary()}");

    }
}
