using System;

namespace Line_Comparision
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Line Comparision ");
            double x1, y1, x2, y2, x3, y3, x4, y4;
           
            Console.WriteLine("Enter the cordinates (x1,y1) :");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the cordinates (x2,y2) :");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter the cordinates (x3,y3) :");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the cordinates (x4,y4) :");
            x4 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());
           
            double val1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double val2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));

            int compareCheck = val1.CompareTo(val2);
            Boolean equalCheck = val1.Equals(val2);
            if (compareCheck > 0)
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }
            else if (compareCheck < 0)
            {
                Console.WriteLine("Line 1 is smaller than Line 2");
            }
            else
            {
                Console.WriteLine("Line 1 is equals to Line 2");
            }
        }
    }
}