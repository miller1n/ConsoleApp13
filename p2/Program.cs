class Program
{
    static void Combinations(int[] candidates, int target, int start, List<int> current, List<List<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(current)); 
            return;
        }

        for (int i = start; i < candidates.Length; ++i)
        {
            if (candidates[i] > target)
            {
                break;
            }

            if (i > start && candidates[i] == candidates[i - 1]) 
            {
                continue;
            }

            current.Add(candidates[i]);
            Combinations(candidates, target - candidates[i], i + 1, current, result);
            current.RemoveAt(current.Count - 1); 
        }
    }
    static void Main(string[] args)
    {
        int[] candidates = new int[] { 13, 3, 8, 1, 20, 33, 15 };

        Console.WriteLine("введите taget (цель)");
        int target = Convert.ToInt32(Console.ReadLine());

        List<List<int>> result = new List<List<int>>();
        Array.Sort(candidates);

        List<int> current = new List<int>();
        Combinations(candidates, target, 0, current, result);

        Console.WriteLine("уникальные комбинации чисел, сумма которых равна цели:");

        foreach (var combination in result)
        {
            Console.WriteLine(string.Join(" ", combination));
        }
    }
}