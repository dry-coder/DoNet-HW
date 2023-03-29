using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public  class OrderDetails
    {
       public string GoodsName { get; set; }
        public double Price { get; set; }
        public int Num { get; set; }
        public OrderDetails(string goods,double price,int num)
        {
            GoodsName=goods;
            Price=price;
            Num=num;
        }
        //重写Equals方法
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            OrderDetails other = (OrderDetails)obj;
            return GoodsName==other.GoodsName && Price==other.Price && Num==other.Num;
        }
        //重写GetHashCode方法
        public override int GetHashCode()
        {
            return (int)Price;
        }
        //重写ToString方法
        public override string ToString()
        {
            return $"(商品名称：{GoodsName},单价：{Price}，商品数量{Num},订单总金额：{Price*Num})";
        }

    }
}
