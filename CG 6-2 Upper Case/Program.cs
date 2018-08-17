using System;

namespace CG_6_2_Upper_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a favortie quote.");        
            string myString = Console.ReadLine();
            string myUString = myString.ToUpper();
            Console.WriteLine(myUString);

            Console.ReadLine();


           
        }
    }
}
