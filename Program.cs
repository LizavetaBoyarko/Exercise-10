using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Corner corner = new Corner();
            Console.WriteLine("Введите количество градусов угла");
            corner.grade = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество минут угла");
            corner.min = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество секунд угла");
            corner.sec = double.Parse(Console.ReadLine());
            

            corner.Radians();
            Console.ReadLine();

           
        }
    }
    class Corner
    {
        public double grade;
        public double min;
        public double sec;

        public void Radians() 
        {
            var radians = (grade + min / 60 + sec / 3600) * (Math.PI) / 180;
            if (radians < 0)
                radians = -radians;

            Console.WriteLine(radians);
        }
    }
}
