using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public  class Program
    {
        static void Main(string[] args)
        {
            //创建订单服务类
            OrderService orderService = new OrderService();
            //添加订单
            Order order1 = new Order("张三",1, new OrderDetails("商品1", 10, 2));
            Order order2 = new Order("李四",2, new OrderDetails("商品2", 30, 3));
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.ShowAllOrder();
            //查询订单
            Console.WriteLine("按照订单号查询：");
            Order order = orderService.GetOrderbyOrderNumber(1);
            Console.WriteLine(order);
            Console.WriteLine();
            Console.WriteLine("按照客户查询：");
            foreach (Order o in orderService.GetOrderbyCustomer("李四"))
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();
            Console.WriteLine("按照商品名称查询：");
            foreach (Order o in orderService.GetOrderbyGoodsName("商品1"))
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();
            Console.WriteLine("按照订单金额范围查询：");
            foreach (Order o in orderService.GetOrderbyMoney(10,100))
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();
            // 修改订单
            Console.WriteLine("修改订单：");
            Order newOrder = new Order("王五",1,  new OrderDetails("商品1", 10, 2));
            orderService.ModifyOrder(newOrder);
            orderService.SortOrder();
            order = orderService.GetOrderbyOrderNumber(1);
            Console.WriteLine(order);
            Console.WriteLine();
            Console.WriteLine("修改后的订单：");
            orderService.ShowAllOrder();
            //删除订单
            Console.WriteLine("删除订单：");
            Order order3 = orderService.GetOrderbyOrderNumber(2);
            orderService.DeleteOrder(order3);
            orderService.ShowAllOrder();
        }
    }
}
