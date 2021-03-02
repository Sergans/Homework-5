using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "text.txt";
            File.WriteAllText(filename, Console.ReadLine());
            // С проверкой
            string text = File.ReadAllText(filename);
            Console.WriteLine(text);
            
        }
    }
}
