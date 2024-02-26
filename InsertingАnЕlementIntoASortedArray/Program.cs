namespace InsertingАnЕlementIntoASortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray1 = { 1, 2, 3, 7, 9 };
            int numToInsert1 = 4;

            int[] sortedArray2 = { 1, 2, 3, 4, 5 };
            int numToInsert2 = 0;

            sortedArray1 = InsertIntoSortedArray(sortedArray1, numToInsert1);
            sortedArray2 = InsertIntoSortedArray(sortedArray2, numToInsert2);

            Console.WriteLine("Masiv 1 sled vmukvane :");
            PrintArray(sortedArray1);
            Console.WriteLine("Masiv 2 sled vmukvane:");
            PrintArray(sortedArray2);
        }

        static int[] InsertIntoSortedArray(int[] arr, int num)
        {
           
            int index = 0;
            while (index < arr.Length && arr[index] < num)
            {
                index++;
            }

            int[] newArr = new int[arr.Length + 1];
            int i = 0;
            for (; i < index; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[i] = num;
            for (; i < arr.Length; i++)
            {
                newArr[i + 1] = arr[i];
            }

            return newArr;
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
