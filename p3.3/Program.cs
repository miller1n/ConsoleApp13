public class Calculation
{
    public string CalculationLine { get; set; }
    public Calculation(string calculationLine)
    {
        CalculationLine = calculationLine;
    }
    public void SetCalculationLine()
    {
        CalculationLine = Console.ReadLine();
    }
    public void SetLastSymbolCalculationLine()
    {
        char endLine = Convert.ToChar(Console.ReadLine());
        CalculationLine += endLine;
    }
    public void GetCalculationLine()
    {
        Console.WriteLine(CalculationLine);
    }
    public void GetLastSymbol()
    {
        if (!string.IsNullOrEmpty(CalculationLine))
        {
            Console.WriteLine(CalculationLine[CalculationLine.Length - 1]);
        }
    }
    public void DeleteLastSymbol()
    {
        if (!string.IsNullOrEmpty(CalculationLine))
        {
            CalculationLine = CalculationLine.Remove(CalculationLine.Length - 1);
        }
    }
}

class Program
{
    static void Main()
    {
        Calculation calculation = new Calculation("koshka");
        Console.WriteLine("исходная строка: ");
        calculation.GetCalculationLine();
        Console.WriteLine("хотите изменить строку? да/нет: ");
        string choice = Console.ReadLine();
        if (choice == "да")
        {
            Console.WriteLine("введите новую строку: ");
            calculation.SetCalculationLine();
            Console.WriteLine("ззмененная строка: ");
            calculation.GetCalculationLine();
        }
        else
        {
            return;
        }

        Console.WriteLine("введите один символ: ");
        calculation.SetLastSymbolCalculationLine();
        Console.WriteLine("строка с добавленным символом в конце: ");
        calculation.GetCalculationLine();
        calculation.DeleteLastSymbol();
        Console.WriteLine("строка с удаленным последним символом: ");
        calculation.GetCalculationLine();
        Console.WriteLine("полученный символ в конце строки: ");
        calculation.GetLastSymbol();
    }
}