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
    public partial class FormDebetGoods : Form
    {
        List<OrderedGoods> ListOrderedGoods, ListDebetGoods;


        public FormDebetGoods(IEnumerable<OrderedGoods> listOrdGoods, List<OrderedGoods> DebetGoods )
        {
            InitializeComponent();
            try
            {
                ListOrderedGoods = listOrdGoods.Select(i1 => (OrderedGoods)i1).ToList();
                foreach (OrderedGoods og in ListOrderedGoods)
                {
                    LstOrderedGoods.Items.Add(og);
                }
                ListDebetGoods = DebetGoods;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка.");
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (object og in lstDebidOrderedGoods.Items)
                {
                    ListDebetGoods.Add(og as OrderedGoods);
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Ошибка.");
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lstDebidOrderedGoods.SelectedItem != null)
            {
                LstOrderedGoods.Items.Add(lstDebidOrderedGoods.SelectedItem);
                lstDebidOrderedGoods.Items.Remove(lstDebidOrderedGoods.SelectedItem);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (LstOrderedGoods.SelectedItem != null)
            {
                lstDebidOrderedGoods.Items.Add(LstOrderedGoods.SelectedItem);
                LstOrderedGoods.Items.Remove(LstOrderedGoods.SelectedItem);
            }
        }
    }
}
