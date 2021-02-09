using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            CoolTool ct  = new CoolTool(12);
            ct.printMatrix();
            ct.Sort();
            Console.WriteLine();
            ct.printMatrix();
        }
    }
}