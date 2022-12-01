using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000


        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void isEqual(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine("These numbers are equal");
            }
            else
            {
                Console.WriteLine("These numbers are not equal");
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is So even");
            }
            else
            {
                Console.WriteLine($"{num} is So even");
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void posOrNeg(int num)
        {
            if (num < 0)
            {
                Console.WriteLine($"{num} is So Negative");
            }
            else
            {
                Console.WriteLine($"{num} is So Postive");
            } 

        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CheckAgeForVoting()
        {
            Console.WriteLine("what is your age?");
            var answer = Console.ReadLine();
            var validNumber = int.TryParse(Console.ReadLine(), out int age);
            if (validNumber)
            
                if (age >= 18)
            {
                Console.WriteLine("you can vote");
            }
            else if ( age < 18)
            {
                Console.WriteLine("you can not vote");
            }


            //Heatin Up Section:
            //Write a method to check if an integer(from the user) is in the range -10 to 10
             static void ChackRange()
            {
                Console.WriteLine("enter in a number: ");
                var answer = int.Parse(Console.ReadLine());
                if (answer <= -10 && answer <= 10)
                {
                    Console.WriteLine("The number is in Range");
                }
                else
                {
                    Console.WriteLine("mumber is not in range");
                }
                //Write a method to display the multiplication table(from 1 to 12) of a given integer
                 static void Multtable( int num)
                {
                    for (int i = 1;i <= 12; i++)
                    {
                        Console.WriteLine($"{i} x {num} = {num*i}");
                    }
                }

                //Call the methods to test them in the Main method below
                //static void Main(string[] args)
                //{


                static void Main(string[] args)
        {
            //posOrNeg(-2);
            //posOrNeg(1);
            //Threes();
            //isEqual(4, 4);
            //EvenOrOdd(2);
            // EvenOrOdd(3);
            //PrintThousand();
            //CheckAgeForVoting();

        }


}
}
