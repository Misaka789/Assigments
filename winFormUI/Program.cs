using assigment5;
using System.ComponentModel;

namespace winFormUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static readonly OrderService orderService = new();  //定义一个全局变量orderService
        public static BindingList<Order> orderList = new(orderService.Orders);
        [STAThread]
        
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
           
            //数据初始化
            Customer customer1 = new("张三", "123456789");  //创建两个顾客 具有姓名和联系方式两个属性
            Customer customer2 = new("李四", "987654321");
            Customer customer3 = new("张三", "123456789");
            Product product1 = new("苹果");    //创建两个商品 
            Product product2 = new("香蕉");

            Order order1 = new Order("1", customer1);
            Order order2 = new Order("2", customer2);
            Order order3 = new Order("3", customer3);
            OrderDetail detail1 = new OrderDetail(product1, 10, 5);   //Product1 产品编号为1 数量为10 单价为5
            OrderDetail detail2 = new OrderDetail(product2, 20, 3);
            OrderDetail detail3 = new OrderDetail(product1, 10, 5);
            order3.AddDetail(detail3);
            order1.AddDetail(detail1);
            order2.AddDetail(detail2);
            orderService.AddOrder(order3);
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}