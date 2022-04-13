using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Регистрация клиента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void regclient_Click(object sender, EventArgs e)
        {
            RegClient win = new RegClient();
            while (true)
            {
                try
                {
                    win.ShowDialog();
                    break;
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Регистрация продовца.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void regseller_Click(object sender, EventArgs e)
        {
            RegSeller win = new RegSeller();
            while (true)
            {
                try
                {
                    win.ShowDialog();
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public Seller seller;

        /// <summary>
        /// Вход в систему.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void entrance_Click(object sender, EventArgs e)
        {
            var a = from c in Client.clients
                               where c.Email == login.Text && c.Password == password.Text
                                select c; 
            if (a.Count() == 0)
            {
                var b = from c in Seller.sellers
                        where c.email == login.Text && c.password == password.Text
                        select c;
                if (b.Count() == 0)
                {
                    MessageBox.Show("Неверно введен пароль или логин");
                }
                else
                {
                    seller = b.First();
                    Form1 form = new Form1(seller);
                    form.ShowDialog();

                }
            }
            else
            {
                Client client = a.First();
                Form1 form = new Form1(client);
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Десериализация.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Authorization_Load(object sender, EventArgs e)
        {
            try
            {
                string orders;
                string sellers;
                string clients;
                using (StreamReader sr = new StreamReader("Orders.json"))
                {
                    orders = sr.ReadLine();
                }
                Order.orders = JsonConvert.DeserializeObject<List<Order>>(orders);
                using (StreamReader sr = new StreamReader("Clients.json"))
                {
                    clients = sr.ReadLine();
                }
                Client.clients = JsonConvert.DeserializeObject<List<Client>>(clients);
                using (StreamReader sr = new StreamReader("Sellers.json"))
                {
                    sellers = sr.ReadLine();
                }
                Seller.sellers = JsonConvert.DeserializeObject<List<Seller>>(sellers);
            }
            catch (Exception) { }

        }
    }
}
