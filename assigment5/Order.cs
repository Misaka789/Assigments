using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment5
{
    public class Order
    {
        private String Id { get; set; } // id作为主键为唯一标识
        public String GetId() => this.Id;

        public void SetId(String id)
        {
           this.Id = id;
        }
        private String Name { get; set; }
        public String GetName() => this.Name;

        public void SetName(String name)
        {
            this.Name = name;
        }

        private String ClientName { get; set; }
        public String GetClientName()
        {
            return this.ClientName;
        }
        public void SetClientName(String name)
        {
            this.Name = name;
        }
        private int Amount { get; set; }

        public int GetAmount(){ return this.Amount; }
            public void SetAmout(int amount) { this.Amount = amount; }

        private DateTime CreateDate { get; set; }
        private DateTime UpdateDate { get; set; }
        public void SetUpdateTime(DateTime t) { this.UpdateDate = t; }
        public Order(String id, string name, string clientName, int amount, DateTime createDate, DateTime updateDate)
        {
            Id = id;
            Name = name;
            ClientName = clientName;
            Amount = amount;
            CreateDate = createDate;
            UpdateDate = updateDate;
        }

        public Order(String id, string name, string clientName, int amount)
        {
            Id = id;
            Name = name;
            ClientName = clientName;
            Amount = amount;
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
        }

        public override bool Equals(Object? o)
        {
            if (o == null)
                //throw new Exception("被的订单不能为空订单为空");
                return false;
           Order obj = (Order)o;
            return obj.Id == this.Id && obj.Name == this.Name && obj.ClientName == this.ClientName && obj.Amount == this.Amount;
        }
        public override string ToString()
        {
            return new String($"订单号:{this.Id} 商品名称:{this.Name} 客户:{this.ClientName} " +
                $"订单金额:{this.Amount} 订单创建时间:{this.CreateDate} 订单最后更新时间:{this.UpdateDate}");
        }
        public int CompareTo(Order obj)
        {
            if (obj == null) throw new System.ArgumentException();
            return this.Name.CompareTo(obj.GetName());
        }
    }
}
