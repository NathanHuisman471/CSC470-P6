namespace P5
{
    partial class FormIssueDashboard
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
            this.labelissues = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxIssuesByMonth = new System.Windows.Forms.ListBox();
            this.listBoxIssuesByDiscoverer = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Number of Issues: ";
            // 
            // labelissues
            // 
            this.labelissues.AutoSize = true;
            this.labelissues.Location = new System.Drawing.Point(163, 41);
            this.labelissues.Name = "labelissues";
            this.labelissues.Size = new System.Drawing.Size(64, 13);
            this.labelissues.TabIndex = 1;
            this.labelissues.Text = "Change me!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Issues by Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Issues by Discoverer";
            // 
            // listBoxIssuesByMonth
            // 
            this.listBoxIssuesByMonth.FormattingEnabled = true;
            this.listBoxIssuesByMonth.Location = new System.Drawing.Point(38, 97);
            this.listBoxIssuesByMonth.Name = "listBoxIssuesByMonth";
            this.listBoxIssuesByMonth.Size = new System.Drawing.Size(198, 108);
            this.listBoxIssuesByMonth.TabIndex = 4;
            this.listBoxIssuesByMonth.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxIssuesByDiscoverer
            // 
            this.listBoxIssuesByDiscoverer.FormattingEnabled = true;
            this.listBoxIssuesByDiscoverer.Location = new System.Drawing.Point(38, 244);
            this.listBoxIssuesByDiscoverer.Name = "listBoxIssuesByDiscoverer";
            this.listBoxIssuesByDiscoverer.Size = new System.Drawing.Size(198, 108);
            this.listBoxIssuesByDiscoverer.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(161, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormIssueDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxIssuesByDiscoverer);
            this.Controls.Add(this.listBoxIssuesByMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelissues);
            this.Controls.Add(this.label1);
            this.Name = "FormIssueDashboard";
            this.Text = "Issue Dashboard";
            this.Load += new System.EventHandler(this.FormIssueDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelissues;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxIssuesByMonth;
        private System.Windows.Forms.ListBox listBoxIssuesByDiscoverer;
        private System.Windows.Forms.Button button1;
    }
}