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
    public partial class FormDepartment : Form
    {
        Department CurrentDepartment;

        public FormDepartment(Department department)
        {
            InitializeComponent();
            try
            {
                CurrentDepartment = department;
                if (CurrentDepartment.ToString() != null) this.Text = CurrentDepartment.ToString();
                this.txtName.Text = CurrentDepartment.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка.");
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentDepartment.Name = txtName.Text.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка.");
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
