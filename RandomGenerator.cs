
using System;
namespace num_finder.tools
{
    public class RandomGenerator
    {
        public static int getRandom(int start, int end)
        {
            Random random = new Random();
            return random.Next(start, end);
        }

    }
}