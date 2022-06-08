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
            
            num2 = 100;
            //using concatination
            Console.WriteLine("num1 is " + num1);
            int sum = num1 + num2;
            Console.WriteLine("num1 " + num1 + " +" + " num2 " + num2 + " is " + sum);
            
            

            Console.Read();
        }
    }
}
