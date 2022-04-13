
namespace Warehouse
{
    partial class NewProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.valuable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(233, 58);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(648, 31);
            this.Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Артикул";
            // 
            // cod
            // 
            this.cod.Location = new System.Drawing.Point(216, 174);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(150, 31);
            this.cod.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена";
            // 
            // valuable
            // 
            this.valuable.Location = new System.Drawing.Point(674, 174);
            this.valuable.Name = "valuable";
            this.valuable.Size = new System.Drawing.Size(206, 31);
            this.valuable.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кол-во";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(207, 276);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(128, 31);
            this.quantity.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 57);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(705, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Описание";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(557, 276);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 31);
            this.textBox1.TabIndex = 10;
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 446);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valuable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1028, 517);
            this.MinimumSize = new System.Drawing.Size(1028, 517);
            //this.Name = "NewProduct";
            this.Text = "NewProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox cod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valuable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}