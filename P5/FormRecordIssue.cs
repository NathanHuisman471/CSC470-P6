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
            this.CenterToScreen();
        }
    }
}
