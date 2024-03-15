class MyClass
{
    public int property1;
    public string property2;
    public MyClass(int value1 = 0, string value2 = "Default")
    {
        property1 = value1;
        property2 = value2;
    }

    public void conclusion()
    {
        Console.WriteLine($"свойство 1: {property1}");
        Console.WriteLine($"свойство 2: {property2}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("введите значение для свойства 1(число): ");
        int value1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите значение для свойства 2(число): ");
        string value2 = Console.ReadLine();
        MyClass obj1 = new MyClass(value1, value2);
        MyClass obj2 = new MyClass();
        Console.WriteLine("объект 1: ");
        obj1.conclusion();
        Console.WriteLine("\nобъект 2: ");
        obj2.conclusion();
    }
}
