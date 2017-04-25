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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void buttonOrderNew_Click(object sender, EventArgs e)
        {
            Order theOrder = new Order();
            theOrder.Manufacturer = Manufacturer.GetAll()[0];
            theOrder.OrderStatus = OrderStatus.GetAll()[0];
            theOrder.Save();
            FormOrderNew theFormOrderNew = new FormOrderNew(theOrder);
            theFormOrderNew.ShowDialog();

            LoadOrders();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
        private void LoadOrders()
        {
            try
            {
                this.listBoxOrders.Items.Clear();
                foreach (var order in Order.GetAll())
                {
                    this.listBoxOrders.Items.Add("Заказ № " + order.Number + " ");
                }

            }
            catch (Exception ex)
            {
                this.listBoxOrders.Items.Add(ex.Message);
            }
        }
    }
}
