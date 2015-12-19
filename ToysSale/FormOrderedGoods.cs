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
    public partial class FormOrderedGoods : Form
    {
        OrderedGoods CurrentOrderedGoods;
        Nomenclature  CurrentNomenclature;

        public FormOrderedGoods(OrderedGoods orderedgoods)
        {
            InitializeComponent();
            try
            {
                this.CurrentOrderedGoods = orderedgoods;
                if (orderedgoods.GoodsNomenclature != null)
                {
                    this.CurrentNomenclature = orderedgoods.GoodsNomenclature;
                    btnNomenclature.Text = CurrentNomenclature.ToString();
                }
                numRetailPrice.Value = CurrentOrderedGoods.RetailPrice;
                numWhosalePrice.Value = CurrentOrderedGoods.WhosalePrice;
                numCount.Value = CurrentOrderedGoods.Count;
                dtDateDeparture.Value = CurrentOrderedGoods.DateDeparture;
                dtDateRecive.Value = CurrentOrderedGoods.DateRecive;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка.");
                return;
            }
            if (CurrentOrderedGoods.ToString().Trim(new char[] { ' ' }) == "" || CurrentOrderedGoods.ToString() == null)
                this.Text = "Оформление поставки";
            else
                this.Text = CurrentOrderedGoods.ToString();
        }

        private void SetNomenclature(object o)
        {
            try {
                this.CurrentNomenclature = o as Nomenclature;
                btnNomenclature.Text = CurrentNomenclature.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(dtDateRecive.Value < dtDateDeparture.Value)
                {
                    MessageBox.Show("Дата отправки не может быть меньше даты приема товара!", "Ошибка.");
                    return;
                }
                CurrentOrderedGoods.GoodsNomenclature = CurrentNomenclature;
                CurrentOrderedGoods.RetailPrice = numRetailPrice.Value;
                CurrentOrderedGoods.WhosalePrice = numWhosalePrice.Value;
                CurrentOrderedGoods.Count = Convert.ToInt32(numCount.Value);
                CurrentOrderedGoods.DateDeparture = dtDateDeparture.Value;
                CurrentOrderedGoods.DateRecive = dtDateRecive.Value;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка.");
                return;
            }
        }

        private void btnNomenclature_Click(object sender, EventArgs e)
        {
            ControlNomenclature control = new ControlNomenclature(ToysSale.dbToySale);
            FormChoice frm = new FormChoice(control.GetList(), SetNomenclature);
            frm.ShowDialog();
        }
    }
}
