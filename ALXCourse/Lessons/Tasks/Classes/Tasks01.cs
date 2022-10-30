using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons.Tasks.Classes
{
    public class Tasks01
    {
        public string Author;
        public string Project = "ALX";
        public string Description = "Kurs";
        public int Version = 1;
        public bool IsRunning;

        public Tasks01(string author, bool isRunning)
        {
            Author = author;
            IsRunning = isRunning;
        }

        public void Present()
        {
            Console.WriteLine($"Author : {Author}");
            Console.WriteLine($"Project : {Project}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Version : {Version}");
            Console.WriteLine($"IsRunning : {IsRunning}");           
        }
    }
}
