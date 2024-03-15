class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите строку J (драгоценности): ");
        string J = Console.ReadLine();

        Console.WriteLine("введите строку S (камни)");
        string S = Console.ReadLine();

        int count = 0;
        foreach (char stone in S)
        {
            foreach (char jewel in J)
            {
                if (jewel == stone)
                {
                    count++;
                    break;
                }
            }
        }
        Console.WriteLine($"одновременно является драгоценностями: {count}");
    }
}