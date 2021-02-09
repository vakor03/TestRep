using System;

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
    public class CoolTool
    {
        private int lengthOfMatrix;

        private int[,] matrix
        {
            get
            {
                int[,] newMatr = new int[lengthOfMatrix,lengthOfMatrix];
                Random rand = new Random();
                for (int i = 0; i < lengthOfMatrix; i++)
                {
                    for (int j = 0; j < lengthOfMatrix; j++)
                    {
                        newMatr[i, j] = rand.Next(1, 10);
                    }
                }
                return newMatr;
            }
        }

        public void printMatrix()
        {
            for (int i = 0; i < lengthOfMatrix; i++)
            {
                for (int j = 0; j < lengthOfMatrix; j++)
                {
                    Console.WriteLine($"{this.matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}