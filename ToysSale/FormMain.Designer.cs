namespace ToysSale
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmSaleManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMagasineManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQDebitGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageClients = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageNomenclature = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageSupply = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManagediscount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSetUpConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewSale = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDebitGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewSale,
            this.tsmSaleManage,
            this.tsmMagasineManage,
            this.tsmExit,
            this.tsmSetUpConnection});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(610, 24);
            this.msMainMenu.TabIndex = 2;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // tsmSaleManage
            // 
            this.tsmSaleManage.Name = "tsmSaleManage";
            this.tsmSaleManage.Size = new System.Drawing.Size(142, 20);
            this.tsmSaleManage.Text = "Упавление покупками";
            this.tsmSaleManage.Click += new System.EventHandler(this.tsmSaleManage_Click);
            // 
            // tsmMagasineManage
            // 
            this.tsmMagasineManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmQDebitGoods,
            this.tsmDebitGoods,
            this.tsmManageClients,
            this.tsmManageNomenclature,
            this.tsmManageDepartment,
            this.tsmManageStaff,
            this.tsmManageSupply,
            this.tsmManagediscount,
            this.tsmManageGoods});
            this.tsmMagasineManage.Name = "tsmMagasineManage";
            this.tsmMagasineManage.Size = new System.Drawing.Size(149, 20);
            this.tsmMagasineManage.Text = "Управление магазином";
            // 
            // tsmQDebitGoods
            // 
            this.tsmQDebitGoods.Name = "tsmQDebitGoods";
            this.tsmQDebitGoods.Size = new System.Drawing.Size(300, 22);
            this.tsmQDebitGoods.Text = "Быстро ориходовать поступивший товар";
            this.tsmQDebitGoods.Click += new System.EventHandler(this.tsmQDebitGoods_Click);
            // 
            // tsmManageClients
            // 
            this.tsmManageClients.Name = "tsmManageClients";
            this.tsmManageClients.Size = new System.Drawing.Size(300, 22);
            this.tsmManageClients.Text = "Управление клиентами";
            this.tsmManageClients.Click += new System.EventHandler(this.tsmManageClients_Click);
            // 
            // tsmManageNomenclature
            // 
            this.tsmManageNomenclature.Name = "tsmManageNomenclature";
            this.tsmManageNomenclature.Size = new System.Drawing.Size(300, 22);
            this.tsmManageNomenclature.Text = "Управление номенклатурой";
            this.tsmManageNomenclature.Click += new System.EventHandler(this.tsmManageNomenclature_Click);
            // 
            // tsmManageDepartment
            // 
            this.tsmManageDepartment.Name = "tsmManageDepartment";
            this.tsmManageDepartment.Size = new System.Drawing.Size(300, 22);
            this.tsmManageDepartment.Text = "Управление отделами компании";
            this.tsmManageDepartment.Click += new System.EventHandler(this.tsmManageDepartment_Click);
            // 
            // tsmManageStaff
            // 
            this.tsmManageStaff.Name = "tsmManageStaff";
            this.tsmManageStaff.Size = new System.Drawing.Size(300, 22);
            this.tsmManageStaff.Text = "Управление персоналом";
            this.tsmManageStaff.Click += new System.EventHandler(this.tsmManageStaff_Click);
            // 
            // tsmManageSupply
            // 
            this.tsmManageSupply.Name = "tsmManageSupply";
            this.tsmManageSupply.Size = new System.Drawing.Size(300, 22);
            this.tsmManageSupply.Text = "Управление поставками товара";
            this.tsmManageSupply.Click += new System.EventHandler(this.tsmManageSupply_Click);
            // 
            // tsmManagediscount
            // 
            this.tsmManagediscount.Name = "tsmManagediscount";
            this.tsmManagediscount.Size = new System.Drawing.Size(300, 22);
            this.tsmManagediscount.Text = "Управление скидками";
            this.tsmManagediscount.Click += new System.EventHandler(this.tsmManagediscount_Click);
            // 
            // tsmManageGoods
            // 
            this.tsmManageGoods.Name = "tsmManageGoods";
            this.tsmManageGoods.Size = new System.Drawing.Size(300, 22);
            this.tsmManageGoods.Text = "Управление товаром";
            this.tsmManageGoods.Click += new System.EventHandler(this.tsmManageGoods_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmExit.BackColor = System.Drawing.Color.OrangeRed;
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(53, 20);
            this.tsmExit.Text = "Выход";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmSetUpConnection
            // 
            this.tsmSetUpConnection.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmSetUpConnection.Name = "tsmSetUpConnection";
            this.tsmSetUpConnection.Size = new System.Drawing.Size(157, 20);
            this.tsmSetUpConnection.Text = "Настройка подключения";
            this.tsmSetUpConnection.Click += new System.EventHandler(this.tsmSetUpConnection_Click);
            // 
            // tsmNewSale
            // 
            this.tsmNewSale.Name = "tsmNewSale";
            this.tsmNewSale.Size = new System.Drawing.Size(101, 20);
            this.tsmNewSale.Text = "Новая покупка";
            this.tsmNewSale.Click += new System.EventHandler(this.tsmNewSale_Click);
            // 
            // tsmDebitGoods
            // 
            this.tsmDebitGoods.Name = "tsmDebitGoods";
            this.tsmDebitGoods.Size = new System.Drawing.Size(300, 22);
            this.tsmDebitGoods.Text = "Оприходовать поступивший товар";
            this.tsmDebitGoods.Click += new System.EventHandler(this.tsmDebitGoods_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 384);
            this.Controls.Add(this.msMainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "FormMain";
            this.Text = "Магазин игрушек";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmSaleManage;
        private System.Windows.Forms.ToolStripMenuItem tsmMagasineManage;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmSetUpConnection;
        private System.Windows.Forms.ToolStripMenuItem tsmManageGoods;
        private System.Windows.Forms.ToolStripMenuItem tsmManageStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmManageClients;
        private System.Windows.Forms.ToolStripMenuItem tsmManageSupply;
        private System.Windows.Forms.ToolStripMenuItem tsmManageNomenclature;
        private System.Windows.Forms.ToolStripMenuItem tsmManageDepartment;
        private System.Windows.Forms.ToolStripMenuItem tsmQDebitGoods;
        private System.Windows.Forms.ToolStripMenuItem tsmManagediscount;
        private System.Windows.Forms.ToolStripMenuItem tsmNewSale;
        private System.Windows.Forms.ToolStripMenuItem tsmDebitGoods;
    }
}

