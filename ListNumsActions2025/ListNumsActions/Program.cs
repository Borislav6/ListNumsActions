namespace ListNumsActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins": int index= int.Parse(cmd[1]);
                        int num = int.Parse(cmd[2]);
                        nums.Insert(index,num);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                    case "contains":

                        int value = int.Parse(cmd[1]);
                        Console.WriteLine(nums.Contains(value) ? "Yes" : "No");
                        break;
                        break;

                    case "add":
                        int a = int.Parse(cmd[1]);
                        int b = int.Parse(cmd[2]);
                        nums.Add(a + b);
                        break;

                    case "countl":
                        int number = int.Parse(cmd[1]);
                        int countLarger = nums.Count(n => n > number);
                        Console.WriteLine(countLarger);
                        break;

                    case "countodds":
                        int countOdds = nums.Count(n => n % 2 != 0);
                        Console.WriteLine($"CountOdds={countOdds}");
                        break;

                    case "countevens":
                        int countEvens = nums.Count(n => n % 2 == 0);
                        Console.WriteLine($"CountEvens={countEvens}");
                        break;

                    case "sumall":
                        Console.WriteLine(nums.Sum());
                        break;

                   
                    default:
                        break;
                }
            }
        }
    }
}
