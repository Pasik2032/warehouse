using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{

    public class Order
    {
        [Flags]
        public enum Status
        {
            paid = 1,
            processed = 2, 
            shipped = 4, 
            executed =8
        }
        static int idAll = 0;
        public struct OrderProduct
        {
            public Product product;
            public int count;
            public double price;
        }
        public List<OrderProduct> products;
        public int id;
        public DateTime dataTime;
        public Client client;
        public Status status;
        public double cost;
        public string ProductString
        {
            get
            {
                string a = "";
                for (int i = 0; i < products.Count; i++)
                {
                    a += $"{products[i].product.Name} {products[i].price} шт." + Environment.NewLine;
                }
                return a;
            }
        }

        public Order(List<OrderProduct> products, Client client, double cost)
        {
            this.id = idAll;
            idAll += 1;
            dataTime = DateTime.Now;
            this.client = client;
            this.products = products;
            this.cost = cost;
        }
        public static List<Order> orders= new List<Order>();
        public static void NewOrder(Client client, List<Product> basket, List<int> count)
        {
            List<OrderProduct> products = new List<OrderProduct>();
            double cost = 0;
            for (int i = 0; i < basket.Count; i++)
            {
                OrderProduct a ;
                a.product = basket[i];
                a.price = basket[i].Valuable;
                a.count = count[i];
                basket[i].Quantity -= count[i];
                products.Add(a);
                cost += a.price * a.count;
            }
            Order order = new Order(products, client, cost);
            orders.Add(order);
        }

    }
}
