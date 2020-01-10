using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent_of_Code___Day_3
{
    class Wire_Calculation
    {
        public int Wire(string[] wireData)
        {
            List<int> up = new List<int>();
            List<int> down = new List<int>();
            List<int> right = new List<int>();
            List<int> left = new List<int>();
            List<int> vertical = new List<int>();
            List<int> horizontal = new List<int>();

            foreach (string instruction in wireData)
            {
                if (instruction.StartsWith('U'))
                {
                    var numberString = instruction.Split('U', StringSplitOptions.RemoveEmptyEntries);
                    var instructionNumber = int.Parse(numberString[0]);
                    up.Add(instructionNumber);
                }
                else if (instruction.StartsWith('D'))
                {
                    var numberString = instruction.Split('D', StringSplitOptions.RemoveEmptyEntries);
                    var instructionNumber = int.Parse(numberString[0]);
                    down.Add(instructionNumber);
                }
                else if (instruction.StartsWith('R'))
                {
                    var numberString = instruction.Split('R', StringSplitOptions.RemoveEmptyEntries);
                    var instructionNumber = int.Parse(numberString[0]);
                    right.Add(instructionNumber);
                }
                else if (instruction.StartsWith('L'))
                {
                    var numberString = instruction.Split('L', StringSplitOptions.RemoveEmptyEntries);
                    var instructionNumber = int.Parse(numberString[0]);
                    left.Add(instructionNumber);
                }
            }

            vertical.Add(up.Sum());
            vertical.Add(down.Sum());
            horizontal.Add(right.Sum());
            horizontal.Add(left.Sum());

            var verticalCalculation = vertical.Max() - vertical.Min();
            var horizontalCalculation = horizontal.Max() - horizontal.Min();

            var wireResult = verticalCalculation + horizontalCalculation;
            return wireResult;
        }
    }
}
