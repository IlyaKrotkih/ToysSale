namespace ToysSale
{
    partial class FormSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblClient = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.btnSelClient = new System.Windows.Forms.Button();
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.clGood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clExisting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancell = new System.Windows.Forms.Button();
            this.btnAddGoods = new System.Windows.Forms.Button();
            this.btnDeleteGoods = new System.Windows.Forms.Button();
            this.btnCreateSale = new System.Windows.Forms.Button();
            this.lblSumm = new System.Windows.Forms.Label();
            this.txtSumm = new System.Windows.Forms.TextBox();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.grbBasket = new System.Windows.Forms.GroupBox();
            this.grpDiscount = new System.Windows.Forms.GroupBox();
            this.btnDeleteDiscount = new System.Windows.Forms.Button();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.lstDiscount = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            this.grbBasket.SuspendLayout();
            this.grpDiscount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(13, 43);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(49, 13);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Клиент: ";
            // 
            // txtClient
            // 
            this.txtClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClient.Location = new System.Drawing.Point(79, 40);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(308, 20);
            this.txtClient.TabIndex = 1;
            // 
            // btnSelClient
            // 
            this.btnSelClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelClient.Location = new System.Drawing.Point(393, 38);
            this.btnSelClient.Name = "btnSelClient";
            this.btnSelClient.Size = new System.Drawing.Size(86, 23);
            this.btnSelClient.TabIndex = 2;
            this.btnSelClient.Text = "Выбрать";
            this.btnSelClient.UseVisualStyleBackColor = true;
            this.btnSelClient.Click += new System.EventHandler(this.btnSelClient_Click);
            // 
            // dgvGoods
            // 
            this.dgvGoods.AllowUserToAddRows = false;
            this.dgvGoods.AllowUserToDeleteRows = false;
            this.dgvGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGoods.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGoods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clGood,
            this.clCount,
            this.clExisting,
            this.clPrice});
            this.dgvGoods.EnableHeadersVisualStyles = false;
            this.dgvGoods.Location = new System.Drawing.Point(6, 15);
            this.dgvGoods.MultiSelect = false;
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvGoods.RowHeadersWidth = 20;
            this.dgvGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGoods.ShowEditingIcon = false;
            this.dgvGoods.Size = new System.Drawing.Size(456, 118);
            this.dgvGoods.TabIndex = 3;
            this.dgvGoods.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoods_CellEndEdit);
            // 
            // clGood
            // 
            this.clGood.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clGood.FillWeight = 250F;
            this.clGood.HeaderText = "Товар";
            this.clGood.Name = "clGood";
            // 
            // clCount
            // 
            this.clCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clCount.HeaderText = "Количество";
            this.clCount.Name = "clCount";
            this.clCount.Width = 90;
            // 
            // clExisting
            // 
            this.clExisting.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clExisting.HeaderText = "В наличии";
            this.clExisting.Name = "clExisting";
            this.clExisting.Width = 82;
            // 
            // clPrice
            // 
            this.clPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clPrice.HeaderText = "Стоимость";
            this.clPrice.Name = "clPrice";
            this.clPrice.Width = 86;
            // 
            // btnCancell
            // 
            this.btnCancell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancell.Location = new System.Drawing.Point(253, 347);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(107, 23);
            this.btnCancell.TabIndex = 4;
            this.btnCancell.Text = "Отмена";
            this.btnCancell.UseVisualStyleBackColor = true;
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // btnAddGoods
            // 
            this.btnAddGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGoods.Location = new System.Drawing.Point(242, 139);
            this.btnAddGoods.Name = "btnAddGoods";
            this.btnAddGoods.Size = new System.Drawing.Size(107, 23);
            this.btnAddGoods.TabIndex = 4;
            this.btnAddGoods.Text = "Добавить товар";
            this.btnAddGoods.UseVisualStyleBackColor = true;
            this.btnAddGoods.Click += new System.EventHandler(this.btnAddGoods_Click);
            // 
            // btnDeleteGoods
            // 
            this.btnDeleteGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteGoods.Location = new System.Drawing.Point(355, 139);
            this.btnDeleteGoods.Name = "btnDeleteGoods";
            this.btnDeleteGoods.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteGoods.TabIndex = 4;
            this.btnDeleteGoods.Text = "Удалить товар";
            this.btnDeleteGoods.UseVisualStyleBackColor = true;
            this.btnDeleteGoods.Click += new System.EventHandler(this.btnDeleteGoods_Click);
            // 
            // btnCreateSale
            // 
            this.btnCreateSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateSale.Location = new System.Drawing.Point(366, 347);
            this.btnCreateSale.Name = "btnCreateSale";
            this.btnCreateSale.Size = new System.Drawing.Size(107, 23);
            this.btnCreateSale.TabIndex = 4;
            this.btnCreateSale.Text = "Оформить заказ";
            this.btnCreateSale.UseVisualStyleBackColor = true;
            this.btnCreateSale.Click += new System.EventHandler(this.btnCreateSale_Click);
            // 
            // lblSumm
            // 
            this.lblSumm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSumm.AutoSize = true;
            this.lblSumm.Location = new System.Drawing.Point(13, 352);
            this.lblSumm.Name = "lblSumm";
            this.lblSumm.Size = new System.Drawing.Size(41, 13);
            this.lblSumm.TabIndex = 5;
            this.lblSumm.Text = "Сумма";
            // 
            // txtSumm
            // 
            this.txtSumm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSumm.Location = new System.Drawing.Point(60, 349);
            this.txtSumm.Name = "txtSumm";
            this.txtSumm.ReadOnly = true;
            this.txtSumm.Size = new System.Drawing.Size(153, 20);
            this.txtSumm.TabIndex = 6;
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(79, 12);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.ReadOnly = true;
            this.txtStaff.Size = new System.Drawing.Size(400, 20);
            this.txtStaff.TabIndex = 7;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(13, 15);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(60, 13);
            this.lblStaff.TabIndex = 8;
            this.lblStaff.Text = "Сотрудник";
            // 
            // grbBasket
            // 
            this.grbBasket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbBasket.Controls.Add(this.dgvGoods);
            this.grbBasket.Controls.Add(this.btnAddGoods);
            this.grbBasket.Controls.Add(this.btnDeleteGoods);
            this.grbBasket.Location = new System.Drawing.Point(11, 66);
            this.grbBasket.Name = "grbBasket";
            this.grbBasket.Size = new System.Drawing.Size(468, 168);
            this.grbBasket.TabIndex = 9;
            this.grbBasket.TabStop = false;
            this.grbBasket.Text = "Корзина";
            // 
            // grpDiscount
            // 
            this.grpDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDiscount.Controls.Add(this.lstDiscount);
            this.grpDiscount.Controls.Add(this.btnDeleteDiscount);
            this.grpDiscount.Controls.Add(this.btnAddDiscount);
            this.grpDiscount.Location = new System.Drawing.Point(11, 240);
            this.grpDiscount.Name = "grpDiscount";
            this.grpDiscount.Size = new System.Drawing.Size(468, 101);
            this.grpDiscount.TabIndex = 10;
            this.grpDiscount.TabStop = false;
            this.grpDiscount.Text = "Скидки";
            // 
            // btnDeleteDiscount
            // 
            this.btnDeleteDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteDiscount.Location = new System.Drawing.Point(355, 72);
            this.btnDeleteDiscount.Name = "btnDeleteDiscount";
            this.btnDeleteDiscount.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteDiscount.TabIndex = 4;
            this.btnDeleteDiscount.Text = "Удалить скидку";
            this.btnDeleteDiscount.UseVisualStyleBackColor = true;
            this.btnDeleteDiscount.Click += new System.EventHandler(this.btnDeleteDiscount_Click);
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDiscount.Location = new System.Drawing.Point(242, 72);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(107, 23);
            this.btnAddDiscount.TabIndex = 4;
            this.btnAddDiscount.Text = "Добавить скидку";
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // lstDiscount
            // 
            this.lstDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDiscount.Location = new System.Drawing.Point(6, 14);
            this.lstDiscount.Name = "lstDiscount";
            this.lstDiscount.Size = new System.Drawing.Size(456, 56);
            this.lstDiscount.TabIndex = 5;
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 382);
            this.Controls.Add(this.grpDiscount);
            this.Controls.Add(this.grbBasket);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.txtSumm);
            this.Controls.Add(this.lblSumm);
            this.Controls.Add(this.btnCreateSale);
            this.Controls.Add(this.btnCancell);
            this.Controls.Add(this.btnSelClient);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.lblClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormSale";
            this.Text = "Корзина";
            this.Load += new System.EventHandler(this.FormManageSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.grbBasket.ResumeLayout(false);
            this.grpDiscount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Button btnSelClient;
        private System.Windows.Forms.DataGridView dgvGoods;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.Button btnAddGoods;
        private System.Windows.Forms.Button btnDeleteGoods;
        private System.Windows.Forms.Button btnCreateSale;
        private System.Windows.Forms.Label lblSumm;
        private System.Windows.Forms.TextBox txtSumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGood;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clExisting;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.GroupBox grbBasket;
        private System.Windows.Forms.GroupBox grpDiscount;
        private System.Windows.Forms.Button btnDeleteDiscount;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.ListBox lstDiscount;
    }
}