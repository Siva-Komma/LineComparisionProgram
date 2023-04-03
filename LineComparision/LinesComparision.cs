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
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            double x = 0, y = 0, length = 0;
            Console.WriteLine("Enter X1 and Y1 Cordinate Values");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X2 and Y2 Cordinate Values");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            x = Math.Pow((x2 - x1), 2);
            y = Math.Pow((y2 - y1), 2);
            length = Math.Sqrt(x + y);
            Console.WriteLine("Length of line: " + length);
        }
    }
}
