namespace HomeTask_search_for_numbers_with_divider_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Home task!");
            Console.WriteLine("amount of numbers");
            int amount = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>(amount);
            Console.WriteLine("put the nambers");
            for (int i = 0; i < amount; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                list.Add(number);
            }
        }
    }
}
