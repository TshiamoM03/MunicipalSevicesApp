namespace MunicipalServices
{
    partial class ReportIssueForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pbReport = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReady = new System.Windows.Forms.Label();
            this.txbLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpload = new FontAwesome.Sharp.IconButton();
            this.btnSubmit = new FontAwesome.Sharp.IconButton();
            this.lblFileName = new System.Windows.Forms.Label();
            this.pnlFooter.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.pbReport);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 1011);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1601, 77);
            this.pnlFooter.TabIndex = 0;
            // 
            // pbReport
            // 
            this.pbReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pbReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbReport.ForeColor = System.Drawing.Color.CadetBlue;
            this.pbReport.Location = new System.Drawing.Point(0, 37);
            this.pbReport.Maximum = 3;
            this.pbReport.Name = "pbReport";
            this.pbReport.Size = new System.Drawing.Size(1601, 40);
            this.pbReport.Step = 1;
            this.pbReport.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 658F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblReady, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.txbLocation, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbxCategory, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txbDescription, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnUpload, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnSubmit, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblFileName, 0, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(140, 60, 140, 0);
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.098843F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.51104F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.309148F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.18927F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.6204F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.09253F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.781283F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1601, 1011);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(143, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location*";
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = true;
            this.lblReady.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReady.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReady.Location = new System.Drawing.Point(803, 935);
            this.lblReady.Margin = new System.Windows.Forms.Padding(0);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(658, 76);
            this.lblReady.TabIndex = 12;
            this.lblReady.Text = "...";
            this.lblReady.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbLocation
            // 
            this.txbLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.txbLocation, 2);
            this.txbLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbLocation.Font = new System.Drawing.Font("Century Gothic", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLocation.Location = new System.Drawing.Point(143, 125);
            this.txbLocation.MinimumSize = new System.Drawing.Size(422, 50);
            this.txbLocation.Name = "txbLocation";
            this.txbLocation.Size = new System.Drawing.Size(1315, 80);
            this.txbLocation.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(143, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category*";
            // 
            // cbxCategory
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbxCategory, 2);
            this.cbxCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCategory.Font = new System.Drawing.Font("Century Gothic", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.IntegralHeight = false;
            this.cbxCategory.ItemHeight = 72;
            this.cbxCategory.Location = new System.Drawing.Point(143, 332);
            this.cbxCategory.MinimumSize = new System.Drawing.Size(422, 0);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(1315, 80);
            this.cbxCategory.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label3, 2);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(143, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description*";
            // 
            // txbDescription
            // 
            this.txbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.txbDescription, 2);
            this.txbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbDescription.Font = new System.Drawing.Font("Century Gothic", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescription.Location = new System.Drawing.Point(143, 530);
            this.txbDescription.MinimumSize = new System.Drawing.Size(422, 4);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(1315, 186);
            this.txbDescription.TabIndex = 6;
            this.txbDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(143, 781);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1315, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Upload a File (optional):";
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpload.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnUpload.IconColor = System.Drawing.Color.White;
            this.btnUpload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpload.Location = new System.Drawing.Point(143, 857);
            this.btnUpload.MaximumSize = new System.Drawing.Size(350, 75);
            this.btnUpload.MinimumSize = new System.Drawing.Size(330, 75);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(330, 75);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "Upload";
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubmit.IconColor = System.Drawing.Color.Black;
            this.btnSubmit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubmit.Location = new System.Drawing.Point(1128, 857);
            this.btnSubmit.MaximumSize = new System.Drawing.Size(350, 75);
            this.btnSubmit.MinimumSize = new System.Drawing.Size(330, 75);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(330, 75);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFileName.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFileName.Location = new System.Drawing.Point(143, 935);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(657, 76);
            this.lblFileName.TabIndex = 12;
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReportIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1601, 1088);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.pnlFooter);
            this.MinimumSize = new System.Drawing.Size(678, 706);
            this.Name = "ReportIssueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report an Issue";
            this.pnlFooter.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.ProgressBar pbReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txbDescription;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnUpload;
        private System.Windows.Forms.Label lblReady;
        private FontAwesome.Sharp.IconButton btnSubmit;
        private System.Windows.Forms.Label lblFileName;
    }
}