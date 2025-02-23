namespace assigmemnt2._4
{
    internal class Program
    {
        public static bool Toeplitz(int[,] matrix)
        {
            if (matrix == null)
                throw new Exception( "矩阵不能为 null");

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // 空矩阵视为托普利茨矩阵
            if (rows == 0 || cols == 0)
                return true;

            // 检查每个元素是否等于左上角元素（从第二行第二列开始）
            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] != matrix[i - 1, j - 1])
                        return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2, } };
            Console.WriteLine(Toeplitz(matrix));
        }
    }
}
