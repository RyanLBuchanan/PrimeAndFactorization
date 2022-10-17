// (Prime Numbers and Prime Factorization) Write an app that takes a whole-number 
// input from a user and determines whether it’s prime. If the number is not prime,
// display the unique prime factors of the number. Remember that a prime number’s
// factors are only 1 and the prime number itself. Every number that’s not prime
// has a unique prime factorization. For example, consider the number 54.
// The prime factors of 54 are 2, 3, 3 and 3. When the values are multiplied together,
// the result is 54. For the number 54, the prime factors output should be 2 and 3.


namespace PrimeAndFactorization
{
    internal class PrimeTestAndFactors
    {
        static void Main(string[] args)
        {
            int num, i, counter = 0;

            var primes = new List<int>();

            Console.Write("\n\n");
            Console.Write("Check whether a given number is prime or not:\n");
            Console.Write("-----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input a number: ");

            num = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    counter++;
                    break;
                }
            }

            if (counter == 0 && num != 1)
            {
                Console.Write($"{num} is a prime number.\n", num);
            }
            else
            {
                Console.Write($"{num} is not a prime number.\n", num);
            }

            primes = GeneratePrimeFactors(num);

            Console.Write($"The prime factors of {num} are: ");
            foreach(var prime in primes)
            {
                Console.Write($"{prime} ");
            }

            Console.WriteLine();
        }

        public static List<int> GeneratePrimeFactors(int num)
        {
            var primes= new List<int>();

            for (int divisor = 2; divisor <= num; divisor++)
            {
                while (num % divisor == 0)
                {
                    primes.Add(divisor);

                    num = num / divisor;
                }
            }

            return primes;
        }
    }
}