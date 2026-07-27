using FontAwesome.Sharp;
using MunicipalServices.Forms;
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
    public partial class MainForm : Form
    {
        private IconButton currentButton;
        private Panel leftBorderButton;
        private Form currentChildForm;
        public MainForm()
        {
            InitializeComponent();
            IssueDataStore.LoadSampleIssues();
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(10, 120);
            pnlNavBar.Controls.Add(leftBorderButton);
            OpenChildForm(new Home());
        }

        private void OpenChildForm(Form child)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnlFormContainer.Controls.Add(child);
            pnlFormContainer.Tag = child;
            child.Show();
            lblTitle.Text = child.Text;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(240, 230, 210));
            OpenChildForm(new Home());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(153, 204, 230));
            OpenChildForm(new ReportIssueForm());
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(240, 230, 210));
            OpenChildForm(new EventsForm());
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(153, 204, 230));
            OpenChildForm(new StatusForm());
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(240, 230, 210));
            OpenChildForm(new FeedbackForm());
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(153, 204, 230));
            OpenChildForm(new HelpForm());
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void btnMaximise_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ActivateButton(object sender, Color colour)
        {
            if(sender != null)
            {
                DisableButton();

                currentButton = (IconButton)sender;
                currentButton.BackColor = Color.FromArgb(0, 51, 102);
                currentButton.ForeColor = colour;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = colour;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                //left border 
                leftBorderButton.BackColor = colour;
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();

                //icon of current form
                icnCurrentForm.IconChar = currentButton.IconChar;
                icnCurrentForm.IconColor = colour;
            }
        }//endActivateButton

        public void DisableButton()
        {
            if (currentButton != null) 
            {
                currentButton.BackColor = Color.FromArgb(0, 51, 102);
                currentButton.ForeColor = Color.White;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.White;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }//endDisableButton

        private void Reset()
        {
            DisableButton();
            leftBorderButton.Visible = false;
            icnCurrentForm.IconChar = IconChar.HomeLg;
            icnCurrentForm.IconColor = Color.CadetBlue;
            lblTitle.Text = "Home";
        }
    }
}
