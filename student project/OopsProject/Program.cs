using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OopsProject
{
    class Program
    {
        static void Main(string[] args)
        {

            List<OneClass> listoneclass = new List<OneClass>();
            List<Student> liststudent = new List<Student>();
            List<Subject> listsubject = new List<Subject>();
            
            string PathOneClass = @"D:\OopsProject\oneclass.txt";
            string PathStudent = @"D:\OopsProject\student.txt";
            string PathSubject = @"D:\OopsProject\subject.txt";

            string[] arroneclass = File.ReadAllLines(PathOneClass);
            foreach(string line in arroneclass)
            {
                string[] l = line.Split(',');
                OneClass oneclass = new OneClass();
                oneclass.Grade =Convert.ToInt32(l[0]);
                oneclass.Section = Convert.ToChar(l[1]);

                listoneclass.Add(oneclass);

            }
            string[] arrstudent = File.ReadAllLines(PathStudent);
            foreach(string line in arrstudent)
            {
                string[] l = line.Split(',');
                Student student = new Student();
                student.SName = l[0];
                student.Grade = Convert.ToInt32(l[1]);
                student.Section = Convert.ToChar(l[2]);
                liststudent.Add(student);
                
            }
            string[] arrsubject = File.ReadAllLines(PathSubject);
            foreach(string line in arrsubject)
            {
                string[] l = line.Split(',');
                Subject subject = new Subject();
                subject.SubName = l[0];
                subject.Code = l[1];
                subject.TName = l[2];
                subject.Grade= Convert.ToInt32(l[3]);
                subject.Section= Convert.ToChar(l[4]);
                listsubject.Add(subject);

            }
            foreach (var c in listoneclass)
            {
                Console.WriteLine($"class {c.Grade} {c.Section} ");
                Console.WriteLine("Students");

                foreach (var s in liststudent)
                {
                    if ((c.Grade == s.Grade) && (c.Section == s.Section))
                    {
                        Console.WriteLine($"{s.SName}");
                    }
                }
                Console.WriteLine("\nsubject:");
                foreach(var v in listsubject)
                {
                    if ((c.Grade == v.Grade) && (c.Section == v.Section))
                    {
                        Console.WriteLine($"{v.SubName} - {v.TName}");

                    }
                }
                Console.WriteLine("\n\n");
            }
            Console.ReadLine();
        }
    }
}
