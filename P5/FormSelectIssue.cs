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
    public partial class FormSelectIssue : Form
    {
        AppUser _CurrentAppUser;
        int _SelectedProjectId;
        int previousPage;
        FakeIssueRepository _IssueRepository = new FakeIssueRepository();
        public FormSelectIssue(AppUser appUser, int choice)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
            previousPage = choice;
        }

        private void FormSelectIssue_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            foreach (Issue issue in _IssueRepository.GetAll(_SelectedProjectId))
            {
                dataGridView1.Rows.Add(new object[] { issue.Id.ToString(), issue.Title.ToString(), issue.DiscoveryDate.ToString(), issue.Discoverer.ToString(), issue.InitialDescription.ToString(), issue.Component.ToString(), issue.IssueStatusId.ToString() });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            if (previousPage == 1)
            {
                this.Hide();
                FormModifyIssue form = new FormModifyIssue(_CurrentAppUser);
                form.ShowDialog();
                form.Dispose();
            }
            if (previousPage == 2)
            {
                this.Hide();
                DialogResult isSure = MessageBox.Show("Are you sure you want to remove: ", "Confirmation", MessageBoxButtons.YesNo);
                if( isSure == DialogResult.Yes)
                {
                    FakeIssueRepository repository = new FakeIssueRepository();

                    //The following code is the setup for removing the selected issue, Remove() requires an Issue so this currently does not function.
                /*    
                    bool result = repository.Remove();
                    if(result == true)
                    {
                        MessageBox.Show("Issue removed.", "Information");
                    }
                    else
                    {
                        MessageBox.Show("Error removing issue " + issue.Title, "Information");
                    }
                */
                    Close();
                }
                if( isSure == DialogResult.No)
                {
                    MessageBox.Show("Remove canceled", "Attention", MessageBoxButtons.OK);
                    Close();
                }
                
            }
        }
    }
}
