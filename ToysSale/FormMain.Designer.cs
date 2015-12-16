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
            this.упавлениеПокупкамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеМагазином3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаПодключенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.упавлениеПокупкамиToolStripMenuItem,
            this.управлениеМагазином3ToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.настройкаПодключенияToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(595, 24);
            this.msMainMenu.TabIndex = 2;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // упавлениеПокупкамиToolStripMenuItem
            // 
            this.упавлениеПокупкамиToolStripMenuItem.Name = "упавлениеПокупкамиToolStripMenuItem";
            this.упавлениеПокупкамиToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.упавлениеПокупкамиToolStripMenuItem.Text = "Упавление покупками";
            // 
            // управлениеМагазином3ToolStripMenuItem
            // 
            this.управлениеМагазином3ToolStripMenuItem.Name = "управлениеМагазином3ToolStripMenuItem";
            this.управлениеМагазином3ToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.управлениеМагазином3ToolStripMenuItem.Text = "Управление магазином";
            // 
            // настройкаПодключенияToolStripMenuItem
            // 
            this.настройкаПодключенияToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.настройкаПодключенияToolStripMenuItem.Name = "настройкаПодключенияToolStripMenuItem";
            this.настройкаПодключенияToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.настройкаПодключенияToolStripMenuItem.Text = "Настройка подключения";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.OrangeRed;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 307);
            this.Controls.Add(this.msMainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem упавлениеПокупкамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеМагазином3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаПодключенияToolStripMenuItem;
    }
}

