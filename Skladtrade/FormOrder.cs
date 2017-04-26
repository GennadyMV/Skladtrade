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
                this.listBoxOrders.DisplayMember = "Name";
                this.listBoxOrders.ValueMember = "ID";
                this.listBoxOrders.DataSource = Order.GetAll();
            }
            catch (Exception ex)
            {
                this.listBoxOrders.DataSource = null;
                this.listBoxOrders.Items.Add(ex.Message);
            }

        }

        private void ChangeOrderStatus(int Status) 
        {
            try
            {
                Order theOrder = this.listBoxOrders.SelectedItem as Order;
                if (theOrder == null)
                {
                    return;
                }
                theOrder.OrderStatus = OrderStatus.GetByID(Status);
                theOrder.Update();
                LoadOrders();
            }
            catch (Exception ex)
            {
                this.listBoxOrders.DataSource = null;
                this.listBoxOrders.Items.Add(ex.Message);
            }

        }
        private void buttonOrderDelivery_Click(object sender, EventArgs e)
        {
            ChangeOrderStatus(5);
        }

        private void buttonOrderClose_Click(object sender, EventArgs e)
        {
            ChangeOrderStatus(8);
        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            FormStore theStore = new FormStore();
            theStore.ShowDialog();
        }
    }
}
