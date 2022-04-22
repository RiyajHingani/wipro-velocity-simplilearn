using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StudentData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student data present in the file is\n");
            string file = @"D:\studentdata.txt";
            string[] details = File.ReadAllLines(file);
            foreach (string ln in details)
            {
                Console.WriteLine(ln);
            }
            Console.ReadLine();
        }
    }
}
