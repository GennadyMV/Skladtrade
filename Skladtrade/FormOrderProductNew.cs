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
    public partial class FormOrderProductNew : Form
    {
        Order theOrder;
        public FormOrderProductNew(Order theOrder)
        {
            InitializeComponent();
            this.theOrder = theOrder;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                OrderProduct theOrderProduct = new OrderProduct();
                theOrderProduct.Order = this.theOrder;
                theOrderProduct.Product = this.comboBoxProducts.SelectedItem as Product;
                theOrderProduct.Count = (int)this.numericUpDown1.Value;
                theOrder.OrderProducts.Add(theOrderProduct);
                theOrderProduct.Save();
                this.Close();
            }
            catch (Exception ex)
            {
                this.comboBoxProducts.Items.Add(ex.Message);
            }
        }

        private void LoadProducts() 
        {
            try
            {
                this.comboBoxProducts.DisplayMember = "Name";
                this.comboBoxProducts.ValueMember = "ID";
                this.comboBoxProducts.DataSource = Product.GetAll();
            }
            catch (Exception ex)
            {
                this.comboBoxProducts.DataSource = null;
                this.comboBoxProducts.Items.Add(ex.Message);
                this.comboBoxProducts.Items.Add(ex.Message);
            }
        }

        private void FormOrderProductNew_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
