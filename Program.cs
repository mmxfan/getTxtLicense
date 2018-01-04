using System;
using System.Collections.Generic;
using System.IO;

namespace getTxtLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files;
            string line1;
            string folderPath;
            if (args.Length>0)
            {
                folderPath = args[0];
            }
            else
            {
                folderPath = @"G:\project\ENC文件加硬件锁\projects\武汉理工大学";
            }
            List<string> licenses = new List<string>();
            files =Directory.GetFiles(folderPath, "*.txt", SearchOption.AllDirectories);
            foreach (string item in files)
            {
                line1 = File.ReadAllLines(item)[0];
                licenses.Add(line1);
                Console.WriteLine(line1);
                File.WriteAllLines(Directory.GetCurrentDirectory() + @"\L1.txt", licenses);

            }
            Console.WriteLine(folderPath);
            Console.WriteLine("Press any key to continue...");
            //Console.WriteLine(Directory.GetCurrentDirectory());
            Console.ReadKey(true);
            
        }
    }
}
