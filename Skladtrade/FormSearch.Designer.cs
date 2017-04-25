namespace Skladtrade
{
    partial class FormSearch
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
            this.radioButtonSearchCategory = new System.Windows.Forms.RadioButton();
            this.radioButtonSearchManufacturer = new System.Windows.Forms.RadioButton();
            this.radioButtonSearchPrice = new System.Windows.Forms.RadioButton();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxSearchResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButtonSearchCategory
            // 
            this.radioButtonSearchCategory.AutoSize = true;
            this.radioButtonSearchCategory.Location = new System.Drawing.Point(12, 12);
            this.radioButtonSearchCategory.Name = "radioButtonSearchCategory";
            this.radioButtonSearchCategory.Size = new System.Drawing.Size(94, 17);
            this.radioButtonSearchCategory.TabIndex = 0;
            this.radioButtonSearchCategory.TabStop = true;
            this.radioButtonSearchCategory.Text = "По категории";
            this.radioButtonSearchCategory.UseVisualStyleBackColor = true;
            // 
            // radioButtonSearchManufacturer
            // 
            this.radioButtonSearchManufacturer.AutoSize = true;
            this.radioButtonSearchManufacturer.Location = new System.Drawing.Point(12, 48);
            this.radioButtonSearchManufacturer.Name = "radioButtonSearchManufacturer";
            this.radioButtonSearchManufacturer.Size = new System.Drawing.Size(121, 17);
            this.radioButtonSearchManufacturer.TabIndex = 0;
            this.radioButtonSearchManufacturer.TabStop = true;
            this.radioButtonSearchManufacturer.Text = "По производителю";
            this.radioButtonSearchManufacturer.UseVisualStyleBackColor = true;
            // 
            // radioButtonSearchPrice
            // 
            this.radioButtonSearchPrice.AutoSize = true;
            this.radioButtonSearchPrice.Location = new System.Drawing.Point(12, 85);
            this.radioButtonSearchPrice.Name = "radioButtonSearchPrice";
            this.radioButtonSearchPrice.Size = new System.Drawing.Size(125, 17);
            this.radioButtonSearchPrice.TabIndex = 0;
            this.radioButtonSearchPrice.TabStop = true;
            this.radioButtonSearchPrice.Text = "По цене от 0 до 250";
            this.radioButtonSearchPrice.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(163, 11);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(186, 21);
            this.comboBoxCategory.TabIndex = 1;
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(163, 47);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(186, 21);
            this.comboBoxManufacturer.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 126);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBoxSearchResult
            // 
            this.listBoxSearchResult.FormattingEnabled = true;
            this.listBoxSearchResult.Location = new System.Drawing.Point(12, 187);
            this.listBoxSearchResult.Name = "listBoxSearchResult";
            this.listBoxSearchResult.Size = new System.Drawing.Size(504, 303);
            this.listBoxSearchResult.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Результат:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(143, 85);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(137, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По цене от 250 до 500";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(286, 85);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(141, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "По цене от 500 и выше";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSearchResult);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxManufacturer);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButtonSearchPrice);
            this.Controls.Add(this.radioButtonSearchManufacturer);
            this.Controls.Add(this.radioButtonSearchCategory);
            this.Name = "FormSearch";
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonSearchCategory;
        private System.Windows.Forms.RadioButton radioButtonSearchManufacturer;
        private System.Windows.Forms.RadioButton radioButtonSearchPrice;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxSearchResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}