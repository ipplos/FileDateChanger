using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDateChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var file in Directory.GetFiles(args[0],"*.*",SearchOption.AllDirectories).ToList())
            {
                DateTime ModifiedDate = File.GetLastWriteTime(file);
                Console.WriteLine($"\t{Path.GetFileName(file)} - {ModifiedDate.ToShortDateString()+" "+ModifiedDate.ToShortTimeString()}");
                File.SetCreationTime(file, ModifiedDate);
            }

            Console.ReadKey();
            
        }
    }
}
