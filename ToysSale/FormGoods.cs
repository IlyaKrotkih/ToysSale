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
    public partial class FormGoods : Form
    {
        private ExistingGoods CurrentExistingGoods;
        private Nomenclature CurrentNomenclature;

        public FormGoods(ExistingGoods existinggoods)
        {
            InitializeComponent();
            try
            {
                this.CurrentExistingGoods = existinggoods;
                if (existinggoods.GoodsNomenclature != null)
                {
                    this.CurrentNomenclature = existinggoods.GoodsNomenclature;
                    btnNomenclature.Text = CurrentNomenclature.ToString();
                }
                numPrice.Value = CurrentExistingGoods.price;
                numCount.Value = CurrentExistingGoods.count;
                if (CurrentExistingGoods.ToString().Trim(new char[] { ' ' }) == "" || CurrentExistingGoods.ToString() == null)
                    this.Text = "Оформление товара";
                else
                    this.Text = CurrentExistingGoods.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка.");
                this.Close();
            }
        }

        private void SetNomenclature(object o)
        {
            try
            {
                this.CurrentNomenclature = o as Nomenclature;
                btnNomenclature.Text = CurrentNomenclature.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка.");
            }
        }

        private void btnNomenclature_Click(object sender, EventArgs e)
        {
            ControlNomenclature control = new ControlNomenclature(ToysSale.dbToySale);
            FormChoice frm = new FormChoice(control.GetList(), SetNomenclature);
            frm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentExistingGoods.GoodsNomenclature = CurrentNomenclature;
                CurrentExistingGoods.price = numPrice.Value;
                CurrentExistingGoods.count = Convert.ToInt32(numCount.Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка.");
                return;
            }
        }
    }
}
