namespace Merge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi chislo:");
            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            SortDescending(array);
            Console.WriteLine(string.Join(" ", array));
        }

        static void SortDescending(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }
    }
}
