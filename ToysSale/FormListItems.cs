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

        public FormListItems(IControlBD ControlClass, string WindowText)
        {
            InitializeComponent();
            control = ControlClass;
            List = ControlClass.GetList();
            this.Text = WindowText;
            UpdateList(List);
        }

        private void UpdateList(IEnumerable<Object> lst)
        {
            lstItems.Items.Clear();
            foreach (Object o in lst)
            {
                lstItems.Items.Add(o);
            }
            if (lstItems.Items.Count > 0)
                lstItems.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                object s = lstItems.SelectedItem;
                control.Remove(s);
                UpdateList(control.GetList());
            }
            catch
            {
                MessageBox.Show("Запись не удалена");
                return;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try { 
            object s = lstItems.SelectedItem;
            control.Update(s);
            UpdateList(control.GetList());
            }
            catch
            {
                MessageBox.Show("Запись не изменена");
                return;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                control.Add();
                UpdateList(control.GetList());
            }
            catch
            {
                MessageBox.Show("Запись не создана");
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateList(control.GetList());
        }

        private void lstItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnChange_Click(this, null);
        }
    }
}
