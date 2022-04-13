
namespace Warehouse
{
    partial class RegSeller
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Reg = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.875F);
            this.label1.Location = new System.Drawing.Point(173, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация продовца";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Имя";
            // 
            // Reg
            // 
            this.Reg.Location = new System.Drawing.Point(289, 304);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(227, 63);
            this.Reg.TabIndex = 4;
            this.Reg.Text = "Зарегистророваться";
            this.Reg.UseVisualStyleBackColor = true;
            this.Reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(237, 118);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(370, 31);
            this.name.TabIndex = 5;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(237, 182);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(370, 31);
            this.email.TabIndex = 6;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(237, 238);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(370, 31);
            this.password.TabIndex = 7;
            // 
            // RegSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Reg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(826, 469);
            this.MinimumSize = new System.Drawing.Size(826, 469);
            this.Name = "RegSeller";
            this.Text = "RegSeller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reg;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
    }
}