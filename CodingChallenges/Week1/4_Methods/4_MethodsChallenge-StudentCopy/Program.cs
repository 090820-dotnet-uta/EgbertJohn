using System;
using System.Diagnostics;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1
            string name = GetName();
            GreetFriend(name);

            //2
            double result1 = GetNumber();
            double result2 = GetNumber();
            int action1 = GetAction();
            double result3 = DoAction(result1, result2, action1);

            System.Console.WriteLine($"The result of your mathematical operation is {result3}.");


        }

        public static string GetName()
        {
            System.Console.WriteLine("Please type your name");
            return Console.ReadLine();
        }

        public static void GreetFriend(string name)
        {
            //Greeting should be: Hello, nameVar. You are my friend
            //Ex: Hello, Jim. You are my friend
            System.Console.WriteLine($"Hello, {name}. You are my friend");
        }

        public static double GetNumber()
        {
            //Should throw FormatException if the user did not input a number
            System.Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();

            bool isdouble = Double.TryParse(userInput, out double newDouble);
            
            if (isdouble)
            {
                return newDouble;
            }
            else
            {
                throw new FormatException();
            }
        }

        public static int GetAction()
        {
            System.Console.WriteLine("Please enter '1' to add, '2' to subtract, '3' to multiuply or '4' to divide");
            string actionstring = Console.ReadLine();

            bool isint = int.TryParse(actionstring, out int action1);

            if (!isint)

            {
                System.Console.WriteLine("Please enter '1' to add, '2' to subtract, '3' to multiuply or '4' to divide");
                throw new FormatException();
                
            }
           
            else
            {
                if (action1 <5 && action1 >0)
                {
                    return action1;
                }
                else
                {
                    System.Console.WriteLine("Please enter '1' to add, '2' to subtract, '3' to multiuply or '4' to divide");
                    throw new FormatException();
                    
                }
            }
         

        }

        public static double DoAction(double x, double y, int z)
        {
            
            if (z == 1)
            {
                return x+y;
            }
            else if (z == 2)
            {
                return y-x;
            }
            else if (z == 3)
            {
                return x*y;
            }
            else if (z == 4)
            {
                return x/y;
            }
            else
            {
                throw new FormatException();
        }   }
    }
}