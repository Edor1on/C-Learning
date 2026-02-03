using System;

namespace CSharplearning
{
    internal class Switch_case
    {
        public Switch_case()
        {
            short user_input = Convert.ToInt16(Console.ReadLine());

            switch (user_input)
            {
                case 1:
                    Console.WriteLine("Is 1");
                    break;
                case 2:
                    Console.WriteLine("Is 2");
                    break;
                case 3:
                    Console.WriteLine("Is 3");
                    break;
                case 4:
                    Console.WriteLine("Is 4");
                    break;
                case 5:
                    Console.WriteLine("Is 5");
                    break;
                default:
                    Console.WriteLine("Is another number");
                    break;

            }
        }
    }
}
