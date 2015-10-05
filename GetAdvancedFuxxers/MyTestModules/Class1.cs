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
            DirectoryInfo di = new DirectoryInfo("C:\\Users\\fuujin\\Desktop\\LAL\\DavidDocUnAnalyzed");
            FileInfo[] rgFiles = di.GetFiles();
            List<String> filer = new List<String>();
            foreach (var item in rgFiles)
            {
                filer.Add(item.ToString());
            }
            foreach (var item in filer)
            {
                
                //Console.WriteLine(item);             
            }
            

            Console.WriteLine();
            Console.Read();
        }
       
    }
}
