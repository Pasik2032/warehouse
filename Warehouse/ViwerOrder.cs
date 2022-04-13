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
    public partial class ViwerOrder : Form
    {
        List<Order> orders;
        public ViwerOrder(List<Order> orders)
        {
            InitializeComponent();
            this.orders = orders;
        }

        /// <summary>
        /// Загруска данных в таблицу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViwerOrder_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                dataGridView1.Rows.Add(orders[i].id, orders[i].dataTime, orders[i].ProductString, orders[i].cost, orders[i].status);
            }
        }

        /// <summary>
        /// Оплата товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pay_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                orders[dataGridView1.SelectedRows[i].Index].status = Order.Status.paid;
            }
            dataGridView1.Rows.Clear();
            ViwerOrder_Load(sender, e);
        }
    }
}
