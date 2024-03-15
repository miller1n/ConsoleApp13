public class Program
{
    public static int translationRomanNumbers(string num)
    {
        Dictionary<char, int> romanValues = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int result = 0;

        for (int i = 0; i < num.Length; ++i)
        {
            if (i + 1 < num.Length && romanValues[num[i]] < romanValues[num[i + 1]]) //проверка возможно ли вычесть
            {
                result -= romanValues[num[i]];
            }
            else
            {
                result += romanValues[num[i]];
            }
        }

        return result;
    }

    public static void Main()
    {
        Console.WriteLine("введите римское число для преобразования в целое: ");
        string number = Console.ReadLine().ToUpper();
        int convertedNumber = translationRomanNumbers(number);
        Console.WriteLine($"результат преобразования: {convertedNumber}");
    }
}
