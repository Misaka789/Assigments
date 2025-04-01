using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment5
{
    public class Order : IEquatable<Order>
    {
        public string OrderId { get; }
        public Customer Customer { get; }
       public readonly HashSet<OrderDetail> details = new();  //单个订单可能存在多个商品 所以用一个hashet来存储可以避免重复

        public bool FindByName(string name) =>details.Any(d=>d.product.Name ==name);
        public float TotalAmount => details.Sum(d => d.Quantity * d.UnitPrice);

        public Order(string orderId, Customer customer)
        {
            OrderId = orderId ?? throw new ArgumentNullException(nameof(orderId));
            Customer = customer ?? throw new ArgumentNullException(nameof(customer));
        }

        public bool AddDetail(OrderDetail detail) => details.Add(detail);
        public bool RemoveDetail(OrderDetail detail) => details.Remove(detail);

        public bool Equals(Order other) => OrderId == other?.OrderId;

        public override string ToString() =>
            $"订单号: {OrderId}\n客户: {Customer}\n明细:\n{string.Join("\n", details)}\n总计: {TotalAmount:C}\n";
    }
}
