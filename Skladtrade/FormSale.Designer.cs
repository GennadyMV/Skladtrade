namespace Skladtrade
{
    partial class FormSale
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
            this.buttonSaleAdd = new System.Windows.Forms.Button();
            this.listViewSale = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonSaleAdd
            // 
            this.buttonSaleAdd.Location = new System.Drawing.Point(13, 13);
            this.buttonSaleAdd.Name = "buttonSaleAdd";
            this.buttonSaleAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonSaleAdd.TabIndex = 0;
            this.buttonSaleAdd.Text = "Добавить";
            this.buttonSaleAdd.UseVisualStyleBackColor = true;
            this.buttonSaleAdd.Click += new System.EventHandler(this.buttonSaleAdd_Click);
            // 
            // listViewSale
            // 
            this.listViewSale.Location = new System.Drawing.Point(13, 42);
            this.listViewSale.Name = "listViewSale";
            this.listViewSale.Size = new System.Drawing.Size(352, 250);
            this.listViewSale.TabIndex = 1;
            this.listViewSale.UseCompatibleStateImageBehavior = false;
            this.listViewSale.View = System.Windows.Forms.View.List;
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 304);
            this.Controls.Add(this.listViewSale);
            this.Controls.Add(this.buttonSaleAdd);
            this.Name = "FormSale";
            this.Text = "Продажи";
            this.Load += new System.EventHandler(this.FormSale_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaleAdd;
        private System.Windows.Forms.ListView listViewSale;
    }
}