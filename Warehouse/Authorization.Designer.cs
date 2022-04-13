
namespace Warehouse
{
    partial class Authorization
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
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.entrance = new System.Windows.Forms.Button();
            this.regclient = new System.Windows.Forms.Button();
            this.regseller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.875F);
            this.label2.Location = new System.Drawing.Point(377, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вход";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(285, 196);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(316, 31);
            this.login.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(285, 320);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(316, 31);
            this.password.TabIndex = 4;
            // 
            // entrance
            // 
            this.entrance.Location = new System.Drawing.Point(351, 398);
            this.entrance.Name = "entrance";
            this.entrance.Size = new System.Drawing.Size(179, 67);
            this.entrance.TabIndex = 5;
            this.entrance.Text = "Вход";
            this.entrance.UseVisualStyleBackColor = true;
            this.entrance.Click += new System.EventHandler(this.entrance_Click);
            // 
            // regclient
            // 
            this.regclient.Location = new System.Drawing.Point(745, 434);
            this.regclient.Name = "regclient";
            this.regclient.Size = new System.Drawing.Size(187, 69);
            this.regclient.TabIndex = 6;
            this.regclient.Text = "Регестрация клиента";
            this.regclient.UseVisualStyleBackColor = true;
            this.regclient.Click += new System.EventHandler(this.regclient_Click);
            // 
            // regseller
            // 
            this.regseller.Location = new System.Drawing.Point(41, 434);
            this.regseller.Name = "regseller";
            this.regseller.Size = new System.Drawing.Size(187, 69);
            this.regseller.TabIndex = 7;
            this.regseller.Text = "Регистрация продовца";
            this.regseller.UseVisualStyleBackColor = true;
            this.regseller.Click += new System.EventHandler(this.regseller_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 534);
            this.Controls.Add(this.regseller);
            this.Controls.Add(this.regclient);
            this.Controls.Add(this.entrance);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button entrance;
        private System.Windows.Forms.Button regclient;
        private System.Windows.Forms.Button regseller;
    }
}