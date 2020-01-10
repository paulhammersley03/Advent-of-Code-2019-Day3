using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent_of_Code___Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var wireOneData = new GetData().GetArrayOne();
            var wireOneAnswer = new Wire_Calculation().Wire(wireOneData);
            Console.WriteLine(wireOneAnswer);

            var wireTwoData = new GetData().GetArrayTwo();
            var wireTwoAnswer = new Wire_Calculation().Wire(wireTwoData);
            Console.WriteLine(wireTwoAnswer);

            Console.ReadLine();
        }
    }
}



