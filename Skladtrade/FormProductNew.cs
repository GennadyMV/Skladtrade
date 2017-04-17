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
    public partial class FormProductNew : Form
    {
        public FormProductNew()
        {
            InitializeComponent();
        }

        private void buttonCategoryAdd_Click(object sender, EventArgs e)
        {
            FormCategoryNew theCategoryNew = new FormCategoryNew();
            theCategoryNew.ShowDialog();
            LoadCategory();
        }

        private void FormProductNew_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void LoadCategory()
        {
            try
            {
                this.comboBoxCategory.DisplayMember = "Name";
                this.comboBoxCategory.ValueMember = "ID";
                this.comboBoxCategory.DataSource = Category.GetAll();
            }
            catch (Exception ex)
            {
                this.comboBoxCategory.DataSource = null;
                this.comboBoxCategory.Items.Add(ex.Message);
            }
        }
    }
}
