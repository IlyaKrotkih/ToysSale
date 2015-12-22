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
    public partial class FormReportDelivery : Form
    {
        List<OrderedGoods> List;
        ControlOrderedGoods ControlDB;

        public FormReportDelivery(ControlOrderedGoods control)
        {
            InitializeComponent();
            ControlDB = control;
        }

        private void UpdateDgv()
        {
            dgvGoods.Rows.Clear();
            foreach (OrderedGoods ce in List)
            {

                dgvGoods.Rows.Add(new object[] { ce, ce.Count, ce.RetailPrice, ce.WhosalePrice });
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            List = ControlDB.collection.Find(i1 => i1.DateDeparture>= dtPeriodStart.Value && i1.DateDeparture<=dtPeriodEnd.Value).ToList();
            UpdateDgv();
            decimal AvgRetail = List.Sum(i1 => Convert.ToDecimal(i1.Count) * i1.RetailPrice) / List.Sum(i1 => i1.Count);
            decimal AvgWhosale = List.Sum(i1 => Convert.ToDecimal(i1.Count) * i1.WhosalePrice) / List.Sum(i1 => i1.Count);
            int Count = List.Count;
            decimal Summ = List.Sum(i1 => i1.WhosalePrice * Convert.ToDecimal(i1.Count));

            txtAvgRetailPrice.Text = AvgRetail.ToString("F");
            txtWfosalePrice.Text = AvgWhosale.ToString("F");
            txtSummPrice.Text = Summ.ToString("F");
            txtCount.Text = Count.ToString();
        }
    }
}
