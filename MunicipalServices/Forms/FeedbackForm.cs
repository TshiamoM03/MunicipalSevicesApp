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
    public partial class FeedbackForm : Form
    {
        private static Review userReview = new Review();
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string appReview = "", serviceReview = "";
            if (rtbAppReview.Text != null) appReview = rtbAppReview.Text;
            if (rtbServiceReview.Text != null) serviceReview = rtbServiceReview.Text;

            SaveReview(getAppRating(), getPerformanceRating(), appReview, serviceReview);

            MessageBox.Show($"Review Submitted Successfully\n--------------------------\n{userReview.toString()}");
            Console.WriteLine($"Review submitted: \n{userReview.toString()}");
            clearForm();
        }

        private int getPerformanceRating()
        {
            if (cbxPOne.Checked)
            {
                return 1;
            }
            if (cbxPTwo.Checked)
            {
                return 2;
            }
            if (cbxPThree.Checked)
            {
                return 3;
            }
            return 0;
        }

        private int getAppRating()
        {
            if (cbxAOne.Checked)
            {
                return 1;
            }
            if (cbxATwo.Checked)
            {
                return 2;
            }
            if (cbxAThree.Checked)
            {
                return 3;
            }
            return 0;
        }

        private void SaveReview(int appRating, int perfRating, string appReview, string serviceReview)
        {
            userReview.AppRating = appRating;
            userReview.ServiceRating = getPerformanceRating();
            userReview.AppReview = appReview;
            userReview.ServiceReview = serviceReview;
        }
       
        private void clearForm()
        {
            rtbAppReview.Clear();
            rtbServiceReview.Clear();
            cbxPOne.Checked = false;
            cbxPTwo.Checked = false;
            cbxPThree.Checked = false;
            cbxAOne.Checked = false;
            cbxATwo.Checked = false;
            cbxAThree.Checked = false;
        }
    }
}

