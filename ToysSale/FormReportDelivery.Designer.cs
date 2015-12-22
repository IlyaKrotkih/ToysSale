namespace ToysSale
{
    partial class FormReportDelivery
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
            this.lblPeriodStart = new System.Windows.Forms.Label();
            this.dtPeriodStart = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodEnd = new System.Windows.Forms.Label();
            this.dtPeriodEnd = new System.Windows.Forms.DateTimePicker();
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.clGood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWhosalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSumm = new System.Windows.Forms.Label();
            this.lblAvgWhosalePrice = new System.Windows.Forms.Label();
            this.lblRetailPtice = new System.Windows.Forms.Label();
            this.txtSummPrice = new System.Windows.Forms.TextBox();
            this.txtWfosalePrice = new System.Windows.Forms.TextBox();
            this.txtAvgRetailPrice = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPeriodStart
            // 
            this.lblPeriodStart.Location = new System.Drawing.Point(9, 12);
            this.lblPeriodStart.Name = "lblPeriodStart";
            this.lblPeriodStart.Size = new System.Drawing.Size(109, 18);
            this.lblPeriodStart.TabIndex = 0;
            this.lblPeriodStart.Text = "Отчет на период с:  ";
            this.lblPeriodStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtPeriodStart
            // 
            this.dtPeriodStart.Location = new System.Drawing.Point(114, 12);
            this.dtPeriodStart.Name = "dtPeriodStart";
            this.dtPeriodStart.Size = new System.Drawing.Size(138, 20);
            this.dtPeriodStart.TabIndex = 1;
            // 
            // lblPeriodEnd
            // 
            this.lblPeriodEnd.Location = new System.Drawing.Point(259, 13);
            this.lblPeriodEnd.Name = "lblPeriodEnd";
            this.lblPeriodEnd.Size = new System.Drawing.Size(22, 17);
            this.lblPeriodEnd.TabIndex = 2;
            this.lblPeriodEnd.Text = "по:";
            this.lblPeriodEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtPeriodEnd
            // 
            this.dtPeriodEnd.Location = new System.Drawing.Point(287, 13);
            this.dtPeriodEnd.Name = "dtPeriodEnd";
            this.dtPeriodEnd.Size = new System.Drawing.Size(138, 20);
            this.dtPeriodEnd.TabIndex = 1;
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
            this.clRetailPrice,
            this.clWhosalePrice});
            this.dgvGoods.EnableHeadersVisualStyles = false;
            this.dgvGoods.Location = new System.Drawing.Point(12, 39);
            this.dgvGoods.MultiSelect = false;
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.ReadOnly = true;
            this.dgvGoods.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvGoods.RowHeadersWidth = 20;
            this.dgvGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGoods.ShowEditingIcon = false;
            this.dgvGoods.Size = new System.Drawing.Size(519, 177);
            this.dgvGoods.TabIndex = 4;
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
            this.clRetailPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clRetailPrice.FillWeight = 120F;
            this.clRetailPrice.HeaderText = "Розничная цена";
            this.clRetailPrice.Name = "clRetailPrice";
            this.clRetailPrice.ReadOnly = true;
            this.clRetailPrice.Width = 103;
            // 
            // clWhosalePrice
            // 
            this.clWhosalePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clWhosalePrice.FillWeight = 120F;
            this.clWhosalePrice.HeaderText = "Оптовая цена";
            this.clWhosalePrice.Name = "clWhosalePrice";
            this.clWhosalePrice.ReadOnly = true;
            this.clWhosalePrice.Width = 93;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(431, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Показать";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblSumm
            // 
            this.lblSumm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSumm.AutoSize = true;
            this.lblSumm.Location = new System.Drawing.Point(12, 225);
            this.lblSumm.Name = "lblSumm";
            this.lblSumm.Size = new System.Drawing.Size(107, 13);
            this.lblSumm.TabIndex = 6;
            this.lblSumm.Text = "Сумарные затраты:";
            // 
            // lblAvgWhosalePrice
            // 
            this.lblAvgWhosalePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAvgWhosalePrice.AutoSize = true;
            this.lblAvgWhosalePrice.Location = new System.Drawing.Point(12, 245);
            this.lblAvgWhosalePrice.Name = "lblAvgWhosalePrice";
            this.lblAvgWhosalePrice.Size = new System.Drawing.Size(121, 13);
            this.lblAvgWhosalePrice.TabIndex = 7;
            this.lblAvgWhosalePrice.Text = "Средняя оптовая цена";
            // 
            // lblRetailPtice
            // 
            this.lblRetailPtice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRetailPtice.AutoSize = true;
            this.lblRetailPtice.Location = new System.Drawing.Point(12, 265);
            this.lblRetailPtice.Name = "lblRetailPtice";
            this.lblRetailPtice.Size = new System.Drawing.Size(133, 13);
            this.lblRetailPtice.TabIndex = 7;
            this.lblRetailPtice.Text = "Средняя розничная цена";
            // 
            // txtSummPrice
            // 
            this.txtSummPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSummPrice.Location = new System.Drawing.Point(148, 222);
            this.txtSummPrice.Name = "txtSummPrice";
            this.txtSummPrice.ReadOnly = true;
            this.txtSummPrice.Size = new System.Drawing.Size(143, 20);
            this.txtSummPrice.TabIndex = 8;
            // 
            // txtWfosalePrice
            // 
            this.txtWfosalePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtWfosalePrice.Location = new System.Drawing.Point(148, 242);
            this.txtWfosalePrice.Name = "txtWfosalePrice";
            this.txtWfosalePrice.ReadOnly = true;
            this.txtWfosalePrice.Size = new System.Drawing.Size(143, 20);
            this.txtWfosalePrice.TabIndex = 8;
            // 
            // txtAvgRetailPrice
            // 
            this.txtAvgRetailPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAvgRetailPrice.Location = new System.Drawing.Point(148, 262);
            this.txtAvgRetailPrice.Name = "txtAvgRetailPrice";
            this.txtAvgRetailPrice.ReadOnly = true;
            this.txtAvgRetailPrice.Size = new System.Drawing.Size(143, 20);
            this.txtAvgRetailPrice.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(431, 259);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(297, 225);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(69, 13);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "Количество:";
            // 
            // txtCount
            // 
            this.txtCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCount.Location = new System.Drawing.Point(388, 222);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(143, 20);
            this.txtCount.TabIndex = 8;
            // 
            // FormReportDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 292);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtAvgRetailPrice);
            this.Controls.Add(this.txtWfosalePrice);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtSummPrice);
            this.Controls.Add(this.lblRetailPtice);
            this.Controls.Add(this.lblAvgWhosalePrice);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblSumm);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dgvGoods);
            this.Controls.Add(this.lblPeriodEnd);
            this.Controls.Add(this.dtPeriodEnd);
            this.Controls.Add(this.dtPeriodStart);
            this.Controls.Add(this.lblPeriodStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormReportDelivery";
            this.Text = "FormReportDelivery";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeriodStart;
        private System.Windows.Forms.DateTimePicker dtPeriodStart;
        private System.Windows.Forms.Label lblPeriodEnd;
        private System.Windows.Forms.DateTimePicker dtPeriodEnd;
        private System.Windows.Forms.DataGridView dgvGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGood;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRetailPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWhosalePrice;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSumm;
        private System.Windows.Forms.Label lblAvgWhosalePrice;
        private System.Windows.Forms.Label lblRetailPtice;
        private System.Windows.Forms.TextBox txtSummPrice;
        private System.Windows.Forms.TextBox txtWfosalePrice;
        private System.Windows.Forms.TextBox txtAvgRetailPrice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtCount;
    }
}