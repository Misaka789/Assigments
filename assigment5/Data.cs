//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace assigment5
//{
//    class Data
//    {
//        private string  ID ;
//        private string name;
//        private string phone;
//        private int amount;
//        private List<Product> products;
//        private int price;
//        private int quantity;
//        private Data (Order order)
//        {
//            this.ID = order.OrderId;
//            this.name = order.Customer.Name;
//            this.phone = order.Customer.Contact;
//            this.amount = (int)order.TotalAmount; 
//            this.products = order.details;
//            this.price = order.details.Sum(d => d.UnitPrice);
//            this.quantity = order.details.Sum(d => d.Quantity);
//        }
//        public Data(string ID, string name, string phone, int amount, List<string> products, int price, int quantity)
//        {
//            this.ID = ID;
//            this.name = name;
//            this.phone = phone;
//            this.amount = amount;
//            this.products = products;
//            this.price = price;
//            this.quantity = quantity;
//        }
//    }
//}
