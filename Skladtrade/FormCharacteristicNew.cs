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
    public partial class FormCharacteristicNew : Form
    {
        Category theCategory;
        public FormCharacteristicNew(Category theCategory)
        {
            InitializeComponent();
            this.theCategory = theCategory;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Characteristic theCharacteristic = new Characteristic();
            theCharacteristic.Name = this.textBoxName.Text;
            theCharacteristic.Category = this.theCategory;
            theCharacteristic.Save();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
