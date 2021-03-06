﻿using SkladtradeEntity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladtrade
{
    public partial class FormProductNew : Form
    {
        Product theProduct;
        public FormProductNew(Product theProduct)
        {
            InitializeComponent();
            this.theProduct = theProduct;
        }

        private void buttonCategoryAdd_Click(object sender, EventArgs e)
        {
            FormCategoryNew theCategoryNew = new FormCategoryNew();
            theCategoryNew.ShowDialog();
            LoadCategory();
        }

        private void FormProductNew_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadManufacturer();

            if (theProduct.ID > 0)
            {
                this.textBoxCode.Text = theProduct.Code;                
                this.textBoxPrice.Text = theProduct.Price.ToString();
                this.textBoxDescription.Text = theProduct.Description;

                foreach (var item in this.comboBoxCategory.Items)
                {
                    if (((Category)item).ID == theProduct.Category.ID)
                    {
                        this.comboBoxCategory.SelectedItem = item;
                    }
                }

                
            }

            LoadCharacteristic();
        }

        private void LoadCategory()
        {
            try
            {
                this.comboBoxCategory.DisplayMember = "Name";
                this.comboBoxCategory.ValueMember = "ID";
                this.comboBoxCategory.DataSource = Category.GetAll();
            }
            catch (Exception ex)
            {
                this.comboBoxCategory.DataSource = null;
                this.comboBoxCategory.Items.Add(ex.Message);
            }
        }

        private void LoadCharacteristic()
        {
            Helper.Load.LoadCharacteristic(this.comboBoxCategory, this.checkedListBoxCharacteristic, this.theProduct);
        }

        private void LoadManufacturer()
        {
            try
            {

                this.comboBoxManufacturer.DisplayMember = "Name";
                this.comboBoxManufacturer.ValueMember = "ID";
                this.comboBoxManufacturer.DataSource = Manufacturer.GetAll();
            }
            catch (Exception ex)
            {
                this.comboBoxManufacturer.DataSource = null;
                this.comboBoxManufacturer.Items.Add(ex.Message);
            }
        }

        private void buttonMonufacturerAdd_Click(object sender, EventArgs e)
        {
            FormManufacturerNew theFormManufacturerNew = new FormManufacturerNew();
            theFormManufacturerNew.ShowDialog();
            LoadManufacturer();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                theProduct.Code = this.textBoxCode.Text;
                theProduct.Category = this.comboBoxCategory.SelectedItem as Category;
                theProduct.Manufacturer = this.comboBoxManufacturer.SelectedItem as Manufacturer;
                theProduct.Price = Convert.ToDecimal(this.textBoxPrice.Text);
                theProduct.Description = this.textBoxDescription.Text;

                theProduct.ClearCharacteristics();

                foreach(var item in this.checkedListBoxCharacteristic.CheckedItems)
                {
                    Characteristic model = ((ListViewItem)item).Tag as Characteristic;
                    this.theProduct.Characteristics.Add(model);
                }

                if (theProduct.ID > 0)
                {
                    theProduct.Update();
                }
                else
                {
                    theProduct.Save();
                }

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCharacteristicAdd_Click(object sender, EventArgs e)
        {
            Category theCategory = this.comboBoxCategory.SelectedItem as Category;
            FormCharacteristicNew theFormCharacteristicNew = new FormCharacteristicNew(theCategory);
            theFormCharacteristicNew.ShowDialog();
            LoadCharacteristic();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCharacteristic();
        }
    }
}
