using FontAwesome.Sharp;
using MunicipalServices.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServices
{
    public partial class ReportIssueForm : Form
    {       
        private static Issue issue;
        public ReportIssueForm()
        {
            InitializeComponent();
            PopulateComboBox();
            issue = new Issue();

            InputProgressTracking();
        }

        /*--------------- UI component execution ---------------*/
        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png|All Files|*.*";
            string selectedFileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFileName = openFileDialog1.SafeFileName;
                MessageBox.Show($"{selectedFileName} attached");
                lblFileName.Text = $"Attached: {selectedFileName}";
                issue.MediaFile = openFileDialog1.FileName; //saved to issue with file path                
            }
            else
            {
                MessageBox.Show($"Could not upload file");
                return;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            RecordIssue();
            ResetForm();
        }


        /*--------------- Functionality ---------------*/
        private void PopulateComboBox()
        {
            cbxCategory.DataSource = IssueDataStore.IssueCategories;
        }

        private void RecordIssue()
        {
            //set issue field values
            issue.Location = txbLocation.Text;
            issue.Category = cbxCategory.SelectedItem.ToString();
            issue.Description = txbDescription.Text;
            issue.ReportDate = DateTime.Today;
            issue.Status = "Pending";          

            //validation
            if (string.IsNullOrWhiteSpace(issue.Location) || string.IsNullOrWhiteSpace(issue.Category) || string.IsNullOrWhiteSpace(issue.Description))
            {
                MessageBox.Show("Please fill all required fields");
                return;
            }
            if (issue.MediaFile == null)
            {
                issue.MediaFile = "None";
            }
            //store new issue
            IssueDataStore.AddIssue(issue);

            //show summary of issue & success msg
            Console.WriteLine($"Issue Recorded: \n {issue.ToString()}");          
            MessageBox.Show($"Issue Submitted Successfully with ID: {issue.IssueId}\n---------------------\n{issue.Summary()}", "Success", MessageBoxButtons.OK);
        }

        private void UpdateProgressBar()
        {
            int progress = 0;
            int step = 1;

            if (!string.IsNullOrEmpty(txbLocation.Text))
            {
                progress += step;
            }
            if (cbxCategory.SelectedIndex > 0)
            {
                progress += step;
            }
            if (!string.IsNullOrEmpty(txbDescription.Text))
            {
                progress += step;
            }
            pbReport.Value = progress;
            if (progress == 3)
            {
                lblReady.Text = "Ready to submit or upload file";
            }
        }

        private void InputProgressTracking()
        {
            txbLocation.TextChanged += (sender, e) => UpdateProgressBar();
            cbxCategory.SelectedIndexChanged += (sender, e) => UpdateProgressBar();
            txbDescription.TextChanged += (sender, e) => UpdateProgressBar();
        }

        /*--------------- UI Helper methods ---------------*/
        private void ResetForm()
        {
            issue = new Issue();
            txbLocation.Clear();
            cbxCategory.SelectedIndex = 0;
            txbDescription.Clear();
            pbReport.Value = 0;
            lblFileName.Text = string.Empty;
            lblReady.Text = string.Empty;
        }
         
    }//end of form
}
