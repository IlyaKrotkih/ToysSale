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


        public FormSale(Sale sale , bool ReadOnly)
        {
            InitializeComponent();
            try
            {
                CurrentSale = sale;
                if (CurrentSale.Basket != null) ListSale = CurrentSale.Basket;
                else ListSale = new List<BasketItem>();
                CurrentClient = CurrentSale.SaleClient;
                txtStaff.Text = CurrentSale.ResponsibleStaff.ToString();
                if (CurrentClient != null) txtClient.Text = CurrentClient.ToString();
                this.btnAddGoods.Enabled = this.btnCreateSale.Enabled = this.btnDeleteGoods.Enabled = !ReadOnly;
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

        private void UpdateDgv()
        {
            dgvGoods.Rows.Clear();
            foreach (BasketItem ce in ListSale)
            {
                
               dgvGoods.Rows.Add(new object[] { ce, ce.Count, ce.Available, ce.Price });
               txtSumm.Text = ListSale.Sum<BasketItem>(i1 => i1.Price*i1.Count).ToString();
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
            CurrentSale.SaleClient = this.CurrentClient;
            CurrentSale.Basket = this.ListSale;
            CurrentSale.SaleDate = DateTime.Now;
            CurrentSale.SummGoods = ListSale.Sum<BasketItem>(i1 => i1.Price*i1.Count);
            this.DialogResult = DialogResult.OK;
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            ControlExistingGoods control = new ControlExistingGoods(ToysSale.dbToySale);
            FormChoice frm = new FormChoice(control.GetList(), AddGoods);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                UpdateDgv();
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
            sel.Count = count;
            dgvGoods.Rows[RowIndex].Cells["clCount"].Value = sel.Count;
            CurrentSale.SummGoods = ListSale.Sum<BasketItem>(i1 => i1.Price * i1.Count);
            txtSumm.Text = CurrentSale.SummGoods.ToString();
        }
    }
}
