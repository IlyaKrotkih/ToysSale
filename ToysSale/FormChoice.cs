using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToysSale
{

    public partial class FormChoice : Form
    {
        private IEnumerable<object> Items;
        private SelectionMade Func;

        public FormChoice(IEnumerable<object> items, SelectionMade func)
        {
            InitializeComponent();
            Items = items;
            Func = func;
        }

        public FormChoice(IEnumerable<object> items, SelectionMade func,string WindowText)
        {
            InitializeComponent();
            Items = items;
            Func = func;
            this.Text = WindowText;
        }

        private void ToList(IEnumerable<object> items)
        {
            lstList.Items.Clear();
            foreach (object o in SortToKey(items))
                lstList.Items.Add(o);
        }

        private void Choice_Click(object sender, EventArgs e)
        {
            if (lstList.SelectedItem == null)
            {
                this.DialogResult = DialogResult.None;
                return;
            }
            this.DialogResult = DialogResult.OK;
            Func(lstList.SelectedItem);
            this.Close();
        }

        private void FormChoice_Shown(object sender, EventArgs e)
        {
            ToList(Items);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ToList(Items);
        }

        private IEnumerable<object> SortToKey(IEnumerable<object> item)
        {
            if (txtFilter.Text == "") return item;
            else return from i in item where i.ToString().IndexOf(txtFilter.Text) > -1 select i;
        }
    }
}
