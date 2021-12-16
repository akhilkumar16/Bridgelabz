using System;

namespace dailywages
{
    class Program
    {
        static void Main(string[] args)
        {
            int emp_present = 1;
            int per_hour = 20;
            int emp_hours = 0;
            int wage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == emp_present)
            {
                emp_hours = 8;
            }
            else
            {
                emp_hours = 0;
            }
            wage = per_hour * emp_hours;
            Console.WriteLine(" employe wage : " + wage);
        }
    }
}
