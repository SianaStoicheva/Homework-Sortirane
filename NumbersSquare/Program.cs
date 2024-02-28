namespace NumbersSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi spisuk:");
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            List<int> squareNumbers = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                double sqrt = Math.Sqrt(numbers[i]);
                if (sqrt == (int)sqrt)
                {
                    squareNumbers.Add(numbers[i]);
                }
            }
            for (int i = 0; i < squareNumbers.Count; i++)
            {
                for (int j = i + 1; j < squareNumbers.Count; j++)
                {
                    if (squareNumbers[i] < squareNumbers[j])
                    {
                        int temp = squareNumbers[i];
                        squareNumbers[i] = squareNumbers[j];
                        squareNumbers[j] = temp;
                    }
                }
            }
            Console.WriteLine("Izhod:");
            foreach (int square in squareNumbers)
            {
                Console.Write($"{square} ");
            }
        }
    }
}
