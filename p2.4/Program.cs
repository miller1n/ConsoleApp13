class counter
{
    public int value;

    public counter()
    {
        value = 0;
    }

    public counter(int num)
    {
        value = num;
    }

    public void increment()
    {
        ++value;
    }

    public void decrement()
    {
        --value;
    }
    public int Value => value;
}
class Program
{
    static void Main()
    {
        counter counter1 = new counter();
        Console.WriteLine($"счётчик 1 по умолчанию: {counter1.Value}");
        counter1.increment();
        Console.WriteLine($"счётчик 1 после увеличения: {counter1.Value}");
        counter1.decrement();
        Console.WriteLine($"счётчик 1 после уменьшения: {counter1.Value}");

        Console.Write("введите произвольное значение счетчика 2: ");
        int num = Convert.ToInt32(Console.ReadLine());
        counter counter2 = new counter(num);
        Console.WriteLine($"\nсчётчик 2 с произвольным значением: {counter2.Value}");
        counter2.increment();
        Console.WriteLine($"счётчик 2 после увеличения: {counter2.Value}");
        counter2.decrement();
        Console.WriteLine($"счётчик 2 после уменьшения: {counter2.Value}");
    }
}