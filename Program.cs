using System;

namespace JulianDateCalculator
{
    public class Program
    {
        public static int JulianDate(int mm, int dd)
        {
            int[] months = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int monthDate = 0;
            for (int i = 0; i < mm; i++)
            {
                monthDate += months[i];
            }
            int julianDate = monthDate + dd;
            Console.WriteLine(julianDate);
            return julianDate;
        }

        static void Main(string[] args)
        {
            JulianDate(11,1);
            //Console.WriteLine("Hello World!");
        }
    }
}
