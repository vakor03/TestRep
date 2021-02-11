using System;
using System.IO;
using System.Text;

namespace Lab2
{
    public class FileManager
    {
        private FileInfo fileInf;

        public string path { get; }
        public FileManager(string path)
        {
            this.path = path;
            fileInf = new FileInfo(path);
            
        }

        
        
        public void CreateFile()
        {
            if (!fileInf.Exists)
            {
                File.Create(path);
            }
        }
        // public string ReadJustBecause()
        // {
        //     StreamReader sr = new StreamReader(path);
        //     string str = sr.ReadLine();
        //     sr.Close();
        //     return str;
        // }

        public void WriteToFile(string Massage)
        {
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(Massage);
            sw.Close();
        }
        
        
        public void PrintSMTH()
        {
            if (fileInf.Exists)
            {
                Console.WriteLine($"File name: {fileInf.Name}");
                Console.WriteLine($"Length: {fileInf.Length}");
            }
        }

        public void DeleteFile()
        {
            if (fileInf.Exists)
            {
                fileInf.Delete();
            }
        }
        
        public void CopyFile(string newPath)
        {
            if (fileInf.Exists)
            {
                fileInf.CopyTo(newPath);
            }
            
        }
        
        public void MoveFile(string newPath)
        {
            if (fileInf.Exists)
            {
                fileInf.MoveTo(newPath);
            }
        }
        
        
        
        
    }
}