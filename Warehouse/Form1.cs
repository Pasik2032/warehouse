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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Seller seller;
        /// <summary>
        /// Загрузка с продовца, создаем кнопки необходимые для него.
        /// </summary>
        /// <param name="seller">Акаунт продовца.</param>
        public Form1(Seller seller)
        {
            InitializeComponent();
            this.seller = seller;
            ToolStripButton viweClient = new ToolStripButton();
            viweClient.Text = "Просмотр клиентов";
            viweClient.Click += ViweClientClient;
            toolStrip1.Items.Add(viweClient);
            ToolStripButton viweAllOrder = new ToolStripButton();
            viweAllOrder.Text = "Просмотр всех заказов";
            viweAllOrder.Click += ViweAllOrederClick;
            toolStrip1.Items.Add(viweAllOrder);
            ToolStripButton viweOrder = new ToolStripButton();
            viweOrder.Text = "Просмотр активных заказов";
            viweOrder.Click += ViweOrederClick;
            toolStrip1.Items.Add(viweOrder);
        }

        /// <summary>
        /// Вывод активных заказов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ViweOrederClick(object sender, EventArgs e)
        {
            var b = from o in Order.orders
                    where (int)o.status < 8
                    select o;
            var a = new ViweOrderSeller(b.ToList());
            a.Show();
        }

        /// <summary>
        /// Вывод всех заказов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ViweAllOrederClick(object sender, EventArgs e)
        {
            var a = new ViweOrderSeller(Order.orders);
            a.Show();

        }

        /// <summary>
        /// Выводж клиентов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ViweClientClient(object sender, EventArgs e)
        {
            var a = new viewClient(Client.clients);
            a.Show();
        }

        /// <summary>
        /// Товар в корзине.
        /// </summary>
        public struct ProdBasket
        {
            // Сам товар.
            public Product product;
            //Его количество.
            public int count;
        }
        List<ProdBasket> basket;
        Client client;
        /// <summary>
        /// Загрузка из под клиента, прогрузка всех его кнопок и блокировка изменение склада.
        /// </summary>
        /// <param name="client">Акаунт клиента.</param>
        public Form1(Client client)
        {
            this.client = client;
            InitializeComponent();
            ToolStripButton add = new ToolStripButton();
            add.Text = "Добавить в корзину";
            add.Click += addProd;
            toolStrip1.Items.Add(add);
            ToolStripButton place = new ToolStripButton();
            place.Text = "Оформить заказ";
            place.Click += PlaceAnOrder;
            toolStrip1.Items.Add(place);
            ToolStripButton listOrd = new ToolStripButton();
            listOrd.Text = "Посмотреть список заказов";
            listOrd.Click += ViewOrder;
            toolStrip1.Items.Add(listOrd);
            TreeToolStripMenuItem.Enabled = false;
            ProToolStripMenuItem.Enabled = false;
            CSVToolStripMenuItem.Enabled = false;
            FileToolStripMenuItem.Enabled = false;
            basket = new List<ProdBasket>();
        }

        /// <summary>
        /// Показать все товары этого клиента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ViewOrder(object sender, EventArgs e)
        {
            var b = from o in Order.orders
                    where o.client == client
                    select o;
            ViwerOrder view = new ViwerOrder(b.ToList());
            view.ShowDialog();
        }
        /// <summary>
        /// Оформление заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PlaceAnOrder(object sender, EventArgs e)
        {
            List<Product> productsbas = new List<Product>();
            List<int> count = new List<int>();
            for (int i = 0; i < basket.Count; i++)
            {
                productsbas.Add(basket[i].product);
                count.Add(basket[i].count);
            }
            Order.NewOrder(client, productsbas, count);
            basket.Clear();
            MessageBox.Show("Заказ успешно оформлен.");
        }

        /// <summary>
        /// Добавление товара в корзину.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addProd(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    InputCount input = new InputCount();

                    while (true)
                    {
                        input.ShowDialog();
                        if (!input.isOk) { break; }
                        try
                        {
                            if (((Section)treeView1.SelectedNode.Tag).products[dataGridView1.SelectedRows[i].Index].Quantity - input.Count < 0)
                            {
                                MessageBox.Show("К сожалению товара на складе не достаточно");
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message);
                        }
                    }
                    input.isOk = false;
                    ProdBasket bas = new ProdBasket();
                    bas.product = ((Section)treeView1.SelectedNode.Tag).products[dataGridView1.SelectedRows[i].Index];
                    bas.count = input.Count;
                    basket.Add(bas);
                }
            }
            else
            {
                MessageBox.Show("Не выделен не один товар, необходимо выделить строчку с товаром, который вы хотите добавить в корзину");
            }

        }

        //путь к открытому файлу.
        string path;
        // List с узлами для сериализации.
        List<Section> sections = new List<Section>();

        /// <summary>
        /// Создание нового раздела.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var input = new CreateSelection();
            TreeNode tovarNode;
            while (true)
            {
                input.ShowDialog();
                tovarNode = new TreeNode(input.Input);
                Section a = new Section(input.Input);
                tovarNode.Tag = a;
                if (input.isOk)
                {
                    if (treeView1.SelectedNode == null)
                    {
                        treeView1.Nodes.Add(tovarNode);
                        break;
                    }
                    bool rename = false;
                    for (int i = 0; i < treeView1.SelectedNode.GetNodeCount(false); i++)
                    {
                        if (treeView1.SelectedNode.Nodes[i].Text == input.Input)
                        {
                            rename = true;
                        }
                    }
                    if (rename)
                    {
                        MessageBox.Show("Каталог с этим именем уже существует в этом разделе");
                        continue;
                    }
                    treeView1.SelectedNode.Nodes.Add(tovarNode);
                    break;
                }
                else
                {
                    break;
                }
            }
            NewSection(tovarNode);
        }

        /// <summary>
        /// Создание раздела.
        /// </summary>
        /// <param name="tovarNode">Узел в котором надо создать раздел.</param>
        private void NewSection(TreeNode tovarNode)
        {
            List<TreeNode> item = new List<TreeNode>();
            TreeNode parent = tovarNode;
            while (parent != null)
            {
                item.Add(parent);
                parent = parent.Parent;
            }
            List<Section> find = sections;
            for (int i = item.Count - 1; i > 0; i--)
            {
                for (int j = 0; j < find.Count; j++)
                {
                    if (find[j] == item[i].Tag)
                    {
                        find = find[j].sections;
                        break;
                    }
                }
            }
            find.Add((Section)tovarNode.Tag);
        }

        /// <summary>
        /// Метод добавляет новый товар.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var input = new NewProduct();
            while (true)
            {
                input.isOk = false;
                input.ShowDialog();
                if (input.isOk)
                {
                    try
                    {
                        bool recod = false;
                        bool rename = false;
                        for (int i = 0; i < ((Section)treeView1.SelectedNode.Tag).products.Count; i++)
                        {
                            if (((Section)treeView1.SelectedNode.Tag).products[i].Name == input.NameProd)
                            {
                                rename = true;
                                MessageBox.Show("Товар с таким именем уже существует");
                            }
                        }
                        for (int i = 0; i < Product.products.Count; i++)
                        {
                            if (Product.products[i].Cod == input.CodProd)
                            {
                                recod = true;
                                MessageBox.Show("Товар с таким артикулом уже существыет");
                            }
                        }
                        if (rename || recod)
                            continue;
                        else
                        {
                            var a = new Product(input.NameProd, input.CodProd, input.ValuableProd, input.QuantityProd, input.DescriptionProd, treeView1.SelectedNode.FullPath);
                            Product.products.Add(a);
                            ((Section)treeView1.SelectedNode.Tag).products.Add(a);
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    break;
                }
            }

            Ubdate();
        }

        /// <summary>
        /// Открытие последнего склада с которой вы работали при запуске программы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                //--------------------------------------------
                using (StreamReader fs = new StreamReader("seting.txt"))
                {
                    path = fs.ReadLine();
                }
                string json;
                using (StreamReader sr = new StreamReader(path))
                {
                    json = sr.ReadLine();
                }
                sections.Clear();
                treeView1.Nodes.Clear();
                dataGridView1.Rows.Clear();
                sections = JsonConvert.DeserializeObject<List<Section>>(json);
                Deserialize(sections, treeView1.Nodes);
            }
            catch (Exception)
            { }

        }

        /// <summary>
        /// Рекурсивный метод десериализации.
        /// </summary>
        /// <param name="sec">Лист содержащий подразделы этого раздела.</param>
        /// <param name="tree">текущий раздел.</param>
        private void Deserialize(List<Section> sec, TreeNodeCollection tree)
        {
            for (int i = 0; i < sec.Count; i++)
            {
                TreeNode a = new TreeNode(sec[i].Name);
                a.Tag = sec[i];
                if (sec[i].sections.Count != 0)
                {
                    Deserialize(sec[i].sections, a.Nodes);
                }
                tree.Add(a);
                for (int j = 0; j < sec[i].products.Count; j++)
                {
                    Product.products.Add(sec[i].products[j]);
                }
            }
        }

        /// <summary>
        /// Сохранение склада при закрытие формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (path == null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string path = saveFileDialog1.FileName;
            }
            Serial(path);
            try
            {
                using (StreamWriter fs = new StreamWriter("seting.txt"))
                {
                    fs.Write(path);
                }
            }
            catch (Exception) { }
            //-------------------------------------------
            try
            {

                string orders = JsonConvert.SerializeObject(Order.orders);
                string clients = JsonConvert.SerializeObject(Client.clients);
                string sellers = JsonConvert.SerializeObject(Seller.sellers);
                using (StreamWriter fs = new StreamWriter("Orders.json"))
                {
                    fs.Write(orders);
                }
                using (StreamWriter fs = new StreamWriter("Clients.json"))
                {
                    fs.Write(clients);
                }
                using (StreamWriter fs = new StreamWriter("Sellers.json"))
                {
                    fs.Write(sellers);
                }
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Сериализация.
        /// </summary>
        /// <param name="path">Путь для сериализации.</param>
        private void Serial(string path)
        {
            try
            {

                string json = JsonConvert.SerializeObject(sections);
                using (StreamWriter fs = new StreamWriter(path))
                {
                    fs.Write(json);
                }
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Создание корневого каталога.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rootSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var input = new CreateSelection();
            TreeNode tovarNode;
            while (true)
            {
                input.ShowDialog();
                tovarNode = new TreeNode(input.Input);
                Section a = new Section(input.Input);
                tovarNode.Tag = a;
                if (input.isOk)
                {
                    bool rename = false;
                    for (int i = 0; i < treeView1.GetNodeCount(false); i++)
                    {
                        if (treeView1.Nodes[i].Text == input.Input)
                        {
                            rename = true;
                        }
                    }
                    if (rename)
                    {
                        MessageBox.Show("Каталог с этим именем уже существует в этом разделе");
                        continue;
                    }
                    treeView1.Nodes.Add(tovarNode);
                    break;
                }
                else
                {
                    break;
                }
            }
            NewSection(tovarNode);
        }

        /// <summary>
        /// Удаление каталога.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.GetNodeCount(false) == 0 && ((Section)treeView1.SelectedNode.Tag).products.Count == 0)
            {
                if (treeView1.SelectedNode.Parent != null)
                {
                    DelSection(treeView1.SelectedNode);
                    treeView1.SelectedNode.Parent.Nodes.Remove(treeView1.SelectedNode);
                }
                else
                {
                    DelSection(treeView1.SelectedNode);
                    treeView1.Nodes.Remove(treeView1.SelectedNode);
                }
            }
            else
            {
                MessageBox.Show("Нельзя удалять каталоги к которых есть раздели или товары");
            }
        }

        /// <summary>
        /// Удаление раздела.
        /// </summary>
        /// <param name="tovarNode">Раздел для удаление.</param>
        private void DelSection(TreeNode tovarNode)
        {
            List<TreeNode> item = new List<TreeNode>();
            TreeNode parent = tovarNode;
            while (parent != null)
            {
                item.Add(parent);
                parent = parent.Parent;
            }
            List<Section> find = sections;
            for (int i = item.Count - 1; i > 0; i--)
            {
                for (int j = 0; j < find.Count; j++)
                {
                    if (find[j] == item[i].Tag)
                    {
                        find = find[j].sections;
                        break;
                    }
                }
            }
            find.Remove((Section)tovarNode.Tag);
        }

        /// <summary>
        /// Переминование раздела.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var input = new CreateSelection();
            while (true)
            {
                input.ShowDialog();
                if (input.isOk)
                {
                    if (treeView1.SelectedNode == null)
                    {
                        break;
                    }
                    bool rename = false;
                    for (int i = 0; i < treeView1.SelectedNode.GetNodeCount(false); i++)
                    {
                        if (treeView1.SelectedNode.Nodes[i].Text == input.Input)
                        {
                            rename = true;
                            break;
                        }
                    }
                    if (rename)
                    {
                        MessageBox.Show("Каталог с этим именем уже существует в этом разделе");
                        continue;
                    }
                    treeView1.SelectedNode.Text = input.Input;
                    ((Section)treeView1.SelectedNode.Tag).Name = input.Input;
                    break;
                }
                else
                {
                    break;
                }
            }
        }

        /// <summary>
        /// При выборе раздела перерисовывается таблица.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Ubdate();
        }

        /// <summary>
        /// Перересовывается таблица.
        /// </summary>
        private void Ubdate()
        {
            dataGridView1.Rows.Clear();
            if (((Section)treeView1.SelectedNode.Tag).products.Count != 0)
            {
                for (int i = 0; i < ((Section)treeView1.SelectedNode.Tag).products.Count; i++)
                {
                    dataGridView1.Rows.Add(((Section)treeView1.SelectedNode.Tag).products[i].Name,
                        ((Section)treeView1.SelectedNode.Tag).products[i].Cod,
                        ((Section)treeView1.SelectedNode.Tag).products[i].Quantity,
                        ((Section)treeView1.SelectedNode.Tag).products[i].Valuable,
                        ((Section)treeView1.SelectedNode.Tag).products[i].Description);
                }
            }
        }

        /// <summary>
        /// Удаление продукта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                ((Section)treeView1.SelectedNode.Tag).products.RemoveAt(dataGridView1.SelectedRows[i].Index);
            }
            Ubdate();
        }

        /// <summary>
        /// Открытие сохраненного файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sections.Count != 0)
            {
                DialogResult result = MessageBox.Show("Сохранить изменение ?", "Сохранение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (path == null)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                            return;
                        path = saveFileDialog1.FileName;
                    }
                    Serial(path);
                }
            }

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            path = openFileDialog1.FileName;
            try
            {
                string json;


                using (StreamReader sr = new StreamReader(path))
                {
                    json = sr.ReadLine();
                }
                sections.Clear();
                treeView1.Nodes.Clear();
                dataGridView1.Rows.Clear();
                sections = JsonConvert.DeserializeObject<List<Section>>(json);
                Deserialize(sections, treeView1.Nodes);
            }
            catch (Exception)
            { }
        }

        /// <summary>
        /// Сохрание.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                path = saveFileDialog1.FileName;
            }
            Serial(path);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            path = saveFileDialog1.FileName;
            Serial(path);
        }

        /// <summary>
        /// Создание нового склада.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sections.Count != 0)
            {
                DialogResult result = MessageBox.Show("Сохранить изменение ?", "Сохранение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (path == null)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                            return;
                        path = saveFileDialog1.FileName;
                    }
                    Serial(path);
                }
            }
            path = null;
            sections.Clear();
            treeView1.Nodes.Clear();
            dataGridView1.Rows.Clear();
        }

        /// <summary>
        /// Формирование CSV отчета.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int quantity;
            var input = new CSV();
            while (true)
            {
                input.ShowDialog();
                if (input.isOk)
                {
                    try
                    {
                        quantity = input.Quantity;
                        break;
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
                        continue;
                    }
                }
                else
                {
                    return;
                }
            }
            if (saveFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                using (StreamWriter fs = new StreamWriter(saveFileDialog2.FileName))
                {
                    fs.WriteLine("путь_классификатора;артикул;название товара;количество на складе");
                    for (int i = 0; i < Product.products.Count; i++)
                    {

                        if (Product.products[i] == null)
                        {
                            Product.products.RemoveAt(i);
                            continue;
                        }
                        if (Product.products[i].Quantity < quantity)
                        {

                            fs.WriteLine(Product.products[i]);

                        }
                    }
                }
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Редактирование продукта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditProdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                var a = new NewProduct();
                a.NameProd = ((Section)treeView1.SelectedNode.Tag).products[dataGridView1.SelectedRows[i].Index].Name;
                a.CodProd = ((Section)treeView1.SelectedNode.Tag).products[dataGridView1.SelectedRows[i].Index].Cod;
                a.DescriptionProd = ((Section)treeView1.SelectedNode.Tag).products[dataGridView1.SelectedRows[i].Index].Description;
                a.QuantityProd = ((Section)treeView1.SelectedNode.Tag).products[dataGridView1.SelectedRows[i].Index].Quantity;
                a.ValuableProd = ((Section)treeView1.SelectedNode.Tag).products[dataGridView1.SelectedRows[i].Index].Valuable;
                while (true)
                {
                    a.isOk = false;
                    a.ShowDialog();
                    if (a.isOk)
                    {
                        try
                        {
                            bool rename = false;
                            for (int j = 0; j < ((Section)treeView1.SelectedNode.Tag).products.Count; j++)
                            {
                                if (((Section)treeView1.SelectedNode.Tag).products[j].Name == a.NameProd && ((Section)treeView1.SelectedNode.Tag).products[j] != ((Section)treeView1.SelectedNode.Tag).products[dataGridView1.SelectedRows[i].Index])
                                {
                                    rename = true;
                                    MessageBox.Show("Товар с таким именем уже существует");
                                }
                            }
                            if (rename)
                                continue;
                            else
                            {
                                ((Section)treeView1.SelectedNode.Tag).products[dataGridView1.SelectedRows[i].Index].Name = a.NameProd;
                                ((Section)treeView1.SelectedNode.Tag).products[dataGridView1.SelectedRows[i].Index].Cod = a.CodProd;
                                ((Section)treeView1.SelectedNode.Tag).products[dataGridView1.SelectedRows[i].Index].Description = a.DescriptionProd;
                                ((Section)treeView1.SelectedNode.Tag).products[dataGridView1.SelectedRows[i].Index].Quantity = a.QuantityProd;
                                ((Section)treeView1.SelectedNode.Tag).products[dataGridView1.SelectedRows[i].Index].Valuable = a.ValuableProd;
                                break;
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Ubdate();
        }



        /// <summary>
        /// Делает элементы не активными.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStrip1_MenuActivate(object sender, EventArgs e)
        {
            saveAsToolStripMenuItem.Enabled = true;
            SaveToolStripMenuItem.Enabled = true;
            if (sections.Count == 0)
            {
                saveAsToolStripMenuItem.Enabled = false;
                SaveToolStripMenuItem.Enabled = false;
            }
            DelCatalogToolStripMenuItem.Enabled = true;
            RenameCatalogToolStripMenuItem.Enabled = true;
            if (treeView1.SelectedNode == null)
            {
                DelCatalogToolStripMenuItem.Enabled = false;
                RenameCatalogToolStripMenuItem.Enabled = false;
            }
            if (treeView1.SelectedNode == null || treeView1.SelectedNode.GetNodeCount(false) != 0 || ((Section)treeView1.SelectedNode.Tag).products.Count != 0)
            {
                DelCatalogToolStripMenuItem.Enabled = false;
            }
            EditProdToolStripMenuItem.Enabled = true;
            DelProductToolStripMenuItem.Enabled = true;
            CreateProdToolStripMenuItem.Enabled = true;
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.SelectedRows[dataGridView1.SelectedRows.Count - 1].Cells[0] == null)
            {
                DelProductToolStripMenuItem.Enabled = false;
                EditProdToolStripMenuItem.Enabled = false;
            }
            if (sections.Count == 0)
            {
                CreateProdToolStripMenuItem.Enabled = false;
            }
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
