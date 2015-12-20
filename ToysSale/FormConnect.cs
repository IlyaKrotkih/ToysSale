using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace ToysSale
{
    public partial class FormConnect : Form
    {
        private IMongoDatabase DB;
        private MongoClient client;
        private string ConnString;
        private SelectionMade SetDB;

        public FormConnect(SelectionMade setDB)
        {
            InitializeComponent();
            ConnString = "mongodb://" + txtAddres.Text;
            client = new MongoClient(ConnString);
            SetDB = setDB;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                ConnString = "mongodb://" + txtAddres.Text;
                client = new MongoClient(ConnString);
                if (chkNewCollection.Checked == true)
                    DB = client.GetDatabase(txtNewCollection.Text);
                else
                    DB = client.GetDatabase(lstBD.SelectedItem.ToString());
                SetDB(DB);
            }
            catch
            {
                MessageBox.Show("Соединение не установлено.", "Ошибка");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DB = null;
            SetDB(DB);
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            try
            {
                ConnString = "mongodb://" + txtAddres.Text;
                client = new MongoClient(ConnString);
                if (lstBD.Enabled != false)
                    GetDBNames(client);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно получить список."+ "\n"+ex.ToString(),"Ошибка");
            }
        }

        private void chkNewCollection_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNewCollection.Checked == true)
            {
                lstBD.Enabled = false;
                txtNewCollection.Enabled = true;
            }
            else
            {
                lstBD.Enabled = true;
                txtNewCollection.Enabled = false;
            }
        }

        private async void GetDBNames(MongoClient client)
        {
            try
            {
                lstBD.Items.Clear();
                var cursor = await client.ListDatabasesAsync();
                var databasedocuments = await cursor.ToListAsync();
                foreach (var collection in databasedocuments)
                {
                    lstBD.Items.Add(collection["name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }

        private void lstBD_DoubleClick(object sender, EventArgs e)
        {
            if (lstBD.Items.Count == 0)
                return;
            btnConnect_Click(this, null);
        }
    }
}