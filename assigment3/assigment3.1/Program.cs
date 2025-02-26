using System.Security;

namespace assigment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(5, 6);
            Shape triangle = new Triangle(3, 4, 5);
            Shape square = new Square(5);
            rectangle.calculate();
            triangle.calculate();
            square.calculate();
            Shape triagnle2 = new Triangle(1, 2, 3);
        }
    }
}
