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
        public FormSelectIssue(AppUser appUser)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
        }

        private void FormSelectIssue_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormModifyIssue form = new FormModifyIssue(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }
    }
}
