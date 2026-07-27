using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServices.Forms
{
    public partial class StatusForm : Form
    {
        public StatusForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void StatusForm_Load(object sender, EventArgs e)
        {
            SetupForm();
            IssueDataStore.LoadSampleIssues();
            PopulateHeapGridView();
            PopulateTreeGridView();
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = txbSearch.Text.ToString();
            if (int.TryParse(input, out int id))
            {
                var issue = IssueDataStore.FindIssueById(id);
                if (issue == null)
                {
                    MessageBox.Show("Service Request Not Found");
                }
                else
                {
                    searchResult(dgvHeapIssues, issue);
                    searchResult(dgvTreeIssues, issue);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID number");
                PopulateHeapGridView();
                PopulateTreeGridView();
            }
        }

        /*------------- UI helper methods -------------*/
        private void SetupForm()
        {
            dgvHeapIssues.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvHeapIssues.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHeapIssues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHeapIssues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTreeIssues.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvTreeIssues.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTreeIssues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTreeIssues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PopulateHeapGridView() //👍
        {
            dgvHeapIssues.Rows.Clear();
            var sortedIssues = IssueDataStore.IssueHeap.GetPrioritisedIssues();
            foreach (var issue in sortedIssues)
            {
                dgvHeapIssues.Rows.Add(issue.DisplayID,
                    issue.ReportDate.ToShortDateString(), issue.Category, issue.Location, issue.Status,
                    issue.Description, issue.PriorityLevel);
            }

            ReadjustDgv(dgvHeapIssues);
        }

        private void PopulateTreeGridView()
        {
            dgvTreeIssues.Rows.Clear();
            var issueList = IssueDataStore.GetAllIssues();
            foreach (var issue in issueList)
            {
                dgvTreeIssues.Rows.Add(issue.DisplayID,
                    issue.ReportDate.ToShortDateString(), issue.Category, issue.Location, issue.Status,
                    issue.Description, issue.MediaFile, issue.PriorityLevel, issue.Priority);
            }

            ReadjustDgv(dgvTreeIssues);
        }


        private void ReadjustDgv(DataGridView dgv)
        {
            dgv.AutoResizeRows();
            dgv.AutoResizeColumns();
        }

        private void searchResult(DataGridView dgv, Issue issue)
        {
            dgv.Rows.Clear();

            dgv.Rows.Add(issue.DisplayID,
                issue.ReportDate.ToShortDateString(), issue.Category, issue.Location, issue.Status,
                issue.Description, issue.MediaFile, issue.PriorityLevel);
        }
    }
}
