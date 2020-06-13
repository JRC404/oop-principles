using System;

namespace oop_principles
{
    public class Mathematics
    {
        /*
            We have created four methods here. Addtion, Subtraction, Multiplication and Division. We have used integers, whole numbers to do this... 
            We have passed them through as parameters. We will need to modify these to make it work properly.
        */
        public int Addition(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        public int Subtraction(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }

        public int Multiplication(int numberOne, int numberTwo) 
        {
            return numberOne * numberTwo;
        }

        // our first look at data types with C#. Why is this incorrect?
        public int Division(int numberOne, int numberTwo) 
        {
            return numberOne / numberTwo;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics maths = new Mathematics();
            int addMe = maths.Addition(15, 10);
            int subtractMe = maths.Subtraction(15, 10);
            int multiplyMe = maths.Multiplication(15, 10);
            int divideMe = maths.Division(15, 10);
            Console.WriteLine(addMe);
            Console.WriteLine(subtractMe);
            Console.WriteLine(multiplyMe);
            Console.WriteLine(divideMe);
            Console.ReadLine();
        }
    }
}
