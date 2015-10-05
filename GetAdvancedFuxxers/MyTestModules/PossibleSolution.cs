 using System;
 using System.Collections.Generic;
 using System.IO;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

namespace BatchRenamer
{
    //NOTE: In this example code we open a directory and search for PDF files with open and closed parenthesis in the name of the file. 
    //You can check and replace any character in the name you like or just specify a whole new name using replace functions. 
    //There are other ways to work from this code to do more elaborate renames but my main intention was to show how to use File.Move to do a batch rename. 
    //This worked against 335 pdf files in 180 directories when I ran it on my laptop. 
    //This is spur of the moment code and there are more elaborate ways to do it.
    class Program
    {
        static void Main(string[] args)
        {
            var dirnames = Directory.GetDirectories(@"C:\the full directory path of files to rename goes here");

            int i = 0;

            try
            {
                foreach (var dir in dirnames)
                {
                    var fnames = Directory.GetFiles(dir, "*.pdf").Select(Path.GetFileName);

                    DirectoryInfo d = new DirectoryInfo(dir);
                    FileInfo[] finfo = d.GetFiles("*.pdf");

                    foreach (var f in fnames)
                    {

                        i++;
                        Console.WriteLine("The number of the file being renamed is: {0}", i);

                        if (!File.Exists(Path.Combine(dir, f.ToString().Replace("(", "").Replace(")", ""))))
                        {
                            File.Move(Path.Combine(dir, f), Path.Combine(dir, f.ToString().Replace("(", "").Replace(")", "")));


                        }

                        else
                        {
                            Console.WriteLine("The file you are attempting to rename already exists! The file path is {0}.", dir);
                            foreach (FileInfo fi in finfo)
                            {
                                Console.WriteLine("The file modify date is: {0} ", File.GetLastWriteTime(dir));
                            }

                        }

                    }

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}