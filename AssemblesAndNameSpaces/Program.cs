using System;
using System.IO;

namespace AssemblesAndNameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {



            // Example #2: Write one string to a text file.
            string text = "we want to write this to our file.";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllText(@"F:\WriteText.txt", text);

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
