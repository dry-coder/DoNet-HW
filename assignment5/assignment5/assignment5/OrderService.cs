using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
   public  class OrderService
    {
        public List<Order> OrderList = new List<Order>();//所有订单列表
        //添加订单
        public void AddOrder(Order order)
        {
            if (OrderList.Contains(order))
                Console.WriteLine("该订单已经存在，添加失败");
            else { OrderList.Add(order); }
        }
        //删除订单
        public void DeleteOrder(Order order)
        {
            if (!OrderList.Contains(order))
            {
                Console.WriteLine("该订单不存在，删除失败");
            }
            else { OrderList.Remove(order); }
        }
        //修改订单
        public void ModifyOrder(Order neworder)
        {
            Order oldorder=GetOrderbyOrderNumber(neworder.OrderNumber);
            if(oldorder != null)
            {
                OrderList.Remove(oldorder);
                OrderList.Add(neworder);
            }
            else
            {
                Console.WriteLine("没有这个订单，订单修改失败");
            }
        }
        //按照订单号进行查询订单
        public Order GetOrderbyOrderNumber(int number)
        {
            return OrderList.FirstOrDefault(o => o.OrderNumber == number);
        }
        //按照客户进行查询订单
        public List<Order> GetOrderbyCustomer(string customer)
        {
           var query=from o in OrderList
                     where o.Customer == customer
                     orderby o.Details.Num*o.Details.Price
                     select o;
            return query.ToList();
        }
        //按照商品名称进行查询
        public List<Order> GetOrderbyGoodsName(string goodsname)
        {
            var query = from o in OrderList
                        where o.Details.GoodsName == goodsname
                        orderby o.Details.Num * o.Details.Price
                        select o;
            return query.ToList();
        }
        //按照订单金额范围查询订单
        public List<Order> GetOrderbyMoney(double min,double max)
        {
            var query = from o in OrderList
                        where o.Details.Price * o.Details.Num >= min && o.Details.Price * o.Details.Num <= max
                        orderby o.Details.Num * o.Details.Price
                        select o;
            return query.ToList();
        }
        //按订单号升序排序
        public void SortOrder()
        {
            OrderList.Sort((o1,o2)=>o1.OrderNumber.CompareTo(o2.OrderNumber));
        }
        //自定义排序订单
        public void SortOrder(Comparison<Order> comparison)
        {
            OrderList.Sort(comparison);
        }
        //显示所有订单
        public void ShowAllOrder()
        {
            foreach(var o in OrderList)
            {
                Console.WriteLine(o);
            }
        }
    }
}
