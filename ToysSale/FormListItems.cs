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
    public delegate void ManageMethod(object sale);

    public partial class FormListItems : Form
    {
        private ManageMethod Create, Change, Remove;
        IEnumerable<object> List;

        public FormListItems(IEnumerable<object> lst, ManageMethod createMethod,ManageMethod updateMethod,ManageMethod removeMethod)
        {
            InitializeComponent();
            this.Create = createMethod;
            this.Change = updateMethod;
            this.Remove = removeMethod;
            List = lst;
            UpdateList(List);
        }

        private void UpdateList(IEnumerable<Object> lst)
        {
            lstItems.Items.Clear();
            foreach (Object o in lst)
            {
                lstItems.Items.Add(o);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            object s = lstItems.SelectedItem;
            Remove(s);
            UpdateList(List);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            object s = lstItems.SelectedItem;
            Change(s);
            UpdateList(List);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            object s = lstItems.SelectedItem;
            Create(s);
            UpdateList(List);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
