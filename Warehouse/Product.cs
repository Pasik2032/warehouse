using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    
    public class Product
    {
        public static List<Product> products= new List<Product>();
        public string Name { get; set; }
        public string Cod { get; set; }
        public double Valuable { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public string path;

        public Product(string name, string cod, double valuable, int quantity, string description, string path)
        {
            Name = name;
            Cod = cod;
            Valuable = valuable;
            Quantity = quantity;
            Description = description;
            this.path = path;
        }

        public override string ToString()
        {
            return $"{path};{Cod};{Name};{Quantity}";
        }


    }
}
