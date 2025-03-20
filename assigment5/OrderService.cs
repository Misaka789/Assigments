using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment5
{
    public class OrderService
    {
        private List<Order> allOrders;
        public OrderService(List<Order> allOrders)
        {
            this.allOrders = allOrders;
        }
        public OrderService()
        {
            this.allOrders = new List<Order>();
        }

        public Order QueryById(String id)       //id作为主键为唯一标识，只会返回一个Order对象 ，其余查询可能会出现多个符合的Order
        {
           var query =  allOrders.FirstOrDefault(s => s.GetId() == id);
            if (query == null) throw new Exception($"Id为{id}的订单不存在！");
            return query;
        }

        public List<Order> QueryByName(String name)
        {
            var query = allOrders.Where(s => s.GetName() == name);
            if (query == null) throw new Exception($"商品名称为{name}的订单不存在！");

            return query.ToList();
        }

        public List<Order> QueryByClientName(String name)
        {
            var query = allOrders.Where(s => s.GetClientName() == name);
            if (query == null) throw new Exception($"客户为{name}的订单不存在！");
            return query.ToList();
        }

        public List<Order> QueryByAmount(int amount)
        {
            var query = allOrders.Where(s => s.GetAmount() == amount);
            if (query == null) throw new Exception($"金额为为{amount}的订单不存在！");
            return query.ToList();
        }

        public bool DeleteById(String id)
        {
            Order query = QueryById(id);
            allOrders.Remove(query);
            return true;
        }
        public bool AddOrder(String id,String name,String clientName,int amount)
        {
            if (QueryById(id) != null) throw new Exception($"id为{id}的订单已存在，不能重复创建!");
            Order newOrder = new Order(id, name, clientName, amount);
            return true;
        }
        public bool AddOrder(Order order)
        {
            allOrders.Add(order);
            return true;
        }
        public bool ModifyById(string id,String newId,String name,String clientName,int amount)
        {
            if (QueryById(id) == null) throw new Exception($"id为{id}的订单不存在,无法修改!");
            var query = QueryById(id);
            query.SetName(name);
            query.SetId(newId);
            query.SetClientName(clientName);
            query.SetAmout(amount);
            query.SetUpdateTime(DateTime.Now);
            return true;
        }
       
        public void Sort()
        {
            if (allOrders == null) throw new Exception("订单为空，无法排序");
            allOrders.Sort();
        }
        public void Sort(Comparison<Order> compare)
        {
            if (allOrders == null) throw new Exception("订单为空，无法排序");
            allOrders.Sort(compare);
        }
    }
}
