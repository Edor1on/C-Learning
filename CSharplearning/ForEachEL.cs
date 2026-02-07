using System;

namespace CSharplearning
{
    internal class ForEachEL
    {
        public ForEachEL()
        {
            short[,] nums = {
                { 1, 3, 4, 5 },
                { 6, 7, 8, 9 },
                { 10, 11, 12, 13 }
            };

            foreach(short el in nums)
            {
                Console.WriteLine("El: " + el);
            }
        }
    }
}
