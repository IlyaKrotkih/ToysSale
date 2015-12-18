namespace ToysSale
{
    partial class FormConnect
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
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lstBD = new System.Windows.Forms.ListBox();
            this.txtAddres = new System.Windows.Forms.TextBox();
            this.btnGetList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewCollection = new System.Windows.Forms.TextBox();
            this.chkNewCollection = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnect.Location = new System.Drawing.Point(12, 254);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(196, 23);
            this.btnDisconnect.TabIndex = 0;
            this.btnDisconnect.Text = "Отключить";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(12, 231);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(196, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Подключить";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lstBD
            // 
            this.lstBD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBD.FormattingEnabled = true;
            this.lstBD.Location = new System.Drawing.Point(13, 47);
            this.lstBD.Name = "lstBD";
            this.lstBD.Size = new System.Drawing.Size(196, 134);
            this.lstBD.TabIndex = 2;
            // 
            // txtAddres
            // 
            this.txtAddres.Location = new System.Drawing.Point(12, 21);
            this.txtAddres.Name = "txtAddres";
            this.txtAddres.Size = new System.Drawing.Size(144, 20);
            this.txtAddres.TabIndex = 3;
            this.txtAddres.Text = "localhost";
            // 
            // btnGetList
            // 
            this.btnGetList.Location = new System.Drawing.Point(164, 19);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(45, 23);
            this.btnGetList.TabIndex = 4;
            this.btnGetList.Text = "OK";
            this.btnGetList.UseVisualStyleBackColor = true;
            this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сервер:";
            // 
            // txtNewCollection
            // 
            this.txtNewCollection.Location = new System.Drawing.Point(13, 205);
            this.txtNewCollection.Name = "txtNewCollection";
            this.txtNewCollection.Size = new System.Drawing.Size(196, 20);
            this.txtNewCollection.TabIndex = 6;
            // 
            // chkNewCollection
            // 
            this.chkNewCollection.AutoSize = true;
            this.chkNewCollection.Location = new System.Drawing.Point(13, 188);
            this.chkNewCollection.Name = "chkNewCollection";
            this.chkNewCollection.Size = new System.Drawing.Size(120, 17);
            this.chkNewCollection.TabIndex = 7;
            this.chkNewCollection.Text = "Другая коллекция";
            this.chkNewCollection.UseVisualStyleBackColor = true;
            this.chkNewCollection.CheckedChanged += new System.EventHandler(this.chkNewCollection_CheckedChanged);
            // 
            // FormConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 290);
            this.Controls.Add(this.chkNewCollection);
            this.Controls.Add(this.txtNewCollection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetList);
            this.Controls.Add(this.txtAddres);
            this.Controls.Add(this.lstBD);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnDisconnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormConnect";
            this.Text = "Подключение";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConnect_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox lstBD;
        private System.Windows.Forms.TextBox txtAddres;
        private System.Windows.Forms.Button btnGetList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewCollection;
        private System.Windows.Forms.CheckBox chkNewCollection;
    }
}