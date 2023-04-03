using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code_2015
{
    internal class Helper
    {
        public static string Print(object? part1, object? part2)
        {
            string output = "";

            //If of type string parse and retunr
            if (part1?.GetType() == typeof(string) || part1?.GetType() == typeof(int) || part1?.GetType() == typeof(char))
                output += $"Part 1: {part1.ToString()}" + Environment.NewLine;

            if (part2?.GetType() == typeof(string) || part2?.GetType() == typeof(int) || part2?.GetType() == typeof(char))
                output += $"Part 2: {part2.ToString()}" + Environment.NewLine;

            return output;
        }
    }
}
