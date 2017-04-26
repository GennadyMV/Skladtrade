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
    public partial class FormStore : Form
    {
        public FormStore()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormStore_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts() 
        {
            try
            {
                foreach (var order in Order.GetAll().Where(x => x.OrderStatus.ID == 5 || x.OrderStatus.ID == 8))
                {
                    foreach (var item in order.OrderProducts)
                    {
                        for (int i = 0; i < item.Count; i++ )
                        {
                            this.listViewProducts.Items.Add(item.Product.Name);
                        }
                            
                    }
                }
            }
            catch (Exception ex)
            {
                this.listViewProducts.Items.Add(ex.Message);
            }
        }
    }
}
