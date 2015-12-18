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
        private IControlBD control;
        IEnumerable<object> List;

        public FormListItems(IControlBD ControlClass)
        {
            InitializeComponent();
            control = ControlClass;
            List = ControlClass.GetList();
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
            control.Remove(s);
            UpdateList(control.GetList());
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            object s = lstItems.SelectedItem;
            control.Update(s);
            UpdateList(control.GetList());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            object s = lstItems.SelectedItem;
            control.Add();
            UpdateList(control.GetList());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
