using System.Collections;

namespace allPrimeFactors
{
    internal class Program
    {

         static bool isPrime(int number)
        {
            for (int i = 1; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        static List<int> allPrimeFactos(int number)
        {
            List<int> result =new List<int>();
            for (int i = 1; i < number; i++)
            {
                if (isPrime(i) && number % i == 0) result.Add(i);
            }
            return result;
        }
        static void showAllElements(List<int> toShow)
        {
            foreach(var item in toShow)
            {
                Console.WriteLine(item + " ");
            }
        }
        static void Main(string[] args)
        {
            int testNumber = 10;
            showAllElements(allPrimeFactos(testNumber));
        }
    }
}
