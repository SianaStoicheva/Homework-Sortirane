namespace SortElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":");
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            Array.Sort(numbers);

            Console.Write("Izhod: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                if (i < numbers.Length - 1)
                {
                    Console.Write(" <= ");
                }
            }
            Console.WriteLine();
        }
    }
}
