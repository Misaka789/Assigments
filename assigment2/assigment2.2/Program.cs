namespace assigment2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2,3,4 ,5, 6, 7, 8 };
            Console.WriteLine(MyMathUtils.MinValue(array));
            Console.WriteLine(MyMathUtils.MaxValue(array));
            Console.WriteLine(MyMathUtils.AverageValue(array));
            Console.WriteLine(MyMathUtils.GetSum(array));
            int[] array2 = new int[] { };
            Console.WriteLine(MyMathUtils.GetSum(array2));
            Console.WriteLine(MyMathUtils.MinValue(array2));
        }
    }
}
