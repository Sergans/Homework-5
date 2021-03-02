using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа от 0 до 255 через пробел");
            string nom = Console.ReadLine();

            string[] nomber = nom.Split(' ');
            byte[] bin = new byte[nomber.Length];

            for (int i = 0; i < nomber.Length; i++)
            {
                bin[i] = Convert.ToByte(nomber[i]);


            }
            //Сохраняем файл с созданием
            File.WriteAllBytes("binar.bin", bin);
            // С проверкой
            byte[] text = File.ReadAllBytes("binar.bin");
            foreach(byte bit in text)
            {
                Console.WriteLine(bit);
            }
        }
    }
}
