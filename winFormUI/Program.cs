using assigment5;
using System.ComponentModel;

namespace winFormUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static readonly OrderService orderService = new();  //����һ��ȫ�ֱ���orderService
        public static BindingList<Order> orderList = new(orderService.Orders);
        [STAThread]
        
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
           
            //���ݳ�ʼ��
            Customer customer1 = new("����", "123456789");  //���������˿� ������������ϵ��ʽ��������
            Customer customer2 = new("����", "987654321");
            Customer customer3 = new("����", "123456789");
            Product product1 = new("ƻ��");    //����������Ʒ 
            Product product2 = new("�㽶");

            Order order1 = new Order("1", customer1);
            Order order2 = new Order("2", customer2);
            Order order3 = new Order("3", customer3);
            OrderDetail detail1 = new OrderDetail(product1, 10, 5);   //Product1 ��Ʒ���Ϊ1 ����Ϊ10 ����Ϊ5
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