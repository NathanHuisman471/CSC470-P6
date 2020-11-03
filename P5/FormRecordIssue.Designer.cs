namespace P5
{
    partial class FormRecordIssue
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CreateIssueButton = new System.Windows.Forms.Button();
            this.comboBoxdiscoverer = new System.Windows.Forms.ComboBox();
            this.comboBoxstatus = new System.Windows.Forms.ComboBox();
            this.textBoxtitle = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxcomponent = new System.Windows.Forms.TextBox();
            this.dateTimediscovery = new System.Windows.Forms.DateTimePicker();
            this.textBoxdescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discovery Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Discoverer: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Component: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Initial Description";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(236, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CreateIssueButton
            // 
            this.CreateIssueButton.Location = new System.Drawing.Point(333, 444);
            this.CreateIssueButton.Name = "CreateIssueButton";
            this.CreateIssueButton.Size = new System.Drawing.Size(75, 23);
            this.CreateIssueButton.TabIndex = 8;
            this.CreateIssueButton.Text = "Create Issue";
            this.CreateIssueButton.UseVisualStyleBackColor = true;
            this.CreateIssueButton.Click += new System.EventHandler(this.CreateIssueButton_Click);
            // 
            // comboBoxdiscoverer
            // 
            this.comboBoxdiscoverer.FormattingEnabled = true;
            this.comboBoxdiscoverer.Location = new System.Drawing.Point(119, 123);
            this.comboBoxdiscoverer.Name = "comboBoxdiscoverer";
            this.comboBoxdiscoverer.Size = new System.Drawing.Size(289, 21);
            this.comboBoxdiscoverer.TabIndex = 11;
            // 
            // comboBoxstatus
            // 
            this.comboBoxstatus.FormattingEnabled = true;
            this.comboBoxstatus.Location = new System.Drawing.Point(119, 180);
            this.comboBoxstatus.Name = "comboBoxstatus";
            this.comboBoxstatus.Size = new System.Drawing.Size(289, 21);
            this.comboBoxstatus.TabIndex = 12;
            // 
            // textBoxtitle
            // 
            this.textBoxtitle.Location = new System.Drawing.Point(119, 61);
            this.textBoxtitle.Name = "textBoxtitle";
            this.textBoxtitle.Size = new System.Drawing.Size(289, 20);
            this.textBoxtitle.TabIndex = 13;
            // 
            // textBoxid
            // 
            this.textBoxid.Enabled = false;
            this.textBoxid.Location = new System.Drawing.Point(119, 32);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(60, 20);
            this.textBoxid.TabIndex = 14;
            this.textBoxid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxcomponent
            // 
            this.textBoxcomponent.Location = new System.Drawing.Point(119, 153);
            this.textBoxcomponent.Name = "textBoxcomponent";
            this.textBoxcomponent.Size = new System.Drawing.Size(289, 20);
            this.textBoxcomponent.TabIndex = 15;
            // 
            // dateTimediscovery
            // 
            this.dateTimediscovery.Location = new System.Drawing.Point(119, 94);
            this.dateTimediscovery.MaxDate = new System.DateTime(2420, 12, 31, 0, 0, 0, 0);
            this.dateTimediscovery.Name = "dateTimediscovery";
            this.dateTimediscovery.Size = new System.Drawing.Size(289, 20);
            this.dateTimediscovery.TabIndex = 33;
            this.dateTimediscovery.Value = new System.DateTime(2020, 10, 28, 0, 0, 0, 0);
            // 
            // textBoxdescription
            // 
            this.textBoxdescription.Location = new System.Drawing.Point(119, 223);
            this.textBoxdescription.Multiline = true;
            this.textBoxdescription.Name = "textBoxdescription";
            this.textBoxdescription.Size = new System.Drawing.Size(289, 205);
            this.textBoxdescription.TabIndex = 34;
            // 
            // FormRecordIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 489);
            this.Controls.Add(this.textBoxdescription);
            this.Controls.Add(this.dateTimediscovery);
            this.Controls.Add(this.textBoxcomponent);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.textBoxtitle);
            this.Controls.Add(this.comboBoxstatus);
            this.Controls.Add(this.comboBoxdiscoverer);
            this.Controls.Add(this.CreateIssueButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRecordIssue";
            this.Text = "Record Issue";
            this.Load += new System.EventHandler(this.FormRecordIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CreateIssueButton;
        private System.Windows.Forms.ComboBox comboBoxdiscoverer;
        private System.Windows.Forms.ComboBox comboBoxstatus;
        private System.Windows.Forms.TextBox textBoxtitle;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxcomponent;
        private System.Windows.Forms.DateTimePicker dateTimediscovery;
        private System.Windows.Forms.TextBox textBoxdescription;
    }
}