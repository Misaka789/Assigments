using System;

namespace assigment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfOrders = 99;
            Random random = new Random();
            OrderService service = new OrderService();
            for (int i = 1; i <= numberOfOrders; i++)
            {
                // 生成唯一ID（格式：ORD001, ORD002...）
                string id = $"ORD{i:D3}";

                // 随机生成数据（可根据需求修改）
                string[] products = { "电子产品", "图书", "服装", "食品", "家具" };
                string[] clients = { "客户A", "客户B", "客户C", "企业客户", "VIP客户" };

                var order = new Order(
                id: id,
                    name: $"{products[random.Next(products.Length)]}订单",
                    clientName: clients[random.Next(clients.Length)],
                    amount: random.Next(1, 100)  // 生成1-99的随机数量
                );

                service.AddOrder(order);
            }
            foreach (var item in service.QueryByName("电子产品"))
            {
                Console.WriteLine(item);
            }
            ; Console.WriteLine();
            foreach (var item in service.QueryByClientName("客户A"))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
