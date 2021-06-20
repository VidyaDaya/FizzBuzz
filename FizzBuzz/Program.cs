using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                Console.WriteLine(FizzBuzzGame.ReturnValue(i));
            }
        }

       public static string ReturnValue(int input)
       {
            if((input%3==0) && (input%5==0))
                return "fizz buzz";            
            if (input % 3 == 0)
                return "fizz";
            if (input % 5 == 0)
                return "buzz";
            return input.ToString();
       }
    }

   
}
