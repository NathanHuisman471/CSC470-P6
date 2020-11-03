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

            //populates the options for the drop downs
            foreach (AppUser appUser in userRepository.GetAll())
            {
                comboBoxdiscoverer.Items.Add(appUser.LastName + ", " + appUser.FirstName);
            }

            foreach (IssueStatus issueStatus in issueStatusRepository.GetAll())
            {
                comboBoxstatus.Items.Add(issueStatus.Value);
            }

            //set initial values from selected issue
            Issue issue = issueRepository.GetIssueById(_SelectedIssueId);
            textBoxid.Text = Convert.ToString(issue.Id);
            textBoxtitle.Text = Convert.ToString(issue.Title);
            dateTimediscovery.Value = issue.DiscoveryDate;
            comboBoxdiscoverer.SelectedItem = issue.Discoverer;
            textBoxcomponent.Text = issue.Component;
            comboBoxstatus.Text = issueStatusRepository.GetValueById(issue.IssueStatusId);
            textBoxdescription.Text = issue.InitialDescription;

            this.CenterToScreen();

        }

        private void ButtonModifyIssue_click(object sender, EventArgs e)
        {
            //int newId = Int32.Parse(textBoxid.Text); is this needed? I'm not sure if we are supposed to modify the id. It is greyed out in the example
            string newIssueTitle = textBoxtitle.Text.Trim();
            string newIssueDiscoverer = comboBoxdiscoverer.Text.Trim();
            string newIssueComponent = textBoxcomponent.Text.Trim();
            string newDescription = textBoxdescription.Text.Trim();
            int newStatusId = issueStatusRepository.GetIdByStatus(comboBoxstatus.Text);
            DateTime newDate = dateTimediscovery.Value;
            //_SelectedIssueId = Convert.ToInt32(preferenceRepository.GetPreference(_CurrentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));

            if(newIssueTitle == "")
            {
                MessageBox.Show("Issue name cannot be empty or blank", "Attention");
                return;
            }
            FakeIssueRepository issueRepository = new FakeIssueRepository();
            
            Issue issue = new Issue { Id = _SelectedIssueId, Title = newIssueTitle, DiscoveryDate = newDate, Discoverer = newIssueDiscoverer, InitialDescription = newDescription, Component = newIssueComponent, IssueStatusId = newStatusId };
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
