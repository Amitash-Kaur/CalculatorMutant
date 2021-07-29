using System;

namespace CalculatorExmple
{
    public class CalculatorMutant
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");

            int operation = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Enter the first Number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;



            switch (operation)
            {
                case 1:
                    {
                        result = Addition(num1, num2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(num1, num2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(num1, num2);
                        break;
                    }
                case 4:
                    {
                        result = Division(num1, num2);
                        break;
                    }

                default:
                    Console.WriteLine("INVALID VALUE! try again");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();
        }



        public static double Addition(double a, double b)
        {
            double c = a + b;
            return c;
        }
        public static double Subtraction(double a, double b)
        {
            double c = a - b;
            return c;

        }
        public static double Multiplication(double a, double b)
        {
            double c = a * b;
            return c;
        }
        public static double Division(double a, double b)
        {
            double c = a * b; //Adding the mutant
            return c;
        }

    }
}