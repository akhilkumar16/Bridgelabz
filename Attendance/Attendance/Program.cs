using System;

namespace Attendance
{
    class Program
    {
        static void Main(string[] args)
        {
            int emp_present = 1;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if ( empcheck == emp_present)
            {
                Console.WriteLine(" employee is present ");
            }
            else 
            {
                Console.WriteLine(" employee is absent ");
            }
        }
    }
}
