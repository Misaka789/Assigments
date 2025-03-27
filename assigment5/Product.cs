using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment5
{
    public class Product : IEquatable<Product>  //实现IEquatable接口
    {
        public string Name { get; }

        public Product( string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public bool Equals(Product other) =>      //重写Equals方法
             Name == other.Name;

        public override string ToString() => $"{Name}"; //重写ToString方法 格式化输出
    }
}
