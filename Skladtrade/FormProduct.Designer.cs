namespace Skladtrade
{
    partial class FormProduct
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonProductAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(487, 285);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // buttonProductAdd
            // 
            this.buttonProductAdd.Location = new System.Drawing.Point(12, 12);
            this.buttonProductAdd.Name = "buttonProductAdd";
            this.buttonProductAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonProductAdd.TabIndex = 1;
            this.buttonProductAdd.Text = "Добавить";
            this.buttonProductAdd.UseVisualStyleBackColor = true;
            this.buttonProductAdd.Click += new System.EventHandler(this.buttonProductAdd_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 344);
            this.Controls.Add(this.buttonProductAdd);
            this.Controls.Add(this.listView1);
            this.Name = "FormProduct";
            this.Text = "Продукция";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonProductAdd;
    }
}