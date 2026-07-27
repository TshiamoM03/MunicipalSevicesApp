namespace MunicipalServices.Forms
{
    partial class StatusForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TabControl tabControlIssues;
            this.issueDataStoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPageAllReq = new System.Windows.Forms.TabPage();
            this.dgvTreeIssues = new System.Windows.Forms.DataGridView();
            this.PriorityLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHeapIssues = new System.Windows.Forms.DataGridView();
            this.tbPageActive = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tabControlIssues = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.issueDataStoreBindingSource)).BeginInit();
            this.tbPageAllReq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreeIssues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeapIssues)).BeginInit();
            this.tbPageActive.SuspendLayout();
            tabControlIssues.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.Location = new System.Drawing.Point(1286, 63);
            this.btnSearch.MaximumSize = new System.Drawing.Size(450, 60);
            this.btnSearch.MinimumSize = new System.Drawing.Size(250, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(272, 54);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.UseWaitCursor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(43, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Find your request:";
            // 
            // txbSearch
            // 
            this.txbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txbSearch.Font = new System.Drawing.Font("Century Gothic", 22F);
            this.txbSearch.Location = new System.Drawing.Point(920, 63);
            this.txbSearch.Multiline = true;
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(360, 54);
            this.txbSearch.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Score";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Priority";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Media";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Status";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Location";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Category";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.125F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(920, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 33);
            this.label1.TabIndex = 24;
            this.label1.Text = "Enter the request numer";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tbPageAllReq
            // 
            this.tbPageAllReq.BackColor = System.Drawing.Color.Transparent;
            this.tbPageAllReq.Controls.Add(this.dgvTreeIssues);
            this.tbPageAllReq.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.tbPageAllReq.Location = new System.Drawing.Point(8, 58);
            this.tbPageAllReq.Name = "tbPageAllReq";
            this.tbPageAllReq.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageAllReq.Size = new System.Drawing.Size(1499, 786);
            this.tbPageAllReq.TabIndex = 1;
            this.tbPageAllReq.Text = "All Requests";
            // 
            // dgvTreeIssues
            // 
            this.dgvTreeIssues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTreeIssues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTreeIssues.BackgroundColor = System.Drawing.Color.White;
            this.dgvTreeIssues.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTreeIssues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvTreeIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreeIssues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTreeIssues.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvTreeIssues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTreeIssues.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(230)))));
            this.dgvTreeIssues.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvTreeIssues.Location = new System.Drawing.Point(3, 3);
            this.dgvTreeIssues.MinimumSize = new System.Drawing.Size(279, 57);
            this.dgvTreeIssues.MultiSelect = false;
            this.dgvTreeIssues.Name = "dgvTreeIssues";
            this.dgvTreeIssues.ReadOnly = true;
            this.dgvTreeIssues.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTreeIssues.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvTreeIssues.RowHeadersVisible = false;
            this.dgvTreeIssues.RowHeadersWidth = 82;
            this.dgvTreeIssues.RowTemplate.Height = 33;
            this.dgvTreeIssues.Size = new System.Drawing.Size(1493, 780);
            this.dgvTreeIssues.TabIndex = 29;
            // 
            // PriorityLevel
            // 
            this.PriorityLevel.HeaderText = "Priority";
            this.PriorityLevel.MinimumWidth = 10;
            this.PriorityLevel.Name = "PriorityLevel";
            this.PriorityLevel.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 10;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 10;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 10;
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 10;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // ReportDate
            // 
            this.ReportDate.HeaderText = "Date";
            this.ReportDate.MinimumWidth = 10;
            this.ReportDate.Name = "ReportDate";
            this.ReportDate.ReadOnly = true;
            // 
            // DisplayID
            // 
            this.DisplayID.HeaderText = "ID";
            this.DisplayID.MinimumWidth = 10;
            this.DisplayID.Name = "DisplayID";
            this.DisplayID.ReadOnly = true;
            // 
            // dgvHeapIssues
            // 
            this.dgvHeapIssues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHeapIssues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHeapIssues.BackgroundColor = System.Drawing.Color.White;
            this.dgvHeapIssues.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHeapIssues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvHeapIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeapIssues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DisplayID,
            this.ReportDate,
            this.Category,
            this.Location,
            this.Status,
            this.Description,
            this.PriorityLevel});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHeapIssues.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvHeapIssues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHeapIssues.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(230)))));
            this.dgvHeapIssues.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvHeapIssues.Location = new System.Drawing.Point(3, 3);
            this.dgvHeapIssues.MinimumSize = new System.Drawing.Size(279, 57);
            this.dgvHeapIssues.MultiSelect = false;
            this.dgvHeapIssues.Name = "dgvHeapIssues";
            this.dgvHeapIssues.ReadOnly = true;
            this.dgvHeapIssues.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHeapIssues.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvHeapIssues.RowHeadersVisible = false;
            this.dgvHeapIssues.RowHeadersWidth = 82;
            this.dgvHeapIssues.RowTemplate.Height = 33;
            this.dgvHeapIssues.Size = new System.Drawing.Size(1493, 780);
            this.dgvHeapIssues.TabIndex = 28;
            // 
            // tbPageActive
            // 
            this.tbPageActive.BackColor = System.Drawing.Color.Transparent;
            this.tbPageActive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbPageActive.Controls.Add(this.dgvHeapIssues);
            this.tbPageActive.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.tbPageActive.Location = new System.Drawing.Point(8, 58);
            this.tbPageActive.Name = "tbPageActive";
            this.tbPageActive.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageActive.Size = new System.Drawing.Size(1499, 786);
            this.tbPageActive.TabIndex = 0;
            this.tbPageActive.Text = "Active Requests";
            // 
            // tabControlIssues
            // 
            this.tableLayoutPanel1.SetColumnSpan(tabControlIssues, 3);
            tabControlIssues.Controls.Add(this.tbPageActive);
            tabControlIssues.Controls.Add(this.tbPageAllReq);
            tabControlIssues.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControlIssues.Font = new System.Drawing.Font("Century Gothic", 12F);
            tabControlIssues.HotTrack = true;
            tabControlIssues.ItemSize = new System.Drawing.Size(600, 50);
            tabControlIssues.Location = new System.Drawing.Point(43, 173);
            tabControlIssues.Name = "tabControlIssues";
            tabControlIssues.Padding = new System.Drawing.Point(10, 5);
            tabControlIssues.SelectedIndex = 0;
            tabControlIssues.Size = new System.Drawing.Size(1515, 852);
            tabControlIssues.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            tabControlIssues.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.52209F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.47791F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 277F));
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(tabControlIssues, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(40, 60, 40, 60);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 851F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1601, 1088);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 1088);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StatusForm";
            this.Text = "StatusForm";
            this.Load += new System.EventHandler(this.StatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.issueDataStoreBindingSource)).EndInit();
            this.tbPageAllReq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreeIssues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeapIssues)).EndInit();
            this.tbPageActive.ResumeLayout(false);
            tabControlIssues.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource issueDataStoreBindingSource;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tbPageAllReq;
        private System.Windows.Forms.DataGridView dgvTreeIssues;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriorityLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayID;
        private System.Windows.Forms.DataGridView dgvHeapIssues;
        private System.Windows.Forms.TabPage tbPageActive;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}