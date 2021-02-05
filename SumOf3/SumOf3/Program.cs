using System;

namespace SumOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double MAGIC_Number = 7.777;// local constant variable

            Double Number1;
            Console.WriteLine("Enter a number between 1 and 5.5 >>");
            String Number1AsString = Console.ReadLine();
            Number1 = Convert.ToDouble(Number1AsString);

            Double Number2;
            Console.WriteLine("Enter a second number between 1 and 5.5>>");
            String Number2AsString = Console.ReadLine();
            Number2 = Convert.ToDouble(Number2AsString);

            Double Number3;
            Console.WriteLine("Enter a third number between 1 and 5.5>>");
            String Number3AsString = Console.ReadLine();
            Number2 = Convert.ToDouble(Number3AsString);

            double Total = Number1 + Number2 + Number3;
            double Answer = Total * MAGIC_Number;
            string Final = Answer.ToString("F3");
            Console.WriteLine(Final);




        }
    }
}
