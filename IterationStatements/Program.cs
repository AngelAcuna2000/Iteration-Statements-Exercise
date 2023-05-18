namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below

        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Nums1000ThroughNeg1000()
        {
            for (int i = 1000; i >= -1000; Console.WriteLine($"{i--}")) ;

            return;
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Nums3Through999()
        {
            for (int i = 3; i < 999; Console.WriteLine($"{i += 3}")) ;

            return;
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not
        
        public static void NumberInequality(int num1, int num2)
        {
            var equalOrNot = (num1 == num2) ? $"{num1} and {num2} are equal" : $"{num1} and {num2} are not equal";

            Console.WriteLine($"{equalOrNot}");

            return;
        }

        //Write a method to check whether a given number is even or odd

        public static void EvenOrOdd(int num)
        {
            var evenOrOdd = (num % 2 == 0) ? $"{num} is even" : $"{num} is odd";

            Console.WriteLine($"{evenOrOdd}");

            return;
        }

        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegativeNum(int num)
        {
            var positiveOrNegative = (num > 0) ? $"{num} is positive" : $"{num} is negative";

            Console.WriteLine($"{positiveOrNegative}");

            return;
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void VotingAge(int age)
        {
            var votingAge = (age >= 18) ? $"{age} is old enough to vote" : $"{age} is not old enough to vote";

            Console.WriteLine($"{votingAge}");

            return;
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void InRange(int num)
        {
            var inRange = (num >= -10 && num <= 10) ? $"{num} is in range" : $"{num} is not in range";

            Console.WriteLine($"{inRange}");

            return;
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultiplicationTable(int i)
        {
            for (int num = 1; num <= 12; Console.WriteLine($"{i} x {num} = {i * num++}"));

            return;
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Nums1000ThroughNeg1000();

            Nums3Through999();

            NumberInequality(1, 2);

            EvenOrOdd(1);

            PositiveOrNegativeNum(-1);

            VotingAge(17);

            InRange(-11);

            MultiplicationTable(2);
        }
    }
}
