using System.IO;
namespace FilesStream

{
   class Steams
    {
        static void Main(string[] args)
        {
            
            string path = @"C:\Nova Pasta\File1.txt";

            
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {

                string line = sr.ReadLine();
                Console.WriteLine(line);

                }


            }

            catch (IOException e)
            {  
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) { sr.Close(); }
               
            }







        }
    }
}