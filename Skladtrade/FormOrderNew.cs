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
    public partial class FormOrderNew : Form
    {
        Order theOrder;
        public FormOrderNew(Order theOrder)
        {
            InitializeComponent();
            this.theOrder = theOrder;
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.theOrder.Number = this.textBoxNumber.Text;
            this.theOrder.Manufacturer = this.comboBoxManufacturer.SelectedItem as Manufacturer;
            this.theOrder.OrderStatus = this.comboBoxStatus.SelectedItem as OrderStatus;

            if (this.theOrder.ID > 0)
            {
                this.theOrder.Update();
            }
            else
            {
                this.theOrder.Save();
            }
            this.Close();
        }

        private void buttonOrderProductAdd_Click(object sender, EventArgs e)
        {
            FormOrderProductNew theFormOrderProductNew = new FormOrderProductNew(this.theOrder);
            theFormOrderProductNew.ShowDialog();
            LoadOrderProducts();
        }

        private void FormOrderNew_Load(object sender, EventArgs e)
        {
            if (this.theOrder.ID > 0)
            {
                this.textBoxNumber.Text = theOrder.Number;
            }
            LoadOrderProducts();
            LoadManufacturer();
            LoadStatus();
        }

        private void LoadOrderProducts()
        {
            try
            {
                this.listBoxOrderProducts.Items.Clear();
                foreach (var item in this.theOrder.OrderProducts)
                {
                    this.listBoxOrderProducts.Items.Add(item.Product.Name + ": " + item.Count + " шт.");
                }
            }
            catch (Exception ex)
            {
                this.listBoxOrderProducts.Items.Add(ex.Message);
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

        private void LoadStatus()
        {
            try
            {
                this.comboBoxStatus.DisplayMember = "Name";
                this.comboBoxStatus.ValueMember = "ID";
                this.comboBoxStatus.DataSource = OrderStatus.GetAll();
            }
            catch (Exception ex)
            {
                this.comboBoxStatus.DataSource = null;
                this.comboBoxStatus.Items.Add(ex.Message);
            }
        }
        private void listBoxOrderProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
