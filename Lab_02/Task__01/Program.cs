using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Укажіть довжину першої сторони прямокутника:");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Укажіть довжину другої сторони прямокутника:");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
            Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");

            Console.ReadLine();
        }
    }
}
