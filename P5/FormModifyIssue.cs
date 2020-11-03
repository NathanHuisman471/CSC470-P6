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
        public int _SelectedIssueId = 0;

        FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
        FakeAppUserRepository userRepository = new FakeAppUserRepository();
        FakeIssueRepository issueRepository = new FakeIssueRepository();
        FakeIssueStatusRepository issueStatusRepository = new FakeIssueStatusRepository();
        public FormModifyIssue(int selectedIssueId)
        {
            InitializeComponent();
            _SelectedIssueId = selectedIssueId;
        }
        
        private void FormModifyIssue_Load(object sender, EventArgs e)
        {
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            //int newId = Int32.Parse(textBoxid.Text); is this needed? I'm not sure if we are supposed to modify the id. It is greyed out in the example
            string newIssueTitle = textBoxtitle.Text.Trim();
            string newIssueDiscoverer = comboBoxdiscoverer.Text.Trim();
            string newIssueComponent = textBoxcomponent.Text.Trim();
            string newDescription = textBoxdescription.Text.Trim();
            int newStatusId = issueStatusRepository.GetIdByStatus(comboBoxstatus.Text);
            DateTime newDate = dateTimediscovery.Value;
            _SelectedProjectId = Convert.ToInt32(preferenceRepository.GetPreference(_CurrentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));

            if(newIssueTitle == "")
            {
                MessageBox.Show("Issue name cannot be empty or blank", "Attention");
                return;
            }
            FakeIssueRepository issueRepository = new FakeIssueRepository();
            
            Issue issue = new Issue { ProjectId = _SelectedProjectId, Title = newIssueTitle, DiscoveryDate = newDate, Discoverer = newIssueDiscoverer, InitialDescription = newDescription, Component = newIssueComponent, IssueStatusId = newStatusId };
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
