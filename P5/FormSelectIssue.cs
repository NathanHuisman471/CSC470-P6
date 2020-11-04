using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5
{
    public partial class FormSelectIssue : Form
    {
        public int _SelectedIssueId = 0;
        AppUser _CurrentAppUser;
        int _SelectedProjectId;
        int previousPage;
        FakeIssueRepository _IssueRepository = new FakeIssueRepository();
        FakeIssueStatusRepository _StatusRepository = new FakeIssueStatusRepository();
        
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
                string issuestatus = _StatusRepository.GetValueById(issue.IssueStatusId);
                dataGridView1.Rows.Add(new object[] { issue.Id.ToString(), issue.Title.ToString(), issue.DiscoveryDate, issue.Discoverer.ToString(), issue.InitialDescription.ToString(), issue.Component.ToString(), issuestatus });
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows == null)
            {
                MessageBox.Show("A project must be selected.", "Attention");
            }
            else
            {
                string selectedId = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                _SelectedIssueId = Convert.ToInt32(selectedId);
            }

            if (previousPage == 1)
            {
                this.Hide();
                FormModifyIssue form = new FormModifyIssue(_SelectedIssueId);
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
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    string title = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                    DateTime date = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                    string discoverer = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                    string description = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                    string component = dataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
                    string status = dataGridView1.SelectedRows[0].Cells[6].Value + string.Empty;
                    int issuestatus = _StatusRepository.GetIdByStatus(status);
                    
                    Issue issue = new Issue { Id = id, Title = title, DiscoveryDate = date, Discoverer = discoverer, InitialDescription = description, Component = component, IssueStatusId = issuestatus };

                    //The following code is the setup for removing the selected issue, Remove() requires an Issue so this currently does not function.
                        
                        bool result = repository.Remove(issue);
                        if(result == true)
                        {
                            MessageBox.Show("Issue removed.", "Information");
                        }
                        else
                        {
                            MessageBox.Show("Error removing issue " + issue.Title, "Information");
                        }
                    
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
