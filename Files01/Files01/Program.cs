using System;
using System.IO;

namespace workinkWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string SourcePath = @"c:\Nova Pasta\file1.txt";
            string TargetPath = @"c:\Nova Pasta\file2.txt";
            
            try
            {
                FileInfo fileInfo = new FileInfo(SourcePath);
                //fileInfo.CopyTo(TargetPath);
                string[] Lines = File.ReadAllLines(SourcePath);
                foreach (string Line in Lines)
                {
                    Console.WriteLine(Line);
                }

            }
            catch (IOException e) 
            {
                Console.WriteLine("An error ocurred \n"+e.Message);
            }      
        
        }
    }
}