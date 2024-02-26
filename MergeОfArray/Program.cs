namespace MergeОfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = ReadArray();
            int[] arr2 = ReadArray();
            int[] mergedArray = MergeArrays(arr1, arr2);

            Console.WriteLine("Slqt masiv:");
            foreach (int num in mergedArray)
            {
                Console.Write(num + " ");
            }
        }
        static int[] ReadArray()
        {
            Console.WriteLine("Vuvedi podreden masiv (vuv vuzhodqsht red):");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int[] arr = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                arr[i] = int.Parse(numbers[i]);
            }
            return arr;
        }
        static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] mergedArray = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    mergedArray[k++] = arr1[i++];
                }
                else
                {
                    mergedArray[k++] = arr2[j++];
                }
            }
            while (i < arr1.Length)
            {
                mergedArray[k++] = arr1[i++];
            }
            while (j < arr2.Length)
            {
                mergedArray[k++] = arr2[j++];
            }
            return mergedArray;
        }
    }
}

