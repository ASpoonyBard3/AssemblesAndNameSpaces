using System;
using System.IO;
using System.Net;

namespace AssemblesAndNameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {

            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");

            // Example #2: Write one string to a text file.
            //string text = "we want to write this to our file.";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllText(@"F:\WriteText.txt", reply);


            Console.WriteLine(reply);
            Console.ReadLine();
        }
    }
}
