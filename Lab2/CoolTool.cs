using System;

namespace Lab2
{
   
    public class CoolTool
    {
        private int lengthOfMatrix;
        private int[][] matrix;
        public CoolTool(int lengthOfMatrix)
        {
            this.lengthOfMatrix = lengthOfMatrix;
            matrix = Generate();
        }

        
        
            
        
        private int[][] Generate()
        {
            int[][] newMatr = new int[lengthOfMatrix][];
                            for (int i = 0; i < lengthOfMatrix; i++)
                            {
                                newMatr[i] = new int[lengthOfMatrix];
                            }
            
                            Random rand = new Random();
                            for (int i = 0; i < lengthOfMatrix; i++)
                            {
                                for (int j = 0; j < lengthOfMatrix; j++)
                                {
                                    newMatr[i][j] = rand.Next(1, 10);
                                }
                            }
                            return newMatr;
        }

        public void printMatrix()
        {
            for (int i = 0; i < lengthOfMatrix; i++)
            {
                for (int j = 0; j < lengthOfMatrix; j++)
                {
                    Console.Write($"{this.matrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
        private int[] Sort(int[] arr)
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

            return arr;
        }

        public void Sort()
        {
            for (int i = 0; i < lengthOfMatrix; i++)
            {
                matrix[i] = Sort(matrix[i]);
            }
        }
    }
}