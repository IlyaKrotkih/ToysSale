using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ToysSale
{
    public partial class FormReportSale : Form
    {
        List<Sale> List;
        ControlSale ControlDB;

        public FormReportSale(ControlSale control)
        {
            InitializeComponent();
            ControlDB = control;
        }

        private void UpdateDgv()
        {
            dgvGoods.Rows.Clear();
            foreach (Sale ce in List)
            {

                dgvGoods.Rows.Add(new object[] { ce, ce.Basket.Sum(i1 => i1.Count), ce.SummGoods });
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            List = ControlDB.collection.Find(i1 => i1.SaleDate >= dtPeriodStart.Value && i1.SaleDate <= dtPeriodEnd.Value).ToList();
            UpdateDgv();
            decimal AvgRetail = List.Average(i1 => i1.SummGoods);
            int Count = List.Count;
            decimal Summ = List.Sum(i1 => i1.SummGoods);

            txtRetailPrice.Text = AvgRetail.ToString("F");
            txtSummPrice.Text = Summ.ToString("F");
            txtCount.Text = Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
