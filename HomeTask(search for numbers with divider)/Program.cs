namespace HomeTask_search_for_numbers_with_divider_
{
    internal class Program
    {
        static void Main(string[] args)
        {
 fix-patch3

            Console.WriteLine("Hello, Home task!");
 main
            Console.WriteLine("amount of numbers");
            int amount = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>(amount);
            Console.WriteLine("put the nambers");
            for (int i = 0; i < amount; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                list.Add(number);
            }
 fix-patch3
            int sum = 0;
            Console.WriteLine("input divider");
            int divider = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % divider == 0)
                    sum += list[i];
            }
            Console.WriteLine("Summ is: " + sum);

 main
        }
    }
}
