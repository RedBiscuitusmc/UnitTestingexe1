using System;


namespace UnitTestingExercise
{
     public class Calculator
    {
        public Calculator()
        {

        }

        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtract(int minend, int subend)
        {
            return minend - subend;
        }
       
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
