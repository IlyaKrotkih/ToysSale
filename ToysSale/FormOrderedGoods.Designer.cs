namespace ToysSale
{
    partial class FormOrderedGoods
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNomenclature = new System.Windows.Forms.Label();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.lblWhosalePrice = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.blDataDeparture = new System.Windows.Forms.Label();
            this.lblDateRecive = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNomenclature = new System.Windows.Forms.Button();
            this.numRetailPrice = new System.Windows.Forms.NumericUpDown();
            this.numWhosalePrice = new System.Windows.Forms.NumericUpDown();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.dtDateDeparture = new System.Windows.Forms.DateTimePicker();
            this.dtDateRecive = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRetailPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWhosalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.08451F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.91549F));
            this.tableLayoutPanel1.Controls.Add(this.lblNomenclature, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRetailPrice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblWhosalePrice, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCount, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.blDataDeparture, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDateRecive, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnNomenclature, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numRetailPrice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numWhosalePrice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numCount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtDateDeparture, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtDateRecive, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 179);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNomenclature
            // 
            this.lblNomenclature.AutoSize = true;
            this.lblNomenclature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNomenclature.Location = new System.Drawing.Point(3, 0);
            this.lblNomenclature.Name = "lblNomenclature";
            this.lblNomenclature.Size = new System.Drawing.Size(105, 25);
            this.lblNomenclature.TabIndex = 1;
            this.lblNomenclature.Text = "Номенклатура";
            this.lblNomenclature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.AutoSize = true;
            this.lblRetailPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRetailPrice.Location = new System.Drawing.Point(3, 25);
            this.lblRetailPrice.Name = "lblRetailPrice";
            this.lblRetailPrice.Size = new System.Drawing.Size(105, 25);
            this.lblRetailPrice.TabIndex = 1;
            this.lblRetailPrice.Text = "Розничная цена";
            this.lblRetailPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWhosalePrice
            // 
            this.lblWhosalePrice.AutoSize = true;
            this.lblWhosalePrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWhosalePrice.Location = new System.Drawing.Point(3, 50);
            this.lblWhosalePrice.Name = "lblWhosalePrice";
            this.lblWhosalePrice.Size = new System.Drawing.Size(105, 25);
            this.lblWhosalePrice.TabIndex = 1;
            this.lblWhosalePrice.Text = "Оптовая цена";
            this.lblWhosalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCount.Location = new System.Drawing.Point(3, 75);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(105, 25);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "Количество";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // blDataDeparture
            // 
            this.blDataDeparture.AutoSize = true;
            this.blDataDeparture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blDataDeparture.Location = new System.Drawing.Point(3, 100);
            this.blDataDeparture.Name = "blDataDeparture";
            this.blDataDeparture.Size = new System.Drawing.Size(105, 25);
            this.blDataDeparture.TabIndex = 1;
            this.blDataDeparture.Text = "Дата оформления";
            this.blDataDeparture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateRecive
            // 
            this.lblDateRecive.AutoSize = true;
            this.lblDateRecive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateRecive.Location = new System.Drawing.Point(3, 125);
            this.lblDateRecive.Name = "lblDateRecive";
            this.lblDateRecive.Size = new System.Drawing.Size(105, 25);
            this.lblDateRecive.TabIndex = 1;
            this.lblDateRecive.Text = "Дата получения";
            this.lblDateRecive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(3, 153);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(114, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNomenclature
            // 
            this.btnNomenclature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNomenclature.Location = new System.Drawing.Point(114, 3);
            this.btnNomenclature.Name = "btnNomenclature";
            this.btnNomenclature.Size = new System.Drawing.Size(167, 19);
            this.btnNomenclature.TabIndex = 2;
            this.btnNomenclature.Text = "Выбрать";
            this.btnNomenclature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNomenclature.UseVisualStyleBackColor = true;
            this.btnNomenclature.Click += new System.EventHandler(this.btnNomenclature_Click);
            // 
            // numRetailPrice
            // 
            this.numRetailPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numRetailPrice.DecimalPlaces = 2;
            this.numRetailPrice.Location = new System.Drawing.Point(114, 28);
            this.numRetailPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRetailPrice.Name = "numRetailPrice";
            this.numRetailPrice.Size = new System.Drawing.Size(167, 20);
            this.numRetailPrice.TabIndex = 3;
            // 
            // numWhosalePrice
            // 
            this.numWhosalePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numWhosalePrice.DecimalPlaces = 2;
            this.numWhosalePrice.Location = new System.Drawing.Point(114, 53);
            this.numWhosalePrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numWhosalePrice.Name = "numWhosalePrice";
            this.numWhosalePrice.Size = new System.Drawing.Size(167, 20);
            this.numWhosalePrice.TabIndex = 3;
            // 
            // numCount
            // 
            this.numCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numCount.Location = new System.Drawing.Point(114, 78);
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(167, 20);
            this.numCount.TabIndex = 3;
            // 
            // dtDateDeparture
            // 
            this.dtDateDeparture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDateDeparture.Location = new System.Drawing.Point(114, 103);
            this.dtDateDeparture.Name = "dtDateDeparture";
            this.dtDateDeparture.Size = new System.Drawing.Size(167, 20);
            this.dtDateDeparture.TabIndex = 4;
            // 
            // dtDateRecive
            // 
            this.dtDateRecive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDateRecive.Location = new System.Drawing.Point(114, 128);
            this.dtDateRecive.Name = "dtDateRecive";
            this.dtDateRecive.Size = new System.Drawing.Size(167, 20);
            this.dtDateRecive.TabIndex = 4;
            // 
            // FormOrderedGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 179);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(300, 218);
            this.Name = "FormOrderedGoods";
            this.Text = "FormOrderedGoods";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRetailPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWhosalePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNomenclature;
        private System.Windows.Forms.Label lblRetailPrice;
        private System.Windows.Forms.Label lblWhosalePrice;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label blDataDeparture;
        private System.Windows.Forms.Label lblDateRecive;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNomenclature;
        private System.Windows.Forms.NumericUpDown numRetailPrice;
        private System.Windows.Forms.NumericUpDown numWhosalePrice;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.DateTimePicker dtDateDeparture;
        private System.Windows.Forms.DateTimePicker dtDateRecive;
    }
}