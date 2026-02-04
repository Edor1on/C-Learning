using System;

namespace CSharplearning
{
    internal class Loops
    {
        public Loops()
        {
            for (byte i = 0; i < 10; i++)
            {
                Console.WriteLine("EL: " + i);
            }

            for (byte i = 200; i > 20 ; i-=9)
            {
                Console.WriteLine("EL: " + i);
            }

            int a = 1;
            while (a <= 10) 
            {
                Console.WriteLine("EL: " + a);
                a++;
            }


            bool IsGetUserData = false;
            while (!IsGetUserData)
            {
                Console.Write("Enter data: ");
                string data = Console.ReadLine();
                if (data == "Some")
                {
                    IsGetUserData = true;
                }
            }

            int f = 0;
            do
            {
                Console.WriteLine("EL: " + f);
                f++;
            } while (f <= 10);

            Console.WriteLine("Mini program");

            for(int i = 5; i<15; i++)
            {
                if (i == 13) break;

                if (i % 2 == 0) continue; // парні
                if (i % 2 == 1) continue; // непарні
                Console.WriteLine("EL: " + i);
            }
        }
    }
}
