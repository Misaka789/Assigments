using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment5
{
    public class OrderService
    {
        private readonly List<Order> orders = new();  //管理所有订单列表 用readonly来修饰 

        public void AddOrder(Order order)
        {
            if (orders.Any(o => o.Equals(order)))  //传入一个lambda表达式 判断是否已存在相同订单
                throw new InvalidOperationException($"订单已存在: {order.OrderId}");
            orders.Add(order);
        }

        public void RemoveOrder(string orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId)
                ?? throw new KeyNotFoundException($"订单不存在: {orderId}");
            orders.Remove(order);
        }

        public void UpdateOrder(Order newOrder)
        {
            RemoveOrder(newOrder.OrderId);
            orders.Add(newOrder);
        }
        //实现订单的排序功能

        public void Sort()
        {
            orders.Sort((o1, o2) => o1.OrderId.CompareTo(o2.OrderId));
        }
        public void Sort(Func<Order, Order, int> comparison)
        {
            orders.Sort((o1, o2) => comparison(o1, o2));
        }

        public void PrintOrders()
        {
            foreach (var order in orders)
                Console.WriteLine(order);
        }

        //按照不同需求查询订单
        public Order GetById(string id)
        {
            return orders.SingleOrDefault(o => o.OrderId == id)  //由于ID具有唯一性 所以用SingleOrDefault
                   ?? throw new KeyNotFoundException($"订单 {id} 不存在");
        }
        public IEnumerable<Order> QueryByCustomer(String name)  //根据顾客名字查询订单 返回一个Order集合
        {
            return orders.Where(o => o.Customer.Name == name)
                   ?? throw new KeyNotFoundException($"顾客 {name} 不存在");
        }
        public IEnumerable<Order> QueryByProduct(String productName)  //根据商品名字查询订单 返回一个Order集合
        {
            return orders.Where(o => o.FindByName(productName))
                   ?? throw new KeyNotFoundException($"商品 {productName} 不存在");
        }
    }
}