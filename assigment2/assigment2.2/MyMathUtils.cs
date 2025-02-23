using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment2._2
{
    class MyMathUtils
    {
       public static int MaxValue(int[] array)
        {
            if (array == null) throw new Exception("数组不能为null");
            if (array.Length == 0) throw new Exception("数组长度不能为0");
            int result = int.MinValue;
            foreach( int compare in array)
                result = result > compare ? result : compare;
            return result;
        }

       public  static int MinValue(int[] array)
        {
            if (array == null) throw new Exception("数组不能为null");
            if (array.Length == 0) throw new Exception("数组长度不能为0");
            int result = int.MaxValue;
            foreach (int compare in array)
                result = result < compare ? result : compare;
            return result;
        }

        public static int GetSum(int[] array)
        {
            if (array == null) throw new Exception("数组不能为null");
            int sum = 0;
            foreach(int num in array)
                sum += num;
            return sum;
        }
       public static float AverageValue(int[] array)
        {
            if (array == null) throw new Exception("数组不能为null");
            if (array.Length == 0) throw new Exception("数组长度不能为0");
            return GetSum(array) / (float)array.Length;
        }
    }
}
