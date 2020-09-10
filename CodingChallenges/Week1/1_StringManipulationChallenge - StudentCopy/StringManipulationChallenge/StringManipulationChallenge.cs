using System;

namespace StringManipulationChallenge
{
    public class Program
    {
 
        static void Main(string[] args)
        {
            string userInputString; //this will hold your users message
            int elementNum;         //this will hold the element number within the messsage that your user indicates
            char char1;             //this will hold the char value that your user wants to search for in the message.
            string fName;           //this will hold the users first name
            string lName;           //this will hold the users last name
            string userFullName;    //this will hold the users full name;
     
            //
            //
            //implement the required code here and within the methods below.
            //
            //
            System.Console.WriteLine("Please enter your message and press enter");
            userInputString = Console.ReadLine();
            
            System.Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter");
            elementNum = int.Parse(Console.ReadLine());

            System.Console.WriteLine(StringToUpper(userInputString));
            System.Console.WriteLine(StringToLower(userInputString));
            System.Console.WriteLine(StringTrim(userInputString));
            System.Console.WriteLine(StringSubstring(userInputString, elementNum));


            System.Console.WriteLine("For which character should I search in your original message?");
            string input2 = Console.ReadLine();
            char1 = char.Parse(input2);

            System.Console.WriteLine(SearchChar(userInputString, char1));


            System.Console.WriteLine("What is your first name?");
            fName = Console.ReadLine();

            System.Console.WriteLine("What is your last name?");
            lName = Console.ReadLine();

            userFullName = (ConcatNames(fName, lName));
            System.Console.WriteLine("{0}", userFullName);

        }

    
        public static string StringToUpper(string x){
            string upperString = x.ToUpper();
            return upperString;
            
        }

              
        public static string StringToLower(string x){
            string LowerString = x.ToLower();
            return LowerString;

        }
        
        
        public static string StringTrim(string x){
            string trimString = x.Trim();
            return trimString;
        }
        

        public static string StringSubstring(string x, int elementNum){
            string sub = x.Substring(elementNum);
            return sub;

        }

        // This method has two parameters, one string and one char.
        // It will:
        // 1) search the string parameter for the char parameter
        // 2) return the index of the char.
        public static int SearchChar(string userInputString, char x){
            int index = userInputString.IndexOf(x);
            return index;
        }

        // This method has two string parameters.
        // It will:
        // 1) concatenate the two strings with a space between them.
        // 2) return the new string.
        public static string ConcatNames(string fName, string lName){
            string space = " ";
            string fullname = string.Concat(fName, space, lName);
            return fullname;
        }



    }//end of program
}
