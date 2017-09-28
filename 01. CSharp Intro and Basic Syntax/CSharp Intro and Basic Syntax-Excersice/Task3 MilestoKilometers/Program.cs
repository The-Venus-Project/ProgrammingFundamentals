namespace Task3_MilestoKilometers
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double kilometers = miles * 1.60934;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
