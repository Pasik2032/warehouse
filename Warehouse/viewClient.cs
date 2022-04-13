using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class viewClient : Form
    {
        List<Client> clients;
        public viewClient(List<Client> clients)
        {
            this.clients = clients;
            InitializeComponent();
        }

        /// <summary>
        /// Выбор клиента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строчку с клиентом");
                return;
            }
            
            var selectedOrder = from t in Order.orders
                     where t.client.Email == clients[dataGridView1.SelectedRows[0].Index].Email
                                select t;
            var viweOrders = new ViweOrderSeller(selectedOrder.ToList());
            viweOrders.Show();
        }

        private void viewClient_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < clients.Count; i++)
            {
                var selectedOrder = from t in Order.orders 
                                    where t.client.Email == clients[i].Email
                                    select t;
                double cost = 0;
                foreach (var item in selectedOrder)
                {
                    cost += item.cost;
                }

                dataGridView1.Rows.Add(clients[i].Name, clients[i].Phone, clients[i].Email, clients[i].Address, cost);
            }
           
        }
    }
}
