using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public  class Order
    {
        public string Customer { get; set; }//客户信息
        public int OrderNumber { get; set; }//订单号 唯一性
        public OrderDetails Details { get; set; }//订单明细
        public Order(string cus,int number,OrderDetails d)
        {
            Customer = cus;
            OrderNumber = number;
            Details = d;
        }

        //重写Equals方法
        public override bool Equals(object obj)
        {
            if (obj == null ||this.GetType() != obj.GetType()) { return false; }
            Order compare=(Order)obj;
            return this.OrderNumber==compare.OrderNumber&&this.Customer==compare.Customer;
        }
        //重写GetHashCode方法
        public override int GetHashCode()
        {
            return  OrderNumber;
        }
        //重写ToString方法
        public override string ToString()
        {
            return $"[订单号:{OrderNumber},客户:{Customer},订单明细：{Details.ToString()}]";
        }
    }
}
