namespace Skladtrade
{
    partial class FormOrder
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
            this.buttonOrderNew = new System.Windows.Forms.Button();
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.buttonOrderDelivery = new System.Windows.Forms.Button();
            this.buttonOrderClose = new System.Windows.Forms.Button();
            this.buttonStore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOrderNew
            // 
            this.buttonOrderNew.Location = new System.Drawing.Point(12, 12);
            this.buttonOrderNew.Name = "buttonOrderNew";
            this.buttonOrderNew.Size = new System.Drawing.Size(75, 23);
            this.buttonOrderNew.TabIndex = 0;
            this.buttonOrderNew.Text = "Добавить";
            this.buttonOrderNew.UseVisualStyleBackColor = true;
            this.buttonOrderNew.Click += new System.EventHandler(this.buttonOrderNew_Click);
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.Location = new System.Drawing.Point(12, 41);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(362, 303);
            this.listBoxOrders.TabIndex = 1;
            // 
            // buttonOrderDelivery
            // 
            this.buttonOrderDelivery.Location = new System.Drawing.Point(112, 12);
            this.buttonOrderDelivery.Name = "buttonOrderDelivery";
            this.buttonOrderDelivery.Size = new System.Drawing.Size(75, 23);
            this.buttonOrderDelivery.TabIndex = 2;
            this.buttonOrderDelivery.Text = "Получен";
            this.buttonOrderDelivery.UseVisualStyleBackColor = true;
            this.buttonOrderDelivery.Click += new System.EventHandler(this.buttonOrderDelivery_Click);
            // 
            // buttonOrderClose
            // 
            this.buttonOrderClose.Location = new System.Drawing.Point(193, 12);
            this.buttonOrderClose.Name = "buttonOrderClose";
            this.buttonOrderClose.Size = new System.Drawing.Size(75, 23);
            this.buttonOrderClose.TabIndex = 3;
            this.buttonOrderClose.Text = "Закрыт";
            this.buttonOrderClose.UseVisualStyleBackColor = true;
            this.buttonOrderClose.Click += new System.EventHandler(this.buttonOrderClose_Click);
            // 
            // buttonStore
            // 
            this.buttonStore.Location = new System.Drawing.Point(299, 12);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Size = new System.Drawing.Size(75, 23);
            this.buttonStore.TabIndex = 4;
            this.buttonStore.Text = "Склад";
            this.buttonStore.UseVisualStyleBackColor = true;
            this.buttonStore.Click += new System.EventHandler(this.buttonStore_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 357);
            this.Controls.Add(this.buttonStore);
            this.Controls.Add(this.buttonOrderClose);
            this.Controls.Add(this.buttonOrderDelivery);
            this.Controls.Add(this.listBoxOrders);
            this.Controls.Add(this.buttonOrderNew);
            this.Name = "FormOrder";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOrderNew;
        private System.Windows.Forms.ListBox listBoxOrders;
        private System.Windows.Forms.Button buttonOrderDelivery;
        private System.Windows.Forms.Button buttonOrderClose;
        private System.Windows.Forms.Button buttonStore;
    }
}