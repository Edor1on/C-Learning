using System;
using System.Collections.Generic;

namespace CSharplearning
{
    internal class Generics
    {
        public Generics()
        {
            List<int> numbers = new List<int> { 12, 342, 42, 14, 15 };

            numbers.Add(30);
            numbers.Add(2345);
            numbers.Add(185);

            numbers.Remove(30);
            numbers.Sort();
            numbers.Reverse();

            numbers[1] = 14;
            numbers[2] = numbers[3];

            foreach(int el in numbers)
            {
                Console.WriteLine(el);
            }


        }
    }
}
