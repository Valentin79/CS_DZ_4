namespace CS_DZ_Sem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int target = 13;
            int startIndex = 0;
            int resultCount = 0;
            while (startIndex < arr.Length)
            {
                List<int> result = DZ.FindThreeNumbers(arr, target, startIndex);
                if (result.Count > 0)
                {
                    Console.WriteLine($"{result[0]} + {result[1]} + {result[2]} = {target}");
                    startIndex++;
                    resultCount++;
                }
                else { startIndex++; }
            }
            if (resultCount == 0) { Console.WriteLine("Результатов не найдено"); }
        }
    }
}