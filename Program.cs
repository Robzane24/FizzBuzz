namespace FIzzBuzz
{
    internal class Program
    {
        public static string FizzBuzz(int number)
        {
            var answer = "";

            if (number % 3 == 0)
            {
                answer = "fizz";
            }

            if (number % 5 == 0)
            {
                answer = "buzz";
            }

            if (number % 3 == 0 && number % 5 == 0)
            {
                answer = "fizzbuzz";
            }
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz(10));
        }
        
    }
        
}