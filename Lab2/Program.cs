using System;
using System.IO;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManager fl = new FileManager(@"E:\Hallo.txt");
            fl.CreateFile();
            fl.WriteToFile("Hallo there!1212");

        }
    }
}