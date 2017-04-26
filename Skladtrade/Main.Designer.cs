namespace Skladtrade
{
    partial class Main
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
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProducts
            // 
            this.buttonProducts.Location = new System.Drawing.Point(47, 60);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(108, 63);
            this.buttonProducts.TabIndex = 0;
            this.buttonProducts.Text = "Продукция";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Location = new System.Drawing.Point(222, 60);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(108, 63);
            this.buttonOrders.TabIndex = 0;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 63);
            this.button2.TabIndex = 0;
            this.button2.Text = "Продажи";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonProducts);
            this.Name = "Main";
            this.Text = "Торгово-закупочные операции";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

