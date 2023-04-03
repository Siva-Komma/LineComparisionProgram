using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    public class LinesComparision
    {
        public static void LinesLengthsComparision()
        {
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0, x3 = 0, y3 = 0, x4 = 0, y4 = 0;
            double x = 0, y = 0, length = 0, X = 0, Y = 0, length1 = 0;
            Console.WriteLine("Enter X1 and Y1 Cordinate Values");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X2 and Y2 Cordinate Values");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            x = Math.Pow((x2 - x1), 2);
            y = Math.Pow((y2 - y1), 2);
            length = Math.Sqrt(x + y);
            Console.WriteLine("Length of line1: " + length);

            Console.WriteLine("\nEnter X3 and Y3 Cordinate Values");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X4 and Y4 Cordinate Values");
            x4 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());

            x = Math.Pow((x4 - x3), 2);
            y = Math.Pow((y4 - y3), 2);
            length1 = Math.Sqrt(X + Y);
            Console.WriteLine("Length of line2: " + length1);
            if (length > length1)
            {
                Console.WriteLine("Line1 is grater: " + length);
            }
            else
            {
                Console.WriteLine("Line2 is greater: " + length1);
            }
        }
    }
}
