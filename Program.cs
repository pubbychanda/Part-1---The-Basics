using System;

namespace The_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = @"N   N  N   N
NN  N  NN  N            
N N N  N N N                           
N  NN  N  NN                           
N   N. N   N.";                           
            Console.WriteLine(str);

            String firstName = "Nolan";
            String favMovie = "The Matrix";
            String greeting = "Hows it hangin' " + firstName + "? Have you watched your daily dose of " + favMovie + "?";

            Console.WriteLine(greeting.ToLower());
            Console.WriteLine(greeting.ToUpper());
            Console.WriteLine("contains THE: " + greeting.ToUpper().Contains("THE"));
            Console.WriteLine(greeting.ToUpper().Replace('A', '@').Replace('E', '3'));
            Console.ReadLine();
        }
    }
}
