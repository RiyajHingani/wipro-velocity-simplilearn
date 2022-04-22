using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SortedStudentData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            Console.WriteLine(" Sorted Student data present in the file is\n");
            string file = @"D:\studentdata.txt";
            string[] details = File.ReadAllLines(file);
            Array.Sort(details);
            foreach (string ln in details)
            {
                Console.WriteLine(ln);
            }
            Console.WriteLine("\nEnter Name of student you want to Search");
            string Name = Console.ReadLine();
            
            for (int i = 0; i < details.Length; i++)
            {
                
               string[] a= details[i].Split(',');
                if(Name==a[0])
                {
                    Console.WriteLine($"Student data found at line {i+1} ");
                    m = 1;
                    break;
                }
               
            }
            if (m == 0)
            Console.WriteLine("student data not found");
         
            Console.ReadLine();
        }
    }
}
