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
    public partial class FormStaff : Form
    {
        private Staff CurrentStaff;
        private Department CurrentStaffDepartment;
        public FormStaff(Staff staff)
        {
            InitializeComponent();
            try
            {
                this.CurrentStaff   = staff;
                txtFirstName.Text   = CurrentStaff.FirstName;
                txtLastName.Text    = CurrentStaff.LastName;
                txtPatronunic.Text  = CurrentStaff.Patronumic;
                if (CurrentStaff.StaffDepartment != null)
                    btnDepartment.Text  = CurrentStaff.StaffDepartment.ToString();
                txtPosition.Text    = CurrentStaff.Position;
                numSalary.Value     = CurrentStaff.salary;
                dtAppyToWork.Value  = CurrentStaff.DateApplyToWork;
                if (CurrentStaff.ToString() != null) this.Text = CurrentStaff.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка.");
                this.Close();
            }
        }

        private void SetDepartment(object o)
        {
            try
            {
                this.CurrentStaffDepartment = o as Department;
                btnDepartment.Text = CurrentStaffDepartment.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка.");
            }
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentStaff.FirstName = txtFirstName.Text;
                CurrentStaff.LastName = txtLastName.Text;
                CurrentStaff.Patronumic = txtPatronunic.Text;
                CurrentStaff.StaffDepartment = CurrentStaffDepartment;
                CurrentStaff.Position = txtPosition.Text;
                CurrentStaff.salary = numSalary.Value;
                CurrentStaff.DateApplyToWork = dtAppyToWork.Value;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка.");
                return;
            }
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            ControlDepartment control = new ControlDepartment(ToysSale.dbToySale);
            FormChoice frm = new FormChoice(control.GetList(), SetDepartment);
            frm.ShowDialog();
        }
    }
}
