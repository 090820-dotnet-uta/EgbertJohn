using System;

namespace _8_LoopsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {

 
            UseFor();
            System.Console.WriteLine();
            UseDoWhile();
            System.Console.WriteLine();
            UseWhile();


        }
        
        public static void UseFor()
        {

            
            int i;

            for (i = 1; i <50; i = i+2)
            {
                System.Console.Write($"{i} ");

            }
            
        }

        public static void UseDoWhile()
        {
            int x = 0;

            do 
            {
                System.Console.Write($"{x} ");
                x = x+2;


            }
           

            while
            (x <52);
        
        }

        public static void UseWhile()
        {
            int z = 3;

            while (z<100)

            {

                if (z%5==0)
            {
                System.Console.WriteLine("Skipping this number");
                z = z+3;
            }

            else
            {
                System.Console.WriteLine($"{z}");
                z = z+3;
            }


            }

        }



            /*int z = 0;
            int a = 2;
            int b = 3;
            int c = 4;
            int p = 0;
      

            while((z*a*b*c) < 100)
            {
                p = (z*a*b*c);
                if((p % 3) == 0 && (p % 5 ) == 0)

                System.Console.WriteLine("Skipping this number");


                else System.Console.WriteLine($"{p}");
                z++;*/

            
            }


        }

// 2. create a do/while loop that displays the even integers from 0 to 50.
// 3. create a while loop that displays the multiples of 3 integers from 0 to 100. 
//     1. Design the loop so that when every multiple of 3 and 5 coincide(like 15, 30, etc), you print "skipping this number" instead of the number.
//     2. Design the loop so that when you get above 100 you automatically stop the loop with a break statement.