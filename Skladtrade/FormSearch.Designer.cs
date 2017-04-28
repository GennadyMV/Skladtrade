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
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxSearchResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxCategory = new System.Windows.Forms.CheckBox();
            this.checkBoxManufacturer = new System.Windows.Forms.CheckBox();
            this.checkBoxPrice0 = new System.Windows.Forms.CheckBox();
            this.checkBoxPrice250 = new System.Windows.Forms.CheckBox();
            this.checkBoxPrice500 = new System.Windows.Forms.CheckBox();
            this.checkBoxCharacteristic = new System.Windows.Forms.CheckBox();
            this.checkedListBoxCharacteristic = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(163, 11);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(186, 21);
            this.comboBoxCategory.TabIndex = 1;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(163, 190);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(186, 21);
            this.comboBoxManufacturer.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 276);
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
            this.listBoxSearchResult.Location = new System.Drawing.Point(12, 341);
            this.listBoxSearchResult.Name = "listBoxSearchResult";
            this.listBoxSearchResult.Size = new System.Drawing.Size(641, 303);
            this.listBoxSearchResult.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Результат:";
            // 
            // checkBoxCategory
            // 
            this.checkBoxCategory.AutoSize = true;
            this.checkBoxCategory.Location = new System.Drawing.Point(15, 14);
            this.checkBoxCategory.Name = "checkBoxCategory";
            this.checkBoxCategory.Size = new System.Drawing.Size(95, 17);
            this.checkBoxCategory.TabIndex = 5;
            this.checkBoxCategory.Text = "По категории";
            this.checkBoxCategory.UseVisualStyleBackColor = true;
            // 
            // checkBoxManufacturer
            // 
            this.checkBoxManufacturer.AutoSize = true;
            this.checkBoxManufacturer.Location = new System.Drawing.Point(15, 190);
            this.checkBoxManufacturer.Name = "checkBoxManufacturer";
            this.checkBoxManufacturer.Size = new System.Drawing.Size(122, 17);
            this.checkBoxManufacturer.TabIndex = 6;
            this.checkBoxManufacturer.Text = "По производителю";
            this.checkBoxManufacturer.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrice0
            // 
            this.checkBoxPrice0.AutoSize = true;
            this.checkBoxPrice0.Location = new System.Drawing.Point(15, 235);
            this.checkBoxPrice0.Name = "checkBoxPrice0";
            this.checkBoxPrice0.Size = new System.Drawing.Size(126, 17);
            this.checkBoxPrice0.TabIndex = 7;
            this.checkBoxPrice0.Text = "По цене от 0 до 250";
            this.checkBoxPrice0.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrice250
            // 
            this.checkBoxPrice250.AutoSize = true;
            this.checkBoxPrice250.Location = new System.Drawing.Point(183, 235);
            this.checkBoxPrice250.Name = "checkBoxPrice250";
            this.checkBoxPrice250.Size = new System.Drawing.Size(138, 17);
            this.checkBoxPrice250.TabIndex = 8;
            this.checkBoxPrice250.Text = "По цене от 250 до 500";
            this.checkBoxPrice250.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrice500
            // 
            this.checkBoxPrice500.AutoSize = true;
            this.checkBoxPrice500.Location = new System.Drawing.Point(355, 235);
            this.checkBoxPrice500.Name = "checkBoxPrice500";
            this.checkBoxPrice500.Size = new System.Drawing.Size(142, 17);
            this.checkBoxPrice500.TabIndex = 9;
            this.checkBoxPrice500.Text = "По цене от 500 и выше";
            this.checkBoxPrice500.UseVisualStyleBackColor = true;
            // 
            // checkBoxCharacteristic
            // 
            this.checkBoxCharacteristic.AutoSize = true;
            this.checkBoxCharacteristic.Location = new System.Drawing.Point(15, 53);
            this.checkBoxCharacteristic.Name = "checkBoxCharacteristic";
            this.checkBoxCharacteristic.Size = new System.Drawing.Size(132, 17);
            this.checkBoxCharacteristic.TabIndex = 10;
            this.checkBoxCharacteristic.Text = "По характеристикам";
            this.checkBoxCharacteristic.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCharacteristic
            // 
            this.checkedListBoxCharacteristic.CheckOnClick = true;
            this.checkedListBoxCharacteristic.FormattingEnabled = true;
            this.checkedListBoxCharacteristic.Location = new System.Drawing.Point(163, 38);
            this.checkedListBoxCharacteristic.Name = "checkedListBoxCharacteristic";
            this.checkedListBoxCharacteristic.Size = new System.Drawing.Size(186, 139);
            this.checkedListBoxCharacteristic.TabIndex = 11;
            this.checkedListBoxCharacteristic.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxCharacteristic_SelectedIndexChanged);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 656);
            this.Controls.Add(this.checkedListBoxCharacteristic);
            this.Controls.Add(this.checkBoxCharacteristic);
            this.Controls.Add(this.checkBoxPrice500);
            this.Controls.Add(this.checkBoxPrice250);
            this.Controls.Add(this.checkBoxPrice0);
            this.Controls.Add(this.checkBoxManufacturer);
            this.Controls.Add(this.checkBoxCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSearchResult);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxManufacturer);
            this.Controls.Add(this.comboBoxCategory);
            this.Name = "FormSearch";
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxSearchResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxCategory;
        private System.Windows.Forms.CheckBox checkBoxManufacturer;
        private System.Windows.Forms.CheckBox checkBoxPrice0;
        private System.Windows.Forms.CheckBox checkBoxPrice250;
        private System.Windows.Forms.CheckBox checkBoxPrice500;
        private System.Windows.Forms.CheckBox checkBoxCharacteristic;
        private System.Windows.Forms.CheckedListBox checkedListBoxCharacteristic;
    }
}