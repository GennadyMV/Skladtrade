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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            this.LoadProduct();
        }

        private void LoadProduct()
        {
            try
            {
                this.listBoxProducts.DisplayMember = "Name";
                this.listBoxProducts.ValueMember = "ID";
                this.listBoxProducts.DataSource = Product.GetAll();
                
            }
            catch(Exception ex)
            {
                this.listBoxProducts.DataSource = null;
                this.listBoxProducts.Items.Add(ex.Message);
            }
        }

        private void buttonProductAdd_Click(object sender, EventArgs e)
        {
            Product theProduct = new Product();
            FormProductNew theProductNew = new FormProductNew(theProduct);
            theProductNew.ShowDialog();
            LoadProduct();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Product theProduct = listBoxProducts.SelectedItem as Product;
            if (theProduct == null)
            {
                return;
            }
            FormProductNew theProductNew = new FormProductNew(theProduct);
            theProductNew.ShowDialog();
            LoadProduct();
        }
    }
}
