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
    public partial class FormSaleNew : Form
    {
        public FormSaleNew()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Sale theSale = new Sale();
                theSale.Number = this.textBoxNumber.Text;
                theSale.Price = this.numericUpDownPrice.Value;
                theSale.Count = (int) this.numericUpDownCount.Value;
                theSale.Product = this.comboBoxProduct.SelectedItem as Product;
                theSale.Manufacturer = this.comboBoxManufacturer.SelectedItem as Manufacturer;
                theSale.Document = this.textBoxDocument.Text;
                theSale.Save();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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


        private void LoadProduct()
        {
            try
            {
                this.comboBoxProduct.DisplayMember = "Name";
                this.comboBoxProduct.ValueMember = "ID";
                this.comboBoxProduct.DataSource = Product.GetAll();
            }
            catch (Exception ex)
            {
                this.comboBoxProduct.DataSource = null;
                this.comboBoxProduct.Items.Add(ex.Message);
            }
        }

        private void FormSaleNew_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadManufacturer();
            comboBoxProduct_SelectedIndexChanged(null, null);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product theProduct = this.comboBoxProduct.SelectedItem as Product;
            this.numericUpDownPrice.Value = theProduct.Price * this.numericUpDownCount.Value;
        }

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
            Product theProduct = this.comboBoxProduct.SelectedItem as Product;
            this.numericUpDownPrice.Value = theProduct.Price * this.numericUpDownCount.Value;
        }
    }
}
