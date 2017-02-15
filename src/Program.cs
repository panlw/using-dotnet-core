using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WeekDaysChron.All.ForEach(day => Console.WriteLine(day));

            Console.WriteLine("Hello World!");
        }
    }
}
