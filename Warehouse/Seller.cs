using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Seller
    {
        public static List<Seller> sellers = new List<Seller>(); 
        public string name;
        public string email;
        public string password;

        public Seller(string name, string email, string password)
        {
            this.name = name;
            this.email = email;
            this.password = password;
        }
        public static bool NewSeller(string name, string email, string password)
        {
            if ((from n in sellers where n.email == email select n).Count() == 0)
            {
                sellers.Add(new Seller(name,  email, password));
                return true;
            }
            return false;
        }
    }
}
