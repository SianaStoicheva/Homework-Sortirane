namespace SearchingElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi chislo:");
            int[] sortedArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine("Vuvedi chisloton koeto tursih:");
            int numToSearch = int.Parse(Console.ReadLine());

            bool found = SearchInSortedArray(sortedArray, numToSearch);

            if (found)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static bool SearchInSortedArray(int[] arr, int num)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == num)
                {
                    return true;
                }
                else if (arr[mid] < num)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return false;
        }
    }
}
