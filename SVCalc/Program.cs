using System;

namespace SVCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new SVCalc();
            Console.WriteLine(test.CalculateSV(float.Parse(Console.ReadLine())));

        }
    }
}
