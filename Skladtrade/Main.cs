using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladtrade
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            FormProduct theFormProduct = new FormProduct();
            theFormProduct.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!File.Exists("nhlite.db"))
            {
                Entity.Common.NHibernateHelper.UpdateSchema();
            }
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            FormOrder theFormOrder = new FormOrder();
            theFormOrder.ShowDialog();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            FormSale theFormSale = new FormSale();
            theFormSale.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormSearch theSearch = new FormSearch();
            theSearch.ShowDialog();
        }
    }
}
