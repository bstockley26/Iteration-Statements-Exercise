namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        

         

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        //Write a method to check whether a given number is even or odd
        
        //Write a method to check whether a given number is positive or negative
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            VotingElegibity();
        }
        static void ListThousand()
        {
            var numbers = new List<int>();
            int num;
            num = 10;

            do
            {
                Console.WriteLine(num);
                --num;
                numbers.Add(num);
                
            } while (num >= -10);

        }
        static void AddByThree()
        {
            var numbers = new List<int>();
            int num;
            num = 0;

            do
            {
                Console.WriteLine(num);
                num += 3;
                numbers.Add(num);

            } while (num <= 999);
        }
        static void EqualityCheck()
        {
            int a;
            int b;

            a = 8;
            b = 8;

            var correctStatement = (a == b) ? "Integars are equal" : "Integers are not equal!";

            Console.WriteLine(correctStatement);
        }
        static void EvenOddTest()
        {
            int a;
            int division;
            bool evenOrOdd;

            a = 7;
            division = a % 2;

            evenOrOdd = division == 0;

            if (evenOrOdd == true)
            {
                Console.WriteLine($"{a} is even");
            }
            else
            {
                Console.WriteLine($"{a} is odd!");
            }
        }
        static void PositiveOrNegative()
        {
            int a;           
            bool posOrNeg;

            a = -8;
            posOrNeg = a >= 0;

            if (posOrNeg == true)
            {
                Console.WriteLine($"{a} is a positive number!");
            }
            else
            {
                Console.WriteLine($"{a} is a negative number");
            }
        }
        static void VotingElegibity()
        {
            int age;

            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are elegibly to vote!!");
            }
            else
            {
                Console.WriteLine("You are to young to vote");
            }
        }
    }
}
