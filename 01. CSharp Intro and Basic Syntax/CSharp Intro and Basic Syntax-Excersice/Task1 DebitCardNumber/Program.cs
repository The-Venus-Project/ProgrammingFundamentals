namespace Task1_DebitCardNumber
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int thirdDigit = int.Parse(Console.ReadLine());
            int fourthDigit = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        }
    }
}
