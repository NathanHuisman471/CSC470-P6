using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5
{
    public partial class FormModifyIssue : Form
    {
        AppUser _CurrentAppUser;
        int _SelectedProjectId;
        public FormModifyIssue(AppUser appUser)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
        }

        private void FormModifyIssue_Load(object sender, EventArgs e)
        {
            dateTimediscovery.Value = DateTime.Now;
            dateTimediscovery.Format = DateTimePickerFormat.Custom;
            dateTimediscovery.CustomFormat = "hh:mm:ss tt dd MMM yyyy";
            this.CenterToScreen();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int newId = Int32.Parse(textBoxid.Text);
            string newIssueTitle = textBoxtitle.Text.Trim();
            string newIssueDiscoverer = comboBoxdiscoverer.Text.Trim();
            string newIssueComponent = textBoxcomponent.Text.Trim();
            string newDescription = textBoxdescription.Text.Trim();
            string newStatusId = comboBoxstatus.Text.Trim();  //This has to be converted to an int depending on the text
            DateTime newDate = dateTimediscovery.Value;

            //This is only used for testing purposes before newStatusId is converted to an int, should be removed
            int tempStatusId = 1;

            if(newIssueTitle == "")
            {
                MessageBox.Show("Issue name cannot be empty or blank", "Attention");
                return;
            }
            FakeIssueRepository issueRepository = new FakeIssueRepository();
            
            Issue issue = new Issue { Id = newId, ProjectId = _SelectedProjectId, Title = newIssueTitle, DiscoveryDate = newDate, Discoverer = newIssueDiscoverer, InitialDescription = newDescription, Component = newIssueComponent, IssueStatusId = tempStatusId };
            string result = issueRepository.Modify(issue);
            if (result != FakeIssueRepository.NO_ERROR)
            {
                MessageBox.Show("Error modifying issue.  Error: " + result);
            }
            else
            {
                MessageBox.Show("Issue modification successful.", "Information");
                this.Close();
            }
        }
    }
}
