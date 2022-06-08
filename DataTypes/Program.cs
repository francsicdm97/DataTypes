using System;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring multiple variables at once
            int num3, num4, num5;
            //declare a variable
            int num1;
            //assign a value to variable
            num1 = 13;

            //declare and itialising a variable
            int num2 = 23;
            long myLongNum = 123131231312312313;
            num2 = 100;
            //using concatination
            Console.WriteLine("num1 is " + num1);
            int sum = num1 + num2;
            Console.WriteLine("num1 " + num1 + " +" + " num2 " + num2 + " is " + sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1/ f2;
            Console.WriteLine("f1/f2 is " + fDiv);

            //divide double d1 by int num1
            double diDiv = d1 / num1;
            Console.WriteLine("d1/num1 is " + diDiv);
            

            Console.Read();
        }
    }
}
