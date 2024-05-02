namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void NumbersTo_Neg1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }






        //Write a method that will print to the console numbers 3 through 999 by 3 each time- DONE

        public static void Numbersby3()

        {
            for (var i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }


        }


        //Write a method to accept two integers as parameterss and check whether they are equal or not-DONE

        public static void ParametersCheck(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine($"{x} equals {y}");
            }
            else
            {
                Console.WriteLine($"{x} does not equal {y}");
            }
        }

        //Write a method to check whether a given number is even or odd-DONE

        public static void EvenOrOdd()
        {

            Console.WriteLine("Please enter a number to see if it is odd or even");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is a even number");

            }
            else
            {
                Console.WriteLine($"{num} is a odd number");
            }




        }

        //Write a method to check whether a given number is positive or negative-DONE

        public static void PostOrNeg()
        {

            Console.WriteLine("Please enter a number to see if it is positve or negative");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"{number} is a positive number.");
            }
            else
            {
                Console.WriteLine($"{number} is a negative number.");
            }




        }


        //Write a method to read the age of a candidate and determine whether they can vote.-DONE

        public static void VoterCheck()
        {
            Console.WriteLine("Welcome to Voter's Registration! How old are you?");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote!");
            }
            else
            {
                Console.WriteLine("You are not old enough to vote yet!");
            }

        }


        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()






        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void intRange()
        {
            Console.WriteLine("Enter a number");
            var number = int.Parse(Console.ReadLine());

            if (number > -10 && number <10)

            {

                Console.WriteLine("This number is in range!");
            }
            else
            {
                Console.WriteLine("This number is not in range");
            }


        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer-DONE

        public static void MultiplyTable()
        {
            Console.WriteLine("Enter a number");
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                var result = i * number;
                Console.WriteLine($"{i} * {number} = {result}");

            }

        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {

            VoterCheck();
            intRange();
            ParametersCheck(9, 8);
            PostOrNeg();
            EvenOrOdd();
            MultiplyTable();
            Numbersby3();
            NumbersTo_Neg1000();

        }
    }


}
