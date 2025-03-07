using System.Collections.Concurrent;

namespace assigment4
{
    internal class assigment4_1
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>(12,3,4,5,5);
            Console.WriteLine("list链表的所有数值为:");
            list.ForEach(t => Console.Write(t+" "));
            Console.WriteLine();
            int sum = 0;int max = int.MinValue;int min = int.MaxValue;
            list.ForEach(t => sum += t);
            Console.WriteLine();
            list.ForEach(t => max = max > t ? max : t);
            list.ForEach(t => min = min > t ? t : min);
            Console.WriteLine($"list链表最大值为{max}");
            Console.WriteLine();
            Console.WriteLine($"list链表最小值为{min}");
        }
    }
}
