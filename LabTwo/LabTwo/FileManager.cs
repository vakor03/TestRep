using System;
using System.IO;

namespace LabTwo
{
    public class FileManager
    {
        private FileInfo fileInf;
        public FileManager(string path)
        {
            this.path = path;
            fileInf = new FileInfo(path);
        }

        private string path { get;}

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