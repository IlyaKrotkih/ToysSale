namespace ToysSale
{
    partial class FormClient
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
            this.btnCancell = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPatronumic = new System.Windows.Forms.Label();
            this.lblDateRegistration = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPatronumic = new System.Windows.Forms.TextBox();
            this.dtDateRegistration = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.12717F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.87283F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancell, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblLastName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFirstName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPatronumic, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDateRegistration, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFirstName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPatronumic, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtDateRegistration, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(346, 125);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCancell
            // 
            this.btnCancell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancell.Location = new System.Drawing.Point(3, 99);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(119, 23);
            this.btnCancell.TabIndex = 0;
            this.btnCancell.Text = "Отмена";
            this.btnCancell.UseVisualStyleBackColor = true;
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(128, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(215, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastName.Location = new System.Drawing.Point(3, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(119, 24);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Фамилия";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstName.Location = new System.Drawing.Point(3, 24);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(119, 24);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Имя";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPatronumic
            // 
            this.lblPatronumic.AutoSize = true;
            this.lblPatronumic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPatronumic.Location = new System.Drawing.Point(3, 48);
            this.lblPatronumic.Name = "lblPatronumic";
            this.lblPatronumic.Size = new System.Drawing.Size(119, 24);
            this.lblPatronumic.TabIndex = 1;
            this.lblPatronumic.Text = "Отчество";
            this.lblPatronumic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateRegistration
            // 
            this.lblDateRegistration.AutoSize = true;
            this.lblDateRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateRegistration.Location = new System.Drawing.Point(3, 72);
            this.lblDateRegistration.Name = "lblDateRegistration";
            this.lblDateRegistration.Size = new System.Drawing.Size(119, 24);
            this.lblDateRegistration.TabIndex = 1;
            this.lblDateRegistration.Text = "Дата регистрации";
            this.lblDateRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(128, 3);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(215, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(128, 27);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(215, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtPatronumic
            // 
            this.txtPatronumic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatronumic.Location = new System.Drawing.Point(128, 51);
            this.txtPatronumic.Name = "txtPatronumic";
            this.txtPatronumic.Size = new System.Drawing.Size(215, 20);
            this.txtPatronumic.TabIndex = 3;
            // 
            // dtDateRegistration
            // 
            this.dtDateRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDateRegistration.Location = new System.Drawing.Point(128, 75);
            this.dtDateRegistration.Name = "dtDateRegistration";
            this.dtDateRegistration.Size = new System.Drawing.Size(215, 20);
            this.dtDateRegistration.TabIndex = 4;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 125);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(362, 164);
            this.Name = "FormClient";
            this.Text = "Регистрация клиента";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPatronumic;
        private System.Windows.Forms.Label lblDateRegistration;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPatronumic;
        private System.Windows.Forms.DateTimePicker dtDateRegistration;
    }
}