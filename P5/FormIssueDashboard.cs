using System;
using System.Collections.Generic;
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
            UpdateIssuesByMonth(_SelectedProjectId);
            labelissues.Text = Convert.ToString(_IssueRepository.GetTotalNumberOfIssues(_SelectedProjectId));
            int numberofissues = Convert.ToInt32(_IssueRepository.GetTotalNumberOfIssues(_SelectedProjectId));
            /*
            foreach (string issues in _IssueRepository.GetIssuesByMonth(_SelectedProjectId))
            {
                listBox1.Items.Add(issues);
            }

*/
            foreach (string discoverer in _IssueRepository.GetIssuesByDiscoverer(_SelectedProjectId))
            {
                int count = discoverer.Count();
                string stringToAdd = discoverer + ": " + numberofissues;
                
                if (listBoxIssuesByDiscoverer.Items.Contains(stringToAdd) == false)
                {
                    listBoxIssuesByDiscoverer.Items.Add(stringToAdd);
                }
            } 
            
        }

        private void UpdateIssuesByMonth(int projectId)
        {
            FakeIssueRepository issueRepository = new FakeIssueRepository();
            List<string> issuesByMonthList = issueRepository.GetIssuesByMonth(projectId);

            var issuesByMonthCount =
            from issue in issuesByMonthList
            group issue by issue into monthGroup
            select new
            {
                Month = monthGroup.Key.ToString() + ": " + monthGroup.Count().ToString()
            };

            for (int i = 0; i < issuesByMonthCount.Count(); i++)
            {
                string line = parseIssuesByMonth(issuesByMonthCount.ElementAt(i).ToString());
                listBoxIssuesByMonth.Items.Add(line);
            }
        }

        private string parseIssuesByMonth(string line)
        {
            const int YEAR_START = 10;
            const int YEAR_LENGTH = 4;
            const int MONTH_START = 14;
            const int SKIP_BLANKS_AFTER_COLON = 2;
            const int ADJUST_TO_GET_COUNT_LENGTH = 3;
            string output = "";
            string year = line.Substring(YEAR_START, YEAR_LENGTH);
            string month = line.Substring(MONTH_START, (line.IndexOf(":")) - MONTH_START);
            string count = line.Substring(line.IndexOf(":") + SKIP_BLANKS_AFTER_COLON,
                                          line.Length - (line.IndexOf(":") + ADJUST_TO_GET_COUNT_LENGTH));
            output = year + " - " + month + ": " + count;
            return output;
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
