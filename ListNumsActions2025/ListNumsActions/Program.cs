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

                        int checkNum = int.Parse(cmd[1]);
                        if (nums.Contains(checkNum))
                            Console.WriteLine("Yes");
                        else
                            Console.WriteLine("No");
                        break;
                        

                    case "add":
                        int a = int.Parse(cmd[1]);
                        int b = int.Parse(cmd[2]);
                        nums.Add(a + b);
                        break;

             
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
