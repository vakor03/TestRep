using System;

namespace Lab2
{
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