class Numbers
{
    public int Number1;
    public int Number2;

    public void OutputNumbers()
    {
        Console.WriteLine($"число 1: {Number1}");
        Console.WriteLine($"число 2: {Number2}");
    }

    public void ModifyNumbers(int newNumber1, int newNumber2)
    {
        Number1 = newNumber1;
        Number2 = newNumber2;
    }
    public int Sum()
    {
        return Number1 + Number2;
    }

    public int Max()
    {
        return Math.Max(Number1, Number2);
    }
}
class Program
{
    static void Main()
    {
        Numbers numbers = new Numbers();

        Console.WriteLine("введите число 1: ");
        numbers.Number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("введите число 2: ");
        numbers.Number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("исходные числа: ");
        numbers.OutputNumbers();
        Console.WriteLine($"сумма чисел: {numbers.Sum()}");
        Console.WriteLine($"наибольшее число: {numbers.Max()}");

        Console.WriteLine("\nвведите новые значения для чисел:");
        Console.WriteLine("введите первое число:");
        int newNumber1 = int.Parse(Console.ReadLine());
        Console.WriteLine("введите второе число:");
        int newNumber2 = int.Parse(Console.ReadLine());
        numbers.ModifyNumbers(newNumber1, newNumber2);
        Console.WriteLine($"\nизменённые числа:");
        numbers.OutputNumbers();
        Console.WriteLine($"сумма чисел: {numbers.Sum()}");
        Console.WriteLine($"наибольшее число: {numbers.Max()}");
    }
}
