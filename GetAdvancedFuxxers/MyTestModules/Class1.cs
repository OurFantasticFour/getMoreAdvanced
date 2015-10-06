using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyTestModules
{
    public class Class1
    {
        public static void GetFileName() 
        {
            try
            {
                string sub = null;
                string sub2 = null;
                string subba = null;

                DirectoryInfo di = new DirectoryInfo("C:\\LAL\\DavidDocUnAnalyzed");
                FileInfo[] rgFiles = di.GetFiles();
                // List<String> filer = new List<String>();
                int i = 0;
                foreach (FileInfo f in rgFiles)
                {

                    sub = f.ToString().Substring(16, 6);
                    sub2 = f.ToString().Substring(21, 4);
                    subba = sub + "-" + sub2;
                    i++;
                    string t = ("Doc" + i + " " + subba + ".pdf");
                    File.Move(f.FullName, di.ToString() + "\\" + t);
                    Console.WriteLine("{0} har skrivits ut!", t);
                }
                
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
          
            


        }
       
    }
}
