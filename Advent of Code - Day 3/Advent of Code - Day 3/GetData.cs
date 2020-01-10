using System.IO;
using System.Linq;

namespace Advent_of_Code___Day_3
{
    public class GetData
    {
        public string[] GetArrayOne()
        {
            var numberData = File.ReadAllText("C:/Users/minim/Documents/C# Projects/Advent of Code - Day 3/Input 1.txt").Split(',').ToArray();
            return numberData;
        }

        public string[] GetArrayTwo()
        {
            var numberData = File.ReadAllText("C:/Users/minim/Documents/C# Projects/Advent of Code - Day 3/Input 2.txt").Split(',').ToArray();
            return numberData;
        }
    }
}
