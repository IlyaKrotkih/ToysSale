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
    public partial class FormNomenclature : Form
    {
        private Nomenclature nomenclature;

        public FormNomenclature()
        {
            InitializeComponent();
        }
        public FormNomenclature(Nomenclature nomenclature)
        {
            InitializeComponent();
            try
            {
                this.nomenclature = nomenclature;
                txtName.Text = nomenclature.Name;
                txtDefinition.Text = nomenclature.Definition;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                nomenclature.Name = txtName.Text.ToString();
                nomenclature.Definition = txtDefinition.Text.ToString();
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
