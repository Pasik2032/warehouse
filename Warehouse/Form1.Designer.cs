
namespace Warehouse
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateCatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateRoorCatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelCatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameCatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateProdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditProdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.TreeToolStripMenuItem,
            this.ProToolStripMenuItem,
            this.CSVToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1500, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MenuActivate += new System.EventHandler(this.menuStrip1_MenuActivate);
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.CreateNewToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(91, 36);
            this.FileToolStripMenuItem.Text = "Файл";
            this.FileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(315, 44);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(315, 44);
            this.saveAsToolStripMenuItem.Text = "Сохранить как";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(315, 44);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // CreateNewToolStripMenuItem
            // 
            this.CreateNewToolStripMenuItem.Name = "CreateNewToolStripMenuItem";
            this.CreateNewToolStripMenuItem.Size = new System.Drawing.Size(315, 44);
            this.CreateNewToolStripMenuItem.Text = "Создать новый";
            this.CreateNewToolStripMenuItem.Click += new System.EventHandler(this.CreateNewToolStripMenuItem_Click);
            // 
            // TreeToolStripMenuItem
            // 
            this.TreeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateCatalogToolStripMenuItem,
            this.CreateRoorCatalogToolStripMenuItem,
            this.DelCatalogToolStripMenuItem,
            this.RenameCatalogToolStripMenuItem});
            this.TreeToolStripMenuItem.Name = "TreeToolStripMenuItem";
            this.TreeToolStripMenuItem.Size = new System.Drawing.Size(119, 36);
            this.TreeToolStripMenuItem.Text = "Каталог";
            // 
            // CreateCatalogToolStripMenuItem
            // 
            this.CreateCatalogToolStripMenuItem.Name = "CreateCatalogToolStripMenuItem";
            this.CreateCatalogToolStripMenuItem.Size = new System.Drawing.Size(440, 44);
            this.CreateCatalogToolStripMenuItem.Text = "Создать каталог";
            this.CreateCatalogToolStripMenuItem.Click += new System.EventHandler(this.SectionToolStripMenuItem_Click);
            // 
            // CreateRoorCatalogToolStripMenuItem
            // 
            this.CreateRoorCatalogToolStripMenuItem.Name = "CreateRoorCatalogToolStripMenuItem";
            this.CreateRoorCatalogToolStripMenuItem.Size = new System.Drawing.Size(440, 44);
            this.CreateRoorCatalogToolStripMenuItem.Text = "Создать корневой каталог";
            this.CreateRoorCatalogToolStripMenuItem.Click += new System.EventHandler(this.rootSectionToolStripMenuItem_Click);
            // 
            // DelCatalogToolStripMenuItem
            // 
            this.DelCatalogToolStripMenuItem.Name = "DelCatalogToolStripMenuItem";
            this.DelCatalogToolStripMenuItem.Size = new System.Drawing.Size(440, 44);
            this.DelCatalogToolStripMenuItem.Text = "Удалить каталог";
            this.DelCatalogToolStripMenuItem.Click += new System.EventHandler(this.DelToolStripMenuItem_Click);
            // 
            // RenameCatalogToolStripMenuItem
            // 
            this.RenameCatalogToolStripMenuItem.Name = "RenameCatalogToolStripMenuItem";
            this.RenameCatalogToolStripMenuItem.Size = new System.Drawing.Size(440, 44);
            this.RenameCatalogToolStripMenuItem.Text = "Переминовать каталог";
            this.RenameCatalogToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // ProToolStripMenuItem
            // 
            this.ProToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateProdToolStripMenuItem,
            this.DelProductToolStripMenuItem,
            this.EditProdToolStripMenuItem});
            this.ProToolStripMenuItem.Name = "ProToolStripMenuItem";
            this.ProToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.ProToolStripMenuItem.Text = "Продукт";
            // 
            // CreateProdToolStripMenuItem
            // 
            this.CreateProdToolStripMenuItem.Name = "CreateProdToolStripMenuItem";
            this.CreateProdToolStripMenuItem.Size = new System.Drawing.Size(407, 44);
            this.CreateProdToolStripMenuItem.Text = "Создать продукт";
            this.CreateProdToolStripMenuItem.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
            // 
            // DelProductToolStripMenuItem
            // 
            this.DelProductToolStripMenuItem.Name = "DelProductToolStripMenuItem";
            this.DelProductToolStripMenuItem.Size = new System.Drawing.Size(407, 44);
            this.DelProductToolStripMenuItem.Text = "Удалить продукт";
            this.DelProductToolStripMenuItem.Click += new System.EventHandler(this.DelProductToolStripMenuItem_Click);
            // 
            // EditProdToolStripMenuItem
            // 
            this.EditProdToolStripMenuItem.Name = "EditProdToolStripMenuItem";
            this.EditProdToolStripMenuItem.Size = new System.Drawing.Size(407, 44);
            this.EditProdToolStripMenuItem.Text = "Редактировать продукт";
            this.EditProdToolStripMenuItem.Click += new System.EventHandler(this.EditProdToolStripMenuItem_Click);
            // 
            // CSVToolStripMenuItem
            // 
            this.CSVToolStripMenuItem.Name = "CSVToolStripMenuItem";
            this.CSVToolStripMenuItem.Size = new System.Drawing.Size(268, 36);
            this.CSVToolStripMenuItem.Text = "Сформировать отчет";
            this.CSVToolStripMenuItem.Click += new System.EventHandler(this.CSVToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 40);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(335, 934);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.cod,
            this.Quantity,
            this.Price,
            this.Description});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(335, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1165, 934);
            this.dataGridView1.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.HeaderText = "Название";
            this.Name.MinimumWidth = 10;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // cod
            // 
            this.cod.HeaderText = "Артикул";
            this.cod.MinimumWidth = 10;
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Количество";
            this.Quantity.MinimumWidth = 10;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.MinimumWidth = 10;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание";
            this.Description.MinimumWidth = 10;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Json files(*.json)|*.json";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Json files(*.json)|*.json";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "CSV files(*.csv)|*.csv";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Location = new System.Drawing.Point(335, 949);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1165, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 974);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            //this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.ToolStripMenuItem TreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateCatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateRoorCatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelCatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenameCatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateProdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateNewToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CSVToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem EditProdToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

