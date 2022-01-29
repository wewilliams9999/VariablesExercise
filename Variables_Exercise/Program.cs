using System;

namespace Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize variables
            //Using camelCase when needed
            //Explicit typing
            string dogName = "Jack";
            int age = 11;
            char nickName = 'J';
            bool lovesStorms = false;
            double friends = 10;
            decimal weight = 48.6m;

            //String Interpolation with the $ and {} around variables
            Console.WriteLine($"My friend's dog's name is {dogName}. He is {age} years old, his nickname is {nickName}, he has {friends} friends, he weighs {weight} pounds, and it is {lovesStorms} that he loves storms");
        }
    }
}
