using SkladtradeEntity.Models;
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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadManufacturer();
            Helper.Load.LoadCharacteristic(this.comboBoxCategory, this.checkedListBoxCharacteristic, null);
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
                this.comboBoxManufacturer.DataSource = null;
                this.comboBoxManufacturer.Items.Add(ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<Product> theProductAll = new List<Product>();
            foreach (var order in Order.GetAll().Where(x => x.OrderStatus.ID == 5 || x.OrderStatus.ID == 8))
            {
                foreach (var item in order.OrderProducts)
                {
                    for (int i = 0; i < item.Count; i++)
                    {
                        theProductAll.Add(item.Product);
                    }

                }
            }

            var result = theProductAll.Where(x => x.ID > 0);

            

            List<Product> theProductResult = new List<Product>();


            if (this.checkBoxCategory.Checked)
            {
                Category theCategory = this.comboBoxCategory.SelectedItem as Category;

                result = result.Where(x => x.Category.ID == theCategory.ID);

                foreach (var item in theProductAll.Where(x => x.Category.ID == theCategory.ID))
                {
                    theProductResult.Add(item);
                }

            }

            if (this.checkBoxManufacturer.Checked)
            {
                Manufacturer theManufacturer = this.comboBoxManufacturer.SelectedItem as Manufacturer;

                result = result.Where(x => x.Manufacturer.ID == theManufacturer.ID);

                foreach (var item in theProductAll.Where(x => x.Manufacturer.ID == theManufacturer.ID))
                {
                    theProductResult.Add(item);
                }

            }

            if (this.checkBoxCharacteristic.Checked)
            {
                foreach (var item in this.checkedListBoxCharacteristic.CheckedItems)
                {
                    Characteristic theCharacteristic = ((ListViewItem)item).Tag as Characteristic;

                    result = result.Where(x => x.IsExistCharacteristic(theCharacteristic.ID) == true);

                }
            }

            if (this.checkBoxPrice0.Checked)
            {
                result = result.Where(x => x.Price < 250);
                foreach (var item in theProductAll.Where(x => x.Price < 250))
                {
                    theProductResult.Add(item);
                }
            }

            if (this.checkBoxPrice250.Checked)
            {
                result = result.Where(x => x.Price > 250 && x.Price < 500);
                foreach (var item in theProductAll.Where(x => x.Price > 250 && x.Price < 500))
                {
                    theProductResult.Add(item);
                }
            }

            if (this.checkBoxPrice500.Checked)
            {
                result = result.Where(x => x.Price > 500);
                foreach (var item in theProductAll.Where(x => x.Price > 500))
                {
                    theProductResult.Add(item);
                }
            }


            this.listBoxSearchResult.Items.Clear();
            foreach (var item in result.GroupBy(x => x).Select(g => new { Text = g.Key, Count = g.Count() }))
            {
                this.listBoxSearchResult.Items.Add(item.Text.Name + " Остаток на складе: " + item.Count + " шт. Общая стоимость: " + item.Text.Price * item.Count + " руб.");
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Helper.Load.LoadCharacteristic(this.comboBoxCategory, this.checkedListBoxCharacteristic, null);
        }

        private void checkedListBoxCharacteristic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.checkedListBoxCharacteristic.CheckedItems.Count > 0)
            {
                this.checkBoxCharacteristic.Checked = true;
            }
            else
            {
                this.checkBoxCharacteristic.Checked = false;
            }
        }
    }
}
