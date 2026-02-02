namespace MethodsExercise
{
    public class Program
    {
        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Heya {userName}! What's your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine($"Cool beans, {userName}! I like  {favColor} too! How about your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine($"Oh, gross! I hate {favAnimal}! Favorite band?");
            string favBand =  Console.ReadLine();
            Console.WriteLine($"Alright cool, now let me just make a story for you: So this guy {userName}, was going on and on about his favorite color, {favColor}, and he said to me \"yeah, my favorite animal is {favAnimal}\", and I'm like, \"EW! In which they reply \"Yeah, but my favorite band is {favBand}\" which kind of won me over.");
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)

        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                //sum = sum + number;
                
                sum += number;
            }
            return sum;
        }
        
        static void Main(string[] args)
        {
            //MadLib();
            Console.WriteLine(Add(2, 2));
            Console.WriteLine(Subtract(2, 2));
            Console.WriteLine(Multiply(2, 2));
            Console.WriteLine(Divide(2, 2));
            Console.WriteLine(Sum(3, 3, 5, 9, 8));
        }
    }
}
