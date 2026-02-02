using System;

namespace CSharplearning
{
    internal class Math_operation
    {
        public Math_operation()
        {
            float user_input;
            user_input = float.Parse(Console.ReadLine());

            float result;
            result = user_input + 10f;
            //result = user_input - 10f;
            //result = user_input * 10f;
            //result = user_input / 10f;
            //result = user_input % 10f;

            result += 5; //+ - / * %
            result++; // ++ --

            Console.WriteLine("Result: " + result);
            Console.WriteLine("Result: " + Math.PI);
            Console.WriteLine("Result: " + Math.Abs(-20));
            Console.WriteLine("Result: " + Math.Round(6.67));

            // Program

            Console.WriteLine("Enter radius :");
            double radius = double.Parse(Console.ReadLine());
            //double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Area: " + area);
        }
    }
}
