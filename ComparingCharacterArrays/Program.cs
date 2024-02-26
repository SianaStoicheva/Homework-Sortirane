namespace ComparingCharacterArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            int minLength = Math.Min(arr1.Length, arr2.Length);

            for (int i = 0; i < minLength; i++)
            {
                int comparison = string.Compare(arr1[i], arr2[i], StringComparison.OrdinalIgnoreCase);
                if (comparison == 0)
                {
                    Console.Write(char.ToUpper(arr1[i][0]) + arr1[i].Substring(1) + arr2[i]);
                }
                else
                {
                    Console.Write(char.ToUpper(arr1[i][0]) + arr1[i].Substring(1) + arr2[i]);
                }
            }

            for (int i = minLength; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]);
            }

            for (int i = minLength; i < arr2.Length; i++)
            {
                Console.Write(arr2[i]);
            }
        }
    }
}