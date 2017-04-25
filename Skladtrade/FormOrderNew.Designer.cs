namespace Skladtrade
{
    partial class FormOrderNew
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
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxOrderProducts = new System.Windows.Forms.ListBox();
            this.buttonOrderProductAdd = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(92, 12);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(152, 20);
            this.textBoxNumber.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Продукция:";
            // 
            // listBoxOrderProducts
            // 
            this.listBoxOrderProducts.FormattingEnabled = true;
            this.listBoxOrderProducts.Location = new System.Drawing.Point(15, 132);
            this.listBoxOrderProducts.Name = "listBoxOrderProducts";
            this.listBoxOrderProducts.Size = new System.Drawing.Size(229, 95);
            this.listBoxOrderProducts.TabIndex = 5;
            this.listBoxOrderProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxOrderProducts_SelectedIndexChanged);
            // 
            // buttonOrderProductAdd
            // 
            this.buttonOrderProductAdd.Location = new System.Drawing.Point(219, 103);
            this.buttonOrderProductAdd.Name = "buttonOrderProductAdd";
            this.buttonOrderProductAdd.Size = new System.Drawing.Size(25, 23);
            this.buttonOrderProductAdd.TabIndex = 7;
            this.buttonOrderProductAdd.Text = "+";
            this.buttonOrderProductAdd.UseVisualStyleBackColor = true;
            this.buttonOrderProductAdd.Click += new System.EventHandler(this.buttonOrderProductAdd_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(92, 243);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(75, 23);
            this.buttonEnd.TabIndex = 8;
            this.buttonEnd.Text = "Завершить";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(92, 38);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(152, 21);
            this.comboBoxManufacturer.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Поставщик:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Статус:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(92, 65);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(152, 21);
            this.comboBoxStatus.TabIndex = 10;
            // 
            // FormOrderNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 282);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxManufacturer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonOrderProductAdd);
            this.Controls.Add(this.listBoxOrderProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label1);
            this.Name = "FormOrderNew";
            this.Text = "Новый заказ";
            this.Load += new System.EventHandler(this.FormOrderNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxOrderProducts;
        private System.Windows.Forms.Button buttonOrderProductAdd;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}