using System;

namespace CG_6_2_Upper_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This is code asking for the user to input a sentence for the program.*/
            Console.WriteLine("Please write a favortie quote.");

            //This is taking the inputted data and assigning a variable
            string myString = Console.ReadLine();        

            //This is taking the inputted variable and turning it into a variable
            //in all upper case
            string myUString = myString.ToUpper();

            //This is writing said upper case sentence.
            Console.WriteLine(myUString);

            Console.ReadLine();


           
        }
    }
}
