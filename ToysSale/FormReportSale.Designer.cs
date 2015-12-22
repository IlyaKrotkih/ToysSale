namespace ToysSale
{
    partial class FormReportSale
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
            this.btnClose = new System.Windows.Forms.Button();
            this.txtRetailPrice = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtSummPrice = new System.Windows.Forms.TextBox();
            this.lblAvgRetailPrice = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblSumm = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.lblPeriodEnd = new System.Windows.Forms.Label();
            this.dtPeriodEnd = new System.Windows.Forms.DateTimePicker();
            this.dtPeriodStart = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodStart = new System.Windows.Forms.Label();
            this.clGood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(432, 257);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRetailPrice.Location = new System.Drawing.Point(149, 259);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.ReadOnly = true;
            this.txtRetailPrice.Size = new System.Drawing.Size(143, 20);
            this.txtRetailPrice.TabIndex = 21;
            // 
            // txtCount
            // 
            this.txtCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCount.Location = new System.Drawing.Point(389, 234);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(143, 20);
            this.txtCount.TabIndex = 22;
            // 
            // txtSummPrice
            // 
            this.txtSummPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSummPrice.Location = new System.Drawing.Point(149, 234);
            this.txtSummPrice.Name = "txtSummPrice";
            this.txtSummPrice.ReadOnly = true;
            this.txtSummPrice.Size = new System.Drawing.Size(143, 20);
            this.txtSummPrice.TabIndex = 23;
            // 
            // lblAvgRetailPrice
            // 
            this.lblAvgRetailPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAvgRetailPrice.AutoSize = true;
            this.lblAvgRetailPrice.Location = new System.Drawing.Point(13, 262);
            this.lblAvgRetailPrice.Name = "lblAvgRetailPrice";
            this.lblAvgRetailPrice.Size = new System.Drawing.Size(133, 13);
            this.lblAvgRetailPrice.TabIndex = 19;
            this.lblAvgRetailPrice.Text = "Средняя розничная цена";
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(298, 237);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(69, 13);
            this.lblCount.TabIndex = 16;
            this.lblCount.Text = "Количество:";
            // 
            // lblSumm
            // 
            this.lblSumm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSumm.AutoSize = true;
            this.lblSumm.Location = new System.Drawing.Point(13, 237);
            this.lblSumm.Name = "lblSumm";
            this.lblSumm.Size = new System.Drawing.Size(107, 13);
            this.lblSumm.TabIndex = 17;
            this.lblSumm.Text = "Сумарные затраты:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(432, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 23);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Показать";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dgvGoods
            // 
            this.dgvGoods.AllowUserToAddRows = false;
            this.dgvGoods.AllowUserToDeleteRows = false;
            this.dgvGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvGoods.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGoods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clGood,
            this.clCount,
            this.clRetailPrice});
            this.dgvGoods.EnableHeadersVisualStyles = false;
            this.dgvGoods.Location = new System.Drawing.Point(13, 39);
            this.dgvGoods.MultiSelect = false;
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.ReadOnly = true;
            this.dgvGoods.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvGoods.RowHeadersWidth = 20;
            this.dgvGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGoods.ShowEditingIcon = false;
            this.dgvGoods.Size = new System.Drawing.Size(519, 189);
            this.dgvGoods.TabIndex = 14;
            // 
            // lblPeriodEnd
            // 
            this.lblPeriodEnd.Location = new System.Drawing.Point(260, 13);
            this.lblPeriodEnd.Name = "lblPeriodEnd";
            this.lblPeriodEnd.Size = new System.Drawing.Size(22, 17);
            this.lblPeriodEnd.TabIndex = 13;
            this.lblPeriodEnd.Text = "по:";
            this.lblPeriodEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtPeriodEnd
            // 
            this.dtPeriodEnd.Location = new System.Drawing.Point(288, 13);
            this.dtPeriodEnd.Name = "dtPeriodEnd";
            this.dtPeriodEnd.Size = new System.Drawing.Size(138, 20);
            this.dtPeriodEnd.TabIndex = 11;
            // 
            // dtPeriodStart
            // 
            this.dtPeriodStart.Location = new System.Drawing.Point(115, 12);
            this.dtPeriodStart.Name = "dtPeriodStart";
            this.dtPeriodStart.Size = new System.Drawing.Size(138, 20);
            this.dtPeriodStart.TabIndex = 12;
            // 
            // lblPeriodStart
            // 
            this.lblPeriodStart.Location = new System.Drawing.Point(10, 12);
            this.lblPeriodStart.Name = "lblPeriodStart";
            this.lblPeriodStart.Size = new System.Drawing.Size(109, 18);
            this.lblPeriodStart.TabIndex = 10;
            this.lblPeriodStart.Text = "Отчет на период с:  ";
            this.lblPeriodStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clGood
            // 
            this.clGood.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clGood.FillWeight = 250F;
            this.clGood.HeaderText = "Товар";
            this.clGood.Name = "clGood";
            this.clGood.ReadOnly = true;
            // 
            // clCount
            // 
            this.clCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clCount.FillWeight = 70F;
            this.clCount.HeaderText = "Количество";
            this.clCount.Name = "clCount";
            this.clCount.ReadOnly = true;
            this.clCount.Width = 90;
            // 
            // clRetailPrice
            // 
            this.clRetailPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clRetailPrice.FillWeight = 120F;
            this.clRetailPrice.HeaderText = "Розничная цена";
            this.clRetailPrice.Name = "clRetailPrice";
            this.clRetailPrice.ReadOnly = true;
            this.clRetailPrice.Width = 103;
            // 
            // FormReportSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 292);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtRetailPrice);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtSummPrice);
            this.Controls.Add(this.lblAvgRetailPrice);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblSumm);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dgvGoods);
            this.Controls.Add(this.lblPeriodEnd);
            this.Controls.Add(this.dtPeriodEnd);
            this.Controls.Add(this.dtPeriodStart);
            this.Controls.Add(this.lblPeriodStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormReportSale";
            this.Text = "FormReportSale";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtRetailPrice;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtSummPrice;
        private System.Windows.Forms.Label lblAvgRetailPrice;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblSumm;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dgvGoods;
        private System.Windows.Forms.Label lblPeriodEnd;
        private System.Windows.Forms.DateTimePicker dtPeriodEnd;
        private System.Windows.Forms.DateTimePicker dtPeriodStart;
        private System.Windows.Forms.Label lblPeriodStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGood;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRetailPrice;
    }
}