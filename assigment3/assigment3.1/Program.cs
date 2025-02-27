using System.Security;

namespace assigment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(6, 5);
            Shape triangle = new Triangle(3, 4, 5);
            Shape square = new Square(5);
            rectangle.calculate();
            triangle.calculate();
            square.calculate();
            //Shape triagnle2 = new Triangle(1, 2, 3);

            List<Shape> list = new List<Shape>();
            int totalNum = 10;
            Random n = new Random();
            for (int i = 0; i < totalNum; i++)
            {
                int selector = n.Next() % 3;
                switch (selector) 
                {
                    case 0:   //正方形
                      list.Add(  ShapeFactory.CreateShape("Square", n.NextDouble()*5));
                        break;
                    case 1:  //矩形
                        list.Add(ShapeFactory.CreateShape("Rectangle",n.NextDouble()*5,n.NextDouble()*5));
                        break;
                    case 2: //三角形 由于要创建满足三角形的三边关系的三角形，随机数要多次尝试
                        double line1, line2, line3;
                        do
                        {
                            line1 = n.NextDouble() * 5;
                            line2 = n.NextDouble() * 5;
                            line3 = n.NextDouble() * 5;
                        } while (line1 + line2 <= line3 || line1 + line3 <= line2 || line2 + line3 <= line1);
                        list.Add(ShapeFactory.CreateShape("Triangle", line1, line2, line3));
                        break;
                    default: break;

                }
            }
            foreach(Shape item in list)
                item.calculate();
            
        }
    }
}
