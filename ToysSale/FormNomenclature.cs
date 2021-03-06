﻿using System;
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
        private Nomenclature CurrentNomenclature;

        public FormNomenclature(Nomenclature nomenclature)
        {
            InitializeComponent();
            try
            {
                this.CurrentNomenclature = nomenclature;
                if (nomenclature.ToString() != null)this.Text = nomenclature.ToString();
                txtName.Text = CurrentNomenclature.Name;
                txtDefinition.Text = CurrentNomenclature.Definition;
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
                CurrentNomenclature.Name = txtName.Text.ToString();
                CurrentNomenclature.Definition = txtDefinition.Text.ToString();
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
