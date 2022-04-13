using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Client
    {
        public static List<Client> clients = new List<Client>();
        string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        string phone;
        public string Phone
        {
            get
            {
                return phone;
            }
        }
        string address;
        public string Address
        {
            get
            {
                return address;
            }
        }
        string email;
        public string Email
        {
            get
            {
                return email;
            }
        }
        string password;
        public string Password
        {
            get
            {
                return password;
            }
        }
        List<Order> orders;

        public Client(string name, string phone, string address, string email, string password)
        {
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.email = email;
            this.password = password;
            orders = new List<Order>();
        }
        public static bool NewClient(string name, string phone, string address, string email, string password) 
        {
            if ((from n in clients where n.email == email select n).Count() == 0)
            {
                clients.Add(new Client(name, phone, address, email, password));
                return true;
            }
            return false;
        }
    }
}
