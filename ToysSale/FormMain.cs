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
        }

        private void SetUpDatabase(object o)
        {
            ToysSale.dbToySale = o as IMongoDatabase;
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
    }
}
