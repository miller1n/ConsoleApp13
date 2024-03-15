class Program
{
    static void Duplicate(int[] nums)
    {
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                Console.WriteLine("true");
                return;
            }
        }

        Console.WriteLine("false");
    }

    static void Main(string[] args)
    {
        int[] nums = { 1, 5, 6, 8, 8 };

        Duplicate(nums);
    }
}