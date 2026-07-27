namespace MunicipalServices
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFormContainer = new System.Windows.Forms.Panel();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.btnFeedback = new FontAwesome.Sharp.IconButton();
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.btnStatus = new FontAwesome.Sharp.IconButton();
            this.btnEvents = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pnlNavImg = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnMinimise = new FontAwesome.Sharp.IconButton();
            this.btnMaximise = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.icnCurrentForm = new FontAwesome.Sharp.IconPictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlNavBar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icnCurrentForm)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pnlFormContainer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlNavBar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlHeader, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2002, 1279);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pnlFormContainer
            // 
            this.pnlFormContainer.AutoSize = true;
            this.pnlFormContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.pnlFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormContainer.Location = new System.Drawing.Point(375, 120);
            this.pnlFormContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFormContainer.MinimumSize = new System.Drawing.Size(1027, 559);
            this.pnlFormContainer.Name = "pnlFormContainer";
            this.pnlFormContainer.Size = new System.Drawing.Size(1627, 1159);
            this.pnlFormContainer.TabIndex = 4;
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.pnlNavBar.Controls.Add(this.btnFeedback);
            this.pnlNavBar.Controls.Add(this.btnHelp);
            this.pnlNavBar.Controls.Add(this.btnStatus);
            this.pnlNavBar.Controls.Add(this.btnEvents);
            this.pnlNavBar.Controls.Add(this.btnReport);
            this.pnlNavBar.Controls.Add(this.btnHome);
            this.pnlNavBar.Controls.Add(this.pnlNavImg);
            this.pnlNavBar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNavBar.Name = "pnlNavBar";
            this.tableLayoutPanel1.SetRowSpan(this.pnlNavBar, 2);
            this.pnlNavBar.Size = new System.Drawing.Size(375, 1279);
            this.pnlNavBar.TabIndex = 3;
            // 
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.Color.Transparent;
            this.btnFeedback.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFeedback.FlatAppearance.BorderSize = 0;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.Color.White;
            this.btnFeedback.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.btnFeedback.IconColor = System.Drawing.Color.White;
            this.btnFeedback.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedback.Location = new System.Drawing.Point(0, 1039);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnFeedback.Size = new System.Drawing.Size(375, 120);
            this.btnFeedback.TabIndex = 10;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnHelp.IconColor = System.Drawing.Color.White;
            this.btnHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 1159);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnHelp.Size = new System.Drawing.Size(375, 120);
            this.btnHelp.TabIndex = 9;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.Transparent;
            this.btnStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnStatus.IconColor = System.Drawing.Color.White;
            this.btnStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatus.Location = new System.Drawing.Point(0, 480);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnStatus.Size = new System.Drawing.Size(375, 120);
            this.btnStatus.TabIndex = 8;
            this.btnStatus.Text = "Service Request Status";
            this.btnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.BackColor = System.Drawing.Color.Transparent;
            this.btnEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEvents.FlatAppearance.BorderSize = 0;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.Color.White;
            this.btnEvents.IconChar = FontAwesome.Sharp.IconChar.Bullhorn;
            this.btnEvents.IconColor = System.Drawing.Color.White;
            this.btnEvents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.Location = new System.Drawing.Point(0, 360);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnEvents.Size = new System.Drawing.Size(375, 120);
            this.btnEvents.TabIndex = 7;
            this.btnEvents.Text = "Events and Announcements";
            this.btnEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvents.UseVisualStyleBackColor = false;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.btnReport.IconColor = System.Drawing.Color.White;
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 240);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnReport.Size = new System.Drawing.Size(375, 120);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Report Issue";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 120);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnHome.Size = new System.Drawing.Size(375, 120);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlNavImg
            // 
            this.pnlNavImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlNavImg.BackgroundImage")));
            this.pnlNavImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlNavImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavImg.Location = new System.Drawing.Point(0, 0);
            this.pnlNavImg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pnlNavImg.Name = "pnlNavImg";
            this.pnlNavImg.Padding = new System.Windows.Forms.Padding(10);
            this.pnlNavImg.Size = new System.Drawing.Size(375, 120);
            this.pnlNavImg.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.pnlHeader.Controls.Add(this.btnMinimise);
            this.pnlHeader.Controls.Add(this.btnMaximise);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.icnCurrentForm);
            this.pnlHeader.Location = new System.Drawing.Point(375, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1627, 120);
            this.pnlHeader.TabIndex = 2;
            // 
            // btnMinimise
            // 
            this.btnMinimise.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimise.FlatAppearance.BorderSize = 0;
            this.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimise.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnMinimise.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimise.IconColor = System.Drawing.Color.White;
            this.btnMinimise.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimise.IconSize = 30;
            this.btnMinimise.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimise.Location = new System.Drawing.Point(1351, 10);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnMinimise.Size = new System.Drawing.Size(80, 45);
            this.btnMinimise.TabIndex = 5;
            this.btnMinimise.UseVisualStyleBackColor = true;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // btnMaximise
            // 
            this.btnMaximise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximise.FlatAppearance.BorderSize = 0;
            this.btnMaximise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximise.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximise.IconColor = System.Drawing.Color.White;
            this.btnMaximise.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximise.IconSize = 30;
            this.btnMaximise.Location = new System.Drawing.Point(1453, 10);
            this.btnMaximise.Name = "btnMaximise";
            this.btnMaximise.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnMaximise.Size = new System.Drawing.Size(80, 45);
            this.btnMaximise.TabIndex = 4;
            this.btnMaximise.UseVisualStyleBackColor = true;
            this.btnMaximise.Click += new System.EventHandler(this.btnMaximise_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(1539, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(80, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(121, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 42);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Home";
            // 
            // icnCurrentForm
            // 
            this.icnCurrentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.icnCurrentForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.icnCurrentForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.icnCurrentForm.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.icnCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnCurrentForm.IconSize = 55;
            this.icnCurrentForm.Location = new System.Drawing.Point(40, 33);
            this.icnCurrentForm.Name = "icnCurrentForm";
            this.icnCurrentForm.Size = new System.Drawing.Size(55, 55);
            this.icnCurrentForm.TabIndex = 1;
            this.icnCurrentForm.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2002, 1279);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1009, 782);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlNavBar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icnCurrentForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlNavBar;
        private FontAwesome.Sharp.IconButton btnFeedback;
        private FontAwesome.Sharp.IconButton btnHelp;
        private FontAwesome.Sharp.IconButton btnStatus;
        private FontAwesome.Sharp.IconButton btnEvents;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel pnlNavImg;
        private System.Windows.Forms.Panel pnlHeader;
        private FontAwesome.Sharp.IconButton btnMinimise;
        private FontAwesome.Sharp.IconButton btnMaximise;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconPictureBox icnCurrentForm;
        private System.Windows.Forms.Panel pnlFormContainer;
    }
}