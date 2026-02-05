using System;

namespace CSharplearning
{
    internal class Arrays
    {
        public Arrays()
        {
            byte[] nums = new byte[5];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 4;
            nums[4] = 255;

            nums[2] += 54;
            Console.WriteLine($"Element of masive: {nums[3]}");


            string[] names = { "Adrian", "Artur", "Yura", "Slavic", "Demian", "Romam", "Volodymir", "Oleksandr" };
            names[0] = "Adrianito";
            Console.WriteLine(names[0]);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("El: " + names[i]);
            }



            // сума доданків

            short[] numbers = new short[10];
            int summa = 0;

            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt16(random.Next(-50, 50));
                Console.WriteLine("EL: " + numbers[i]);

                summa += numbers[i];
            }

            Console.WriteLine("Summa: " + summa);


            // Багатовимірні масиви

            char[,] symbols = new char[2, 3];
            symbols[0, 0] = 'A';
            Console.WriteLine(symbols[0, 0]);

            int[,] numsArr =
            {
                {1, 2},
                {4, 6},
                {9, 10}
            };
            numsArr[2, 0] = 321;
            Console.WriteLine(numsArr[2, 0]);
        }
    }
}
