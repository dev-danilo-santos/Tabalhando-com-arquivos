namespace usingBlocks
{
    class UsingBlocks
    {

        static void Main(string[] args)
        {
            // garante que os objetos IDisposable serão fechados

            string path = @"c:\Nova Pasta\file1.txt";

            //try
            //{

            //    using (FileStream fs = new FileStream(path, FileMode.Open))
            //    {
            //        using (StreamReader sr = new StreamReader(fs))
            //        {
            //            while (!sr.EndOfStream) { Console.WriteLine(sr.ReadLine()); ; }

            //        }

            //    }

            //}
            //catch (IOException e ) { Console.WriteLine("An error ocurred.\n"+e.Message); }

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }

            }
            catch (IOException e) { Console.WriteLine("Error"+e.Message); }


        }
    }
}