namespace Lab2
{
    public static int[] Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int el = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = el;
                    }
                }
            }

            foreach (var elem in arr)
            {
                Console.Write($"{elem}\t");
            }
            return arr;
        }
}