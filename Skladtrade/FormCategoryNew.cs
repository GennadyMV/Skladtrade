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
    public partial class FormCategoryNew : Form
    {
        public FormCategoryNew()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Category theCategory = new Category();
                theCategory.Name = this.textBoxName.Text;
                theCategory.Save();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
