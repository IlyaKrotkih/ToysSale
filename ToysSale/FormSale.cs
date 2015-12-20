using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ToysSale
{
    public partial class FormSale : Form
    {
        Sale CurrentSale;
        Client CurrentClient;
        List<BasketItem> ListSale;
        List<Discount> ListDiscount;


        public FormSale(Sale sale , bool ReadOnly)
        {
            InitializeComponent();
            try
            {
                CurrentSale = sale;
                if (CurrentSale.Basket != null) ListSale = CurrentSale.Basket;
                else ListSale = new List<BasketItem>();
                if (CurrentSale.Discounts != null) ListDiscount = CurrentSale.Discounts;
                else ListDiscount = new List<Discount>();
                CurrentClient = CurrentSale.SaleClient;
                if (CurrentClient != null) txtClient.Text = CurrentClient.ToString();
                txtStaff.Text = CurrentSale.ResponsibleStaff.ToString();
                UpdateLstdiscount();
                txtSumm.Text = CurrentSale.SummGoods.ToString();
                this.btnAddGoods.Enabled = this.btnCreateSale.Enabled = this.btnDeleteGoods.Enabled 
                    = btnAddDiscount.Enabled = btnDeleteDiscount.Enabled = !ReadOnly;
                if (CurrentSale.ToString().Trim(new char[] { ' ' }) == "" || CurrentSale.ToString() == null)
                    this.Text = "Корзина";
                else
                    this.Text = CurrentSale.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка.");
                this.Close();
            }
        }

        private void UpdateSumm()
        {
            CurrentSale.Basket = ListSale;
            CurrentSale.Discounts = ListDiscount;
            CurrentSale.SetPrice();
            txtSumm.Text = CurrentSale.SummGoods.ToString();
        }

        private void UpdateDgv()
        {
            dgvGoods.Rows.Clear();
            foreach (BasketItem ce in ListSale)
            {
                
               dgvGoods.Rows.Add(new object[] { ce, ce.Count, ce.Available, ce.Price });
            }
        }

        private void UpdateLstdiscount()
        {
            lstDiscount.Items.Clear();
            foreach (Discount d in ListDiscount)
            {
                lstDiscount.Items.Add(d);
            }
        }

        private void SetClient(object client)
        {
            this.CurrentClient = client as Client;
        }

        private void AddGoods(object o)
        {
            ExistingGoods eg = (ExistingGoods)o;
            try
            {
                ListSale.Single(i1 => i1.BasketNomenclature.Id == eg.GoodsNomenclature.Id);
            }
            catch
            {
                ListSale.Add(new BasketItem
                {
                    BasketNomenclature = eg.GoodsNomenclature,
                    Price = eg.price,
                    Count = 0,
                    Available = eg.count
                });
            }
        }

        private void btnSelClient_Click(object sender, EventArgs e)
        {
            ControlClient control = new ControlClient(ToysSale.dbToySale);
            FormChoice frm = new FormChoice(control.GetList(),SetClient);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                txtClient.Text = CurrentClient.ToString();
            }
        }

        private void btnCreateSale_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentSale.SaleClient = this.CurrentClient;
                CurrentSale.Basket = this.ListSale;
                CurrentSale.SaleDate = DateTime.Now;
                UpdateSumm();
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка.");
                return;
            }
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            ControlExistingGoods control = new ControlExistingGoods(ToysSale.dbToySale);
            FormChoice frm = new FormChoice(control.GetList(), AddGoods);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                UpdateDgv();
                UpdateSumm();
            }
        }

        private void btnDeleteGoods_Click(object sender, EventArgs e)
        {
            try
            {
                int RowIndex = dgvGoods.CurrentCell.RowIndex;
                BasketItem sel = (BasketItem)dgvGoods.Rows[RowIndex].Cells["clGood"].Value;
                ListSale.Remove(sel);
                UpdateDgv();
                UpdateSumm();
            }
            catch
            {
                MessageBox.Show("Запись не удалена!","Ошибка.");
            }
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormManageSales_Load(object sender, EventArgs e)
        {
            UpdateDgv();
        }

        private void dgvGoods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = dgvGoods.CurrentCell.RowIndex;
            BasketItem sel = (BasketItem)dgvGoods.Rows[RowIndex].Cells["clGood"].Value;
            int count = Convert.ToInt32(dgvGoods.Rows[RowIndex].Cells["clCount"].Value);
            sel.SetCount(count);
            dgvGoods.Rows[RowIndex].Cells["clCount"].Value = sel.Count;
            UpdateSumm();
        }

        private void btnDeleteDiscount_Click(object sender, EventArgs e)
        {
            if (lstDiscount.SelectedItem != null)
            {
                ListDiscount.Remove((Discount)lstDiscount.SelectedItem);
            }
            UpdateSumm();
            UpdateLstdiscount();
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            ControlDiscount control = new ControlDiscount(ToysSale.dbToySale);
            FormChoice frm = new FormChoice(control.GetList(), i1 => { ListDiscount.Add((Discount)i1); });
            frm.ShowDialog();
            UpdateSumm();
            UpdateLstdiscount();
        }
    }
}
