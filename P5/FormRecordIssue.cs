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
    public partial class FormRecordIssue : Form
    {
        AppUser _CurrentAppUser;
        int _SelectedProjectId;
        FakeAppUserRepository userRepository = new FakeAppUserRepository();
        FakeIssueRepository issueRepository = new FakeIssueRepository();
        FakeIssueStatusRepository issueStatusRepository = new FakeIssueStatusRepository();
        public FormRecordIssue(AppUser appUser)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
        }

        private void FormRecordIssue_Load(object sender, EventArgs e)
        {
            dateTimediscovery.Value = DateTime.Now;
            dateTimediscovery.Format = DateTimePickerFormat.Custom;
            dateTimediscovery.CustomFormat = "hh:mm:ss tt dd MMM yyyy";

            foreach (AppUser appUser in userRepository.GetAll())
            {
                comboBoxdiscoverer.Items.Add(appUser.LastName + ", " + appUser.FirstName);
            }

            foreach (IssueStatus issueStatus in issueStatusRepository.GetAll())
            {
                comboBoxstatus.Items.Add(issueStatus.Value);
            }
            this.CenterToScreen();
        }

        private void CreateIssueButton_Click(object sender, EventArgs e)
        {
            Issue issue = new Issue();
            issue.Id = 0;
            issue.Title = textBoxtitle.Text.Trim();
            issue.DiscoveryDate = DateTime.Parse(dateTimediscovery.Text);
            issue.Discoverer = comboBoxdiscoverer.Text;
            issue.InitialDescription = textBoxdescription.Text;
            issue.Component = textBoxcomponent.Text;
            issue.IssueStatusId = issueStatusRepository.GetIdByStatus(comboBoxstatus.Text);

            string result = issueRepository.Add(issue);
            if (result == FakeIssueRepository.NO_ERROR)
            {
                MessageBox.Show("Issue added successfully.");
            }
            else
            {
                MessageBox.Show("Issue not created. " + result, "Attention.");
            }
            this.Close();
        }
    }
}
