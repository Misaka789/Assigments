using assigment3;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment3
{
    abstract class Shape :Calculate{ virtual public void calculate() { } }

    class Rectangle : Shape
    {
        private double length;
        private double width;
        public Rectangle( double length,double width)
        {
            if (width >= length) throw new Exception("长度不能小于宽度");
            this.width = width;
            this.length = length;
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0) throw new Exception("长方形宽度不能为负值");
                else if (value > length) throw new Exception("宽不能大于长");
                else width = value;
            }
        }

        public double Length
        {
            get { return length; }
            set
            {
                if (value < 0) throw new Exception("长方形长度不能为负值");
                else if (value < width) throw new Exception("长不能小于宽");
                else length = value;
            }
        }
        public override void calculate()
        {
            Console.WriteLine($"矩形面积为{width * length}");
        }
    }
        class Square :Shape
        {
        private double side;
            public Square(double side)
            {
                if (side <= 0) throw new Exception("正方形边长不能为负值！");
                this.side = side;
            }

            public double Side
            {
                get { return side; }
                set { if (value <= 0) throw new Exception("正方形边长不能为负值！");
                else side = value;
            }
            }
            public override void calculate()
            {
                Console.WriteLine($"正方形面积为{side * side}");
            }
        }
        class Triangle :Shape
        {
            private double a;
            private double b;
            private double c;
            public Triangle(double a, double b, double c)
            {
                if (a + b <= c || a + c <= b || c + b <= a) throw new Exception($"{a},{b},{c}无法构成三角形!");
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public override void calculate()
            {
                Console.WriteLine($"三角形面积为{Math.Sqrt(((a + b + c) / 2.0) * ((a + b + c) / 2.0 - a) * ((a + b + c) / 2.0 - b) * ((a + b + c) / 2.0 - c))}");
            }
        }
    }
