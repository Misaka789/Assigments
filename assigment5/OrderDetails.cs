using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment5
{
    public class OrderDetail : IEquatable<OrderDetail>    //订单细节类 记录订单商品 \ 数量 \单价  并且可以计算总价
    {
        public Product Product { get; }
        public int Quantity { get; }
        public float  UnitPrice { get; }

        public OrderDetail(Product product, int quantity, float unitPrice)
        {
            Product = product ?? throw new ArgumentNullException(nameof(product));
            Quantity = quantity > 0 ? quantity : throw new ArgumentException("数量必须大于0");
            UnitPrice = unitPrice > 0 ? unitPrice : throw new ArgumentException("单价必须大于0");
        }

        public bool Equals(OrderDetail other) =>
            other != null &&
            Product.Equals(other.Product) &&
            Quantity == other.Quantity &&
            UnitPrice == other.UnitPrice;

        public override string ToString() =>
            $"{Product} ×{Quantity} @{UnitPrice:C}";

      //  public bool FindByName(string name) => Product.Name == name;
    }
}
