namespace ToysSale
{
    partial class FormChoice
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
            this.lstList = new System.Windows.Forms.ListBox();
            this.Choice = new System.Windows.Forms.Button();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstList
            // 
            this.lstList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstList.FormattingEnabled = true;
            this.lstList.Location = new System.Drawing.Point(12, 12);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(353, 238);
            this.lstList.TabIndex = 0;
            this.lstList.DoubleClick += new System.EventHandler(this.Choice_Click);
            // 
            // Choice
            // 
            this.Choice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Choice.Location = new System.Drawing.Point(270, 260);
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(95, 43);
            this.Choice.TabIndex = 1;
            this.Choice.Text = "Выбрать";
            this.Choice.UseVisualStyleBackColor = true;
            this.Choice.Click += new System.EventHandler(this.Choice_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilter.Controls.Add(this.btnOk);
            this.gbFilter.Controls.Add(this.txtFilter);
            this.gbFilter.Location = new System.Drawing.Point(12, 255);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(252, 48);
            this.gbFilter.TabIndex = 2;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Фильтр";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(215, 19);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(31, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(7, 20);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(202, 20);
            this.txtFilter.TabIndex = 0;
            // 
            // FormChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 315);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.Choice);
            this.Controls.Add(this.lstList);
            this.MinimumSize = new System.Drawing.Size(393, 353);
            this.Name = "FormChoice";
            this.Text = "Сделайте Выбор!";
            this.Shown += new System.EventHandler(this.FormChoice_Shown);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.Button Choice;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtFilter;
    }
}