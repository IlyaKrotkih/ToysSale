namespace ToysSale
{
    partial class FormStaff
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
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPosittion = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblDateApplyToWork = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPatronunic = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.dtAppyToWork = new System.Windows.Forms.DateTimePicker();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.94132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.05868F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancell, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblLastName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFirstName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPatronumic, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDepartment, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPosittion, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSalary, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDateApplyToWork, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFirstName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPatronunic, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPosition, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.numSalary, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtAppyToWork, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnDepartment, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 211);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCancell
            // 
            this.btnCancell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancell.Location = new System.Drawing.Point(3, 185);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(127, 23);
            this.btnCancell.TabIndex = 0;
            this.btnCancell.Text = "Отмена";
            this.btnCancell.UseVisualStyleBackColor = true;
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(136, 185);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(233, 23);
            this.btnSave.TabIndex = 0;
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
            this.lblLastName.Size = new System.Drawing.Size(127, 26);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Фамилия";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstName.Location = new System.Drawing.Point(3, 26);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(127, 26);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Имя";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPatronumic
            // 
            this.lblPatronumic.AutoSize = true;
            this.lblPatronumic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPatronumic.Location = new System.Drawing.Point(3, 52);
            this.lblPatronumic.Name = "lblPatronumic";
            this.lblPatronumic.Size = new System.Drawing.Size(127, 26);
            this.lblPatronumic.TabIndex = 1;
            this.lblPatronumic.Text = "Отчество";
            this.lblPatronumic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDepartment.Location = new System.Drawing.Point(3, 78);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(127, 26);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "Рабочий отдел";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPosittion
            // 
            this.lblPosittion.AutoSize = true;
            this.lblPosittion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPosittion.Location = new System.Drawing.Point(3, 104);
            this.lblPosittion.Name = "lblPosittion";
            this.lblPosittion.Size = new System.Drawing.Size(127, 26);
            this.lblPosittion.TabIndex = 1;
            this.lblPosittion.Text = "Должность";
            this.lblPosittion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSalary.Location = new System.Drawing.Point(3, 130);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(127, 26);
            this.lblSalary.TabIndex = 1;
            this.lblSalary.Text = "Оклад";
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateApplyToWork
            // 
            this.lblDateApplyToWork.AutoSize = true;
            this.lblDateApplyToWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateApplyToWork.Location = new System.Drawing.Point(3, 156);
            this.lblDateApplyToWork.Name = "lblDateApplyToWork";
            this.lblDateApplyToWork.Size = new System.Drawing.Size(127, 26);
            this.lblDateApplyToWork.TabIndex = 1;
            this.lblDateApplyToWork.Text = "Дата приема на работу";
            this.lblDateApplyToWork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(136, 3);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(233, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(136, 29);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(233, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtPatronunic
            // 
            this.txtPatronunic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatronunic.Location = new System.Drawing.Point(136, 55);
            this.txtPatronunic.Name = "txtPatronunic";
            this.txtPatronunic.Size = new System.Drawing.Size(233, 20);
            this.txtPatronunic.TabIndex = 2;
            // 
            // txtPosition
            // 
            this.txtPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPosition.Location = new System.Drawing.Point(136, 107);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(233, 20);
            this.txtPosition.TabIndex = 2;
            // 
            // numSalary
            // 
            this.numSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numSalary.DecimalPlaces = 2;
            this.numSalary.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSalary.Location = new System.Drawing.Point(136, 133);
            this.numSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSalary.Name = "numSalary";
            this.numSalary.Size = new System.Drawing.Size(233, 20);
            this.numSalary.TabIndex = 4;
            // 
            // dtAppyToWork
            // 
            this.dtAppyToWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtAppyToWork.Location = new System.Drawing.Point(136, 159);
            this.dtAppyToWork.Name = "dtAppyToWork";
            this.dtAppyToWork.Size = new System.Drawing.Size(233, 20);
            this.dtAppyToWork.TabIndex = 5;
            // 
            // btnDepartment
            // 
            this.btnDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDepartment.Location = new System.Drawing.Point(136, 81);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(233, 20);
            this.btnDepartment.TabIndex = 6;
            this.btnDepartment.Text = "Отдел";
            this.btnDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 211);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(388, 250);
            this.Name = "FormStaff";
            this.Text = "Добавить работника";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPatronumic;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPosittion;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblDateApplyToWork;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPatronunic;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.NumericUpDown numSalary;
        private System.Windows.Forms.DateTimePicker dtAppyToWork;
        private System.Windows.Forms.Button btnDepartment;
    }
}