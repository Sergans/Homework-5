using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";
            File.WriteAllText(filename, "Текущая дата и время");
        }
    }
}
