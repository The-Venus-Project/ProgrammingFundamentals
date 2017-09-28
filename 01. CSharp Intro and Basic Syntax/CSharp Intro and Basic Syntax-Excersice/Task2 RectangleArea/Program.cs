namespace Task2_RectangleArea
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            float rectangleArea = width * height;

            Console.WriteLine($"{rectangleArea:F2}");
        }
    }
}
