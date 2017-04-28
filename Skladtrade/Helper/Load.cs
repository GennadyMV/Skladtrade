using SkladtradeEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladtrade.Helper
{
    static public class Load
    {
        static public void LoadCharacteristic(ComboBox theComboBox, CheckedListBox theCheckedListBox, Product theProduct)
        {
            theCheckedListBox.Items.Clear();
            try
            {
                Category theCategory = theComboBox.SelectedItem as Category;

                foreach (var characteristic in Characteristic.GetAllByCategory(theCategory))
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = characteristic.Name;
                    item.Tag = characteristic;

                    if (theProduct != null && theProduct.IsExistCharacteristic(characteristic.ID))
                    {
                        theCheckedListBox.SetItemChecked(theCheckedListBox.Items.Add(item), true);
                    }
                    else
                    {

                        theCheckedListBox.Items.Add(item);
                    }
                }

            }
            catch (Exception ex)
            {
                theCheckedListBox.Items.Add(ex.Message);
            }
        }
    }
}
