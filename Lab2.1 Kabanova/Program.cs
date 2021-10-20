using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите x:");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите y:");
                double y = double.Parse(Console.ReadLine());
                if (Math.Pow(x + 1, 2) + y * y >= 1 && x * x + y * y <= 4) Console.WriteLine("Yes");
                else Console.WriteLine("No");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
