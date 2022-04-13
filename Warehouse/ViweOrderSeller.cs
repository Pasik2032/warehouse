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
    public partial class ViweOrderSeller : Form
    {
        List<Order> orders = new List<Order>();
        public ViweOrderSeller(List<Order> orders)
        {
            this.orders = orders;
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка данных в таблицу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViweOrderSeller_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                dataGridView1.Rows.Add(orders[i].id, orders[i].dataTime.ToString(), orders[i].ProductString, orders[i].cost, orders[i].status.ToString());
            }
        }

        /// <summary>
        /// Изменение статуса заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == null)
            {
                MessageBox.Show("Вы нечего не выбрали");
                return;
            }
            if(dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Вы не выбрали заказ, которому хотите изменить статус");
                return;
            }

            orders[dataGridView1.SelectedRows[0].Index].status = orders[dataGridView1.SelectedRows[0].Index].status | (Order.Status)Math.Pow(2,comboBox1.SelectedIndex+1);
            dataGridView1.Rows.Clear();
            ViweOrderSeller_Load(sender, e);
        }
    }
}
