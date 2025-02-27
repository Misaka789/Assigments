using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment3
{
    class ShapeFactory
    {
        public static Shape CreateShape(String type,double size)
        {
            if (type != "Square") throw new Exception("无法用提供的参数构建对象");
            return new Square(size);
        } 
        public static Shape CreateShape(String type,double line1,double line2,double line3)
        {
            if (type != "Triangle") throw new Exception("无法用提供的参数构建对象");
            return new Triangle(line1, line2, line3);
        }
        public static Shape CreateShape(String type, double length,double width)
        {
            if (type != "Rectangle") throw new Exception("无法用提供的参数构建对象");
            return length>width? new Rectangle(length,width):new Rectangle(width,length);
        }
    }
}
