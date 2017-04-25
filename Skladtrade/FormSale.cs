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
    public partial class FormSale : Form
    {
        public FormSale()
        {
            InitializeComponent();
        }

        private void buttonSaleAdd_Click(object sender, EventArgs e)
        {
            FormSaleNew theFormSaleNew = new FormSaleNew();
            theFormSaleNew.ShowDialog();
            LoadSale();
        }

        private void FormSale_Load(object sender, EventArgs e)
        {
            LoadSale();
        }
        private void LoadSale()
        {
            try
            {
                this.listViewSale.Items.Clear();
                foreach (var order in Sale.GetAll())
                {
                    this.listViewSale.Items.Add("Продажа № " + order.Number + " ");
                }

            }
            catch (Exception ex)
            {
                this.listViewSale.Items.Add(ex.Message);
            }
        }
    }
}
