using Microsoft.VisualBasic.FileIO;
using System.Xml.Schema;

namespace assigment2._3
{
    internal class Prime
    {
     
        static List<int> Function(int end)
        {
            List<int> array = new List<int>();
            List<int> result = new List<int>();
            for (int i = 2; i <= end; i++)
                array.Add(i); //初始化数据
            while(array.Count > 0)
            {
                int toRemove = array.First();
                result.Add(toRemove);
                array.RemoveAll(item => item% toRemove == 0);
            }
            return result;
        }
        static void show(List<int> array)
        {
            foreach(int toShow in array)
                Console.Write(toShow+" ");
        }
        static void Main(string[] args)
        {
            List<int> array = new List<int>();
           show(Function(100));
        }
    }
}
