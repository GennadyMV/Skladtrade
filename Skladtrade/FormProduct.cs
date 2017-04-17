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
                foreach(var product in Product.GetAll()) 
                {
                    this.listViewProduct.Items.Add(product.Name);
                }
                
            }
            catch
            {

            }
        }

        private void buttonProductAdd_Click(object sender, EventArgs e)
        {
            FormProductNew theProductNew = new FormProductNew();
            theProductNew.ShowDialog();
            LoadProduct();
        }
    }
}
