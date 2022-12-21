using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparision");
            Console.WriteLine("Please Enter The X1 and Y1 Co-ordinates");
            var X1 = Convert.ToDouble(Console.ReadLine());
            var Y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter The X2 and Y2 Co-ordinates");
            var X2 = Convert.ToDouble(Console.ReadLine());
            var Y2 = Convert.ToDouble(Console.ReadLine());

            double X = Math.Pow((X2 - X1), 2);
            double Y = Math.Pow((Y2 - Y1), 2);
            double LengthOfLine = Math.Sqrt(X + Y);

            Console.WriteLine("Length Of Line is :" + LengthOfLine);
            Console.ReadLine();
        }
    }
}
