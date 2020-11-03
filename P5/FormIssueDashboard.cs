using System;
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
            
        }

        

    }
}
