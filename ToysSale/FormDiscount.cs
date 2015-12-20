using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToysSale
{
    public partial class FormDiscount : Form
    {
        Discount CurrentDiscount;

        public FormDiscount(Discount discount)
        {
            InitializeComponent();
            try
            {
                CurrentDiscount = discount;
                txtName.Text = CurrentDiscount.Name;
                numDiscount.Value = CurrentDiscount.DiscountValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка.");
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentDiscount.DiscountValue = numDiscount.Value;
                CurrentDiscount.Name = txtName.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка.");
                return;
            }
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
