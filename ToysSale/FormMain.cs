using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver;

namespace ToysSale
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
            this.tsmMagasineManage.Enabled =
                tsmSaleManage.Enabled = false;
            tsmSetUpConnection_Click(this, null);
            this.Text = "Магазин игрушек (отключено)";
        }

        private void SetUpDatabase(object o)
        {
            try
            {
                ToysSale.dbToySale = o as IMongoDatabase;
                ToysSale.ConnState = true;
                this.tsmMagasineManage.Enabled =
                tsmSaleManage.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка.");
                ToysSale.dbToySale = null;
                ToysSale.ConnState = this.tsmMagasineManage.Enabled =
                tsmSaleManage.Enabled = false;
                this.Text = "Магазин игрушек (отключено)";
            }
            finally
            {
                if (ToysSale.dbToySale == null)
                {
                    this.Text = "Магазин игрушек (отключено)";
                    ToysSale.ConnState = this.tsmMagasineManage.Enabled =
                    tsmSaleManage.Enabled = false;
                }
                else
                    this.Text = "Подключен к " + ToysSale.dbToySale.DatabaseNamespace.ToString();
            }
        }

        private void tsmSetUpConnection_Click(object sender, EventArgs e)
        {
            FormConnect frm = new FormConnect(SetUpDatabase);
            frm.MdiParent = this;
            frm.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void tsmManageNomenclature_Click(object sender, EventArgs e)
        {
            ControlNomenclature control = new ControlNomenclature(ToysSale.dbToySale);
            FormListItems form = new FormListItems(control);
            form.MdiParent = this;
            form.Show();
        }
    }
}
