using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace P5
{
    public partial class FormIssueDashboard : Form
    {
        AppUser _CurrentAppUser;
        int _SelectedProjectId;
        FakeIssueRepository _IssueRepository = new FakeIssueRepository();
        FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();

        public FormIssueDashboard(AppUser appUser)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
            _SelectedProjectId = Convert.ToInt32(preferenceRepository.GetPreference(_CurrentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));
        }

        private void FormIssueDashboard_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            labelissues.Text = Convert.ToString(_IssueRepository.GetTotalNumberOfIssues(_SelectedProjectId));
            int numberofissues = Convert.ToInt32(_IssueRepository.GetTotalNumberOfIssues(_SelectedProjectId));
            foreach (string issues in _IssueRepository.GetIssuesByMonth(_SelectedProjectId))
            {
                listBox1.Items.Add(issues);
            }

            /*
            for (int i = 0; i < numberofissues; i++)
            {
                _IssueRepository.GetIssueById(i);
            }
            */
            foreach (string discoverer in _IssueRepository.GetIssuesByDiscoverer(_SelectedProjectId))
            {
                string checkitem = discoverer;
                int count = discoverer.Count();
                if (listBox2.Items.Contains(checkitem) == false)
                {
                    listBox2.Items.Add(discoverer + ": " + numberofissues);
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
