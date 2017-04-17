namespace Skladtrade
{
    partial class FormProductNew
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.numericUpDownBalance = new System.Windows.Forms.NumericUpDown();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonCategoryAdd = new System.Windows.Forms.Button();
            this.buttonMonufacturerAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Штрих код:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категория:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Производитель:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Описание:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Цена:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Баланс:";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(120, 10);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(152, 20);
            this.textBoxCode.TabIndex = 2;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(120, 39);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(152, 21);
            this.comboBoxCategory.TabIndex = 3;
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(120, 71);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(152, 21);
            this.comboBoxManufacturer.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(120, 108);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(152, 20);
            this.textBoxPrice.TabIndex = 2;
            // 
            // numericUpDownBalance
            // 
            this.numericUpDownBalance.Location = new System.Drawing.Point(120, 146);
            this.numericUpDownBalance.Name = "numericUpDownBalance";
            this.numericUpDownBalance.Size = new System.Drawing.Size(152, 20);
            this.numericUpDownBalance.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(120, 176);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(152, 88);
            this.textBoxDescription.TabIndex = 5;
            // 
            // buttonCategoryAdd
            // 
            this.buttonCategoryAdd.Location = new System.Drawing.Point(278, 37);
            this.buttonCategoryAdd.Name = "buttonCategoryAdd";
            this.buttonCategoryAdd.Size = new System.Drawing.Size(25, 23);
            this.buttonCategoryAdd.TabIndex = 6;
            this.buttonCategoryAdd.Text = "+";
            this.buttonCategoryAdd.UseVisualStyleBackColor = true;
            this.buttonCategoryAdd.Click += new System.EventHandler(this.buttonCategoryAdd_Click);
            // 
            // buttonMonufacturerAdd
            // 
            this.buttonMonufacturerAdd.Location = new System.Drawing.Point(278, 69);
            this.buttonMonufacturerAdd.Name = "buttonMonufacturerAdd";
            this.buttonMonufacturerAdd.Size = new System.Drawing.Size(25, 23);
            this.buttonMonufacturerAdd.TabIndex = 6;
            this.buttonMonufacturerAdd.Text = "+";
            this.buttonMonufacturerAdd.UseVisualStyleBackColor = true;
            this.buttonMonufacturerAdd.Click += new System.EventHandler(this.buttonMonufacturerAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(120, 287);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(278, 287);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormProductNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 344);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonMonufacturerAdd);
            this.Controls.Add(this.buttonCategoryAdd);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.numericUpDownBalance);
            this.Controls.Add(this.comboBoxManufacturer);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProductNew";
            this.Text = "Добавить продукцию";
            this.Load += new System.EventHandler(this.FormProductNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownBalance;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonCategoryAdd;
        private System.Windows.Forms.Button buttonMonufacturerAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}