namespace MunicipalServices
{
    partial class FeedbackForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPOne = new System.Windows.Forms.CheckBox();
            this.cbxPTwo = new System.Windows.Forms.CheckBox();
            this.cbxPThree = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbServiceReview = new System.Windows.Forms.RichTextBox();
            this.rtbAppReview = new System.Windows.Forms.RichTextBox();
            this.cbxAOne = new System.Windows.Forms.CheckBox();
            this.cbxATwo = new System.Windows.Forms.CheckBox();
            this.cbxAThree = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label2, 3);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(3, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(570, 39);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tell us more about your experience:";
            // 
            // cbxPOne
            // 
            this.cbxPOne.AutoSize = true;
            this.cbxPOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPOne.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbxPOne.Location = new System.Drawing.Point(20, 43);
            this.cbxPOne.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cbxPOne.Name = "cbxPOne";
            this.cbxPOne.Size = new System.Drawing.Size(352, 85);
            this.cbxPOne.TabIndex = 30;
            this.cbxPOne.Text = "1 Star";
            this.cbxPOne.UseVisualStyleBackColor = true;
            // 
            // cbxPTwo
            // 
            this.cbxPTwo.AutoSize = true;
            this.cbxPTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPTwo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbxPTwo.Location = new System.Drawing.Point(378, 43);
            this.cbxPTwo.Name = "cbxPTwo";
            this.cbxPTwo.Size = new System.Drawing.Size(406, 85);
            this.cbxPTwo.TabIndex = 31;
            this.cbxPTwo.Text = "2 Stars";
            this.cbxPTwo.UseVisualStyleBackColor = true;
            // 
            // cbxPThree
            // 
            this.cbxPThree.AutoSize = true;
            this.cbxPThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPThree.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbxPThree.Location = new System.Drawing.Point(790, 43);
            this.cbxPThree.Name = "cbxPThree";
            this.cbxPThree.Size = new System.Drawing.Size(408, 85);
            this.cbxPThree.TabIndex = 32;
            this.cbxPThree.Text = "3 Stars";
            this.cbxPThree.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label3, 3);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(762, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rate your experience with with service delivery:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubmit.IconColor = System.Drawing.Color.Black;
            this.btnSubmit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubmit.Location = new System.Drawing.Point(375, 442);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(412, 75);
            this.btnSubmit.TabIndex = 35;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.27126F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.36437F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.36437F));
            this.tableLayoutPanel2.Controls.Add(this.rtbServiceReview, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbxPOne, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbxPTwo, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbxPThree, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSubmit, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(200, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1201, 517);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // rtbServiceReview
            // 
            this.rtbServiceReview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.rtbServiceReview, 3);
            this.rtbServiceReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbServiceReview.Font = new System.Drawing.Font("Century Gothic", 22.125F);
            this.rtbServiceReview.Location = new System.Drawing.Point(3, 188);
            this.rtbServiceReview.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.rtbServiceReview.Name = "rtbServiceReview";
            this.rtbServiceReview.Size = new System.Drawing.Size(1195, 232);
            this.rtbServiceReview.TabIndex = 34;
            this.rtbServiceReview.Text = "";
            // 
            // rtbAppReview
            // 
            this.rtbAppReview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.rtbAppReview, 3);
            this.rtbAppReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbAppReview.Font = new System.Drawing.Font("Century Gothic", 22.125F);
            this.rtbAppReview.Location = new System.Drawing.Point(3, 195);
            this.rtbAppReview.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.rtbAppReview.Name = "rtbAppReview";
            this.rtbAppReview.Size = new System.Drawing.Size(1195, 250);
            this.rtbAppReview.TabIndex = 29;
            this.rtbAppReview.Text = "";
            // 
            // cbxAOne
            // 
            this.cbxAOne.AutoSize = true;
            this.cbxAOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxAOne.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbxAOne.Location = new System.Drawing.Point(20, 43);
            this.cbxAOne.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.cbxAOne.Name = "cbxAOne";
            this.cbxAOne.Size = new System.Drawing.Size(377, 92);
            this.cbxAOne.TabIndex = 20;
            this.cbxAOne.Text = "1 Star";
            this.cbxAOne.UseVisualStyleBackColor = true;
            // 
            // cbxATwo
            // 
            this.cbxATwo.AutoSize = true;
            this.cbxATwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxATwo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbxATwo.Location = new System.Drawing.Point(403, 43);
            this.cbxATwo.Name = "cbxATwo";
            this.cbxATwo.Size = new System.Drawing.Size(394, 92);
            this.cbxATwo.TabIndex = 21;
            this.cbxATwo.Text = "2 Stars";
            this.cbxATwo.UseVisualStyleBackColor = true;
            // 
            // cbxAThree
            // 
            this.cbxAThree.AutoSize = true;
            this.cbxAThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbxAThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxAThree.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbxAThree.Location = new System.Drawing.Point(803, 43);
            this.cbxAThree.Name = "cbxAThree";
            this.cbxAThree.Size = new System.Drawing.Size(395, 92);
            this.cbxAThree.TabIndex = 22;
            this.cbxAThree.Text = "3 Stars";
            this.cbxAThree.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rate your experience with the app:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.rtbAppReview, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbxAOne, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxATwo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxAThree, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(200, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 253F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1201, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 3);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(3, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(828, 39);
            this.label4.TabIndex = 28;
            this.label4.Text = "What could we do to improve the app experience?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 511);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(200, 30, 200, 30);
            this.panel2.Size = new System.Drawing.Size(1601, 577);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(200, 60, 200, 0);
            this.panel1.Size = new System.Drawing.Size(1601, 505);
            this.panel1.TabIndex = 2;
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1601, 1088);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(678, 706);
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox rtbServiceReview;
        private System.Windows.Forms.CheckBox cbxPOne;
        private System.Windows.Forms.CheckBox cbxPTwo;
        private System.Windows.Forms.CheckBox cbxPThree;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnSubmit;
        private System.Windows.Forms.RichTextBox rtbAppReview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbxAOne;
        private System.Windows.Forms.CheckBox cbxATwo;
        private System.Windows.Forms.CheckBox cbxAThree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}