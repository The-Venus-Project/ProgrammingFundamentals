namespace Task4_BeverageLabels
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());
            double totalEnergy = volume * (energy / 100.0);
            double totalSugar = volume * (sugar / 100.0);

            Console.WriteLine(
                  $"{volume}ml " + $"{productName}: " +
                  System.Environment.NewLine +
                  $"{totalEnergy}kcal, " + $"{totalSugar}g sugars"
                  );
        }
    }
}