
namespace Warehouse
{
    partial class ViwerOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pay = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.dateTime,
            this.Product,
            this.Cost,
            this.Status});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Orchid;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 782);
            this.dataGridView1.TabIndex = 0;
            // 
            // Pay
            // 
            this.Pay.Location = new System.Drawing.Point(1035, 713);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(239, 69);
            this.Pay.TabIndex = 1;
            this.Pay.Text = "Оплатить";
            this.Pay.UseVisualStyleBackColor = true;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер заказа";
            this.Number.MinimumWidth = 10;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 200;
            // 
            // dateTime
            // 
            this.dateTime.HeaderText = "Дата и время заказа";
            this.dateTime.MinimumWidth = 10;
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            this.dateTime.Width = 200;
            // 
            // Product
            // 
            this.Product.HeaderText = "Товары";
            this.Product.MinimumWidth = 10;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 200;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Стоимость";
            this.Cost.MinimumWidth = 10;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 200;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.MinimumWidth = 10;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 200;
            // 
            // ViwerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 782);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViwerOrder";
            this.Text = "ViwerOrder";
            this.Load += new System.EventHandler(this.ViwerOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}