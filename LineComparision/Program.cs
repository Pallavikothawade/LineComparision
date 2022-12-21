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
            Console.WriteLine("Please Enter The X1 and Y1 co-ordinates");

            double X1 = Convert.ToDouble(Console.ReadLine());
            double Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter The X2 and Y2 co-ordinates");
            double X2 = Convert.ToDouble(Console.ReadLine());
            double Y2 = Convert.ToDouble(Console.ReadLine());
            double length1 = Math.Sqrt(Math.Pow((Y2 - Y1), 2) + Math.Pow((X2 - X1), 2));
            Console.WriteLine("Length of Line 1 is:" + length1);

            Console.WriteLine("Please Enter The X3 and Y3 co-ordinates");
            double X3 = Convert.ToDouble(Console.ReadLine());
            double Y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter The X4 and Y4 co-ordinates");
            double X4 = Convert.ToDouble(Console.ReadLine());
            double Y4 = Convert.ToDouble(Console.ReadLine());
            double length2 = Math.Sqrt(Math.Pow((Y4 - Y3), 2) + Math.Pow((X4 - X3), 2));
            Console.WriteLine("Length of Line 2 is: " + length2);

            if (length2 == length1)
                Console.WriteLine("Line 2 is equal to Line 1");
            else if (length2 > length1)
                Console.WriteLine("Line 2 is greater than Line 1");
            else
                Console.WriteLine("Line 2 is less than Line1");
            Console.ReadLine();
        }
    }
}
