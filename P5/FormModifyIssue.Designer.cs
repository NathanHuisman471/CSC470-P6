namespace P5
{
    partial class FormModifyIssue
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
            this.textBoxcomponent = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxtitle = new System.Windows.Forms.TextBox();
            this.comboBoxstatus = new System.Windows.Forms.ComboBox();
            this.comboBoxdiscoverer = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimediscovery = new System.Windows.Forms.DateTimePicker();
            this.textBoxdescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxcomponent
            // 
            this.textBoxcomponent.Location = new System.Drawing.Point(115, 152);
            this.textBoxcomponent.Name = "textBoxcomponent";
            this.textBoxcomponent.Size = new System.Drawing.Size(289, 20);
            this.textBoxcomponent.TabIndex = 31;
            // 
            // textBoxid
            // 
            this.textBoxid.Enabled = false;
            this.textBoxid.Location = new System.Drawing.Point(115, 31);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(60, 20);
            this.textBoxid.TabIndex = 30;
            this.textBoxid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxtitle
            // 
            this.textBoxtitle.Location = new System.Drawing.Point(115, 60);
            this.textBoxtitle.Name = "textBoxtitle";
            this.textBoxtitle.Size = new System.Drawing.Size(289, 20);
            this.textBoxtitle.TabIndex = 29;
            // 
            // comboBoxstatus
            // 
            this.comboBoxstatus.FormattingEnabled = true;
            this.comboBoxstatus.Location = new System.Drawing.Point(115, 179);
            this.comboBoxstatus.Name = "comboBoxstatus";
            this.comboBoxstatus.Size = new System.Drawing.Size(289, 21);
            this.comboBoxstatus.TabIndex = 28;
            // 
            // comboBoxdiscoverer
            // 
            this.comboBoxdiscoverer.Enabled = false;
            this.comboBoxdiscoverer.FormattingEnabled = true;
            this.comboBoxdiscoverer.Location = new System.Drawing.Point(115, 122);
            this.comboBoxdiscoverer.Name = "comboBoxdiscoverer";
            this.comboBoxdiscoverer.Size = new System.Drawing.Size(289, 21);
            this.comboBoxdiscoverer.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Modify Issue";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(232, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Initial Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Status: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Component: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Discoverer: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Discovery Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Title: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id: ";
            // 
            // dateTimediscovery
            // 
            this.dateTimediscovery.CustomFormat = "";
            this.dateTimediscovery.Location = new System.Drawing.Point(115, 93);
            this.dateTimediscovery.MaxDate = new System.DateTime(2420, 12, 31, 0, 0, 0, 0);
            this.dateTimediscovery.Name = "dateTimediscovery";
            this.dateTimediscovery.Size = new System.Drawing.Size(289, 20);
            this.dateTimediscovery.TabIndex = 32;
            this.dateTimediscovery.Value = new System.DateTime(2020, 10, 7, 0, 0, 0, 0);
            // 
            // textBoxdescription
            // 
            this.textBoxdescription.Location = new System.Drawing.Point(115, 222);
            this.textBoxdescription.Multiline = true;
            this.textBoxdescription.Name = "textBoxdescription";
            this.textBoxdescription.Size = new System.Drawing.Size(289, 205);
            this.textBoxdescription.TabIndex = 33;
            // 
            // FormModifyIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 488);
            this.Controls.Add(this.textBoxdescription);
            this.Controls.Add(this.dateTimediscovery);
            this.Controls.Add(this.textBoxcomponent);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.textBoxtitle);
            this.Controls.Add(this.comboBoxstatus);
            this.Controls.Add(this.comboBoxdiscoverer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormModifyIssue";
            this.Text = "Modify Issue";
            this.Load += new System.EventHandler(this.FormModifyIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxcomponent;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxtitle;
        private System.Windows.Forms.ComboBox comboBoxstatus;
        private System.Windows.Forms.ComboBox comboBoxdiscoverer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimediscovery;
        private System.Windows.Forms.TextBox textBoxdescription;
    }
}