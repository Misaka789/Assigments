using System;

namespace assigment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new();
            Customer customer1 = new("张三", "123456789");  //创建两个顾客 具有姓名和联系方式两个属性
            Customer customer2 = new("李四", "987654321");

            Product product1 = new( "苹果");    //创建两个商品 具有商品编号和商品名称两个属性
            Product product2 = new( "香蕉");

            Order order1= new Order("1", customer1);
            Order order2= new Order("2", customer2);

            OrderDetail detail1= new OrderDetail(product1, 10, 5);   //Product1 产品编号为1 数量为10 单价为5
            OrderDetail detail2 = new OrderDetail(product2, 20, 3);

            order1.AddDetail(detail1);
            order2.AddDetail(detail2);
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            //打印所有订单
            orderService.PrintOrders();
            Console.WriteLine("--------------------");
            Console.WriteLine("修改后:");
            //更新订单
            Order newOrder = new Order("1", customer1);  //创建新的订单用于取代旧的订单
            newOrder.AddDetail(new OrderDetail(new Product("梨"),20,5.2f));  //将原来订单号为1的订单进行修改
            orderService.UpdateOrder(newOrder);
            orderService.PrintOrders();
            //删除订单
            Console.WriteLine("--------------------");
            Console.WriteLine("删除后:");
            orderService.RemoveOrder("1"); //根据订单id进行删除
            orderService.PrintOrders();

            //查询id为2的订单
            Console.WriteLine("--------------------");
            Console.WriteLine("查询id为2的订单:");
            Console.WriteLine(orderService.GetById("2"));
        }
    }
}
