namespace MunicipalServices
{
    partial class EventsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApplyFilter = new FontAwesome.Sharp.IconButton();
            this.lblSearchItems = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClearFilter = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvRecommendations = new System.Windows.Forms.DataGridView();
            this.RTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvUpcomingEvents = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecommendations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(43, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search and Filter";
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackColor = System.Drawing.Color.CadetBlue;
            this.btnApplyFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilter.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnApplyFilter.IconColor = System.Drawing.Color.White;
            this.btnApplyFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnApplyFilter.Location = new System.Drawing.Point(0, 0);
            this.btnApplyFilter.MaximumSize = new System.Drawing.Size(450, 75);
            this.btnApplyFilter.MinimumSize = new System.Drawing.Size(250, 75);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnApplyFilter.Size = new System.Drawing.Size(432, 75);
            this.btnApplyFilter.TabIndex = 22;
            this.btnApplyFilter.Text = "   Apply";
            this.btnApplyFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            this.btnApplyFilter.UseWaitCursor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // lblSearchItems
            // 
            this.lblSearchItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearchItems.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblSearchItems, 2);
            this.lblSearchItems.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblSearchItems.Location = new System.Drawing.Point(43, 601);
            this.lblSearchItems.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.lblSearchItems.Name = "lblSearchItems";
            this.lblSearchItems.Size = new System.Drawing.Size(0, 160);
            this.lblSearchItems.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(43, 497);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 101);
            this.label3.TabIndex = 19;
            this.label3.Text = "To";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CalendarFont = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpToDate.CalendarTitleBackColor = System.Drawing.Color.CadetBlue;
            this.dtpToDate.CalendarTrailingForeColor = System.Drawing.Color.LightGray;
            this.dtpToDate.Checked = false;
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Century Gothic", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(132, 497);
            this.dtpToDate.MaximumSize = new System.Drawing.Size(390, 47);
            this.dtpToDate.MinimumSize = new System.Drawing.Size(250, 47);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(339, 47);
            this.dtpToDate.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(43, 425);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 66);
            this.label6.TabIndex = 16;
            this.label6.Text = "From";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CalendarFont = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpFromDate.CalendarTitleBackColor = System.Drawing.Color.CadetBlue;
            this.dtpFromDate.CalendarTrailingForeColor = System.Drawing.Color.LightGray;
            this.dtpFromDate.Checked = false;
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Font = new System.Drawing.Font("Century Gothic", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(132, 425);
            this.dtpFromDate.MaximumSize = new System.Drawing.Size(390, 47);
            this.dtpFromDate.MinimumSize = new System.Drawing.Size(250, 47);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(339, 47);
            this.dtpFromDate.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(43, 350);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 69);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select Date Range";
            // 
            // cbxCategories
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbxCategories, 2);
            this.cbxCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxCategories.DropDownHeight = 250;
            this.cbxCategories.Font = new System.Drawing.Font("Century Gothic", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.IntegralHeight = false;
            this.cbxCategories.ItemHeight = 72;
            this.cbxCategories.Location = new System.Drawing.Point(43, 193);
            this.cbxCategories.MaximumSize = new System.Drawing.Size(450, 0);
            this.cbxCategories.MaxLength = 110;
            this.cbxCategories.MinimumSize = new System.Drawing.Size(250, 0);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(432, 80);
            this.cbxCategories.TabIndex = 14;
            this.cbxCategories.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label5, 2);
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(43, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(432, 39);
            this.label5.TabIndex = 13;
            this.label5.Text = "Select Category";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnClearFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClearFilter.IconColor = System.Drawing.Color.Black;
            this.btnClearFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearFilter.Location = new System.Drawing.Point(0, 148);
            this.btnClearFilter.MaximumSize = new System.Drawing.Size(450, 75);
            this.btnClearFilter.MinimumSize = new System.Drawing.Size(250, 75);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(432, 75);
            this.btnClearFilter.TabIndex = 23;
            this.btnClearFilter.Text = "Clear";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.31964F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.68036F));
            this.tableLayoutPanel1.Controls.Add(this.lblSearchItems, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtpToDate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpFromDate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxCategories, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(40, 60, 0, 60);
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 1088);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.btnApplyFilter);
            this.panel1.Controls.Add(this.btnClearFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(43, 802);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 223);
            this.panel1.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgvRecommendations, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.dgvUpcomingEvents, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(478, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(40, 60, 40, 60);
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 335F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1123, 1088);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // dgvRecommendations
            // 
            this.dgvRecommendations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecommendations.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecommendations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecommendations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecommendations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecommendations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RTitle,
            this.RDate,
            this.RCategory,
            this.RDescription});
            this.tableLayoutPanel2.SetColumnSpan(this.dgvRecommendations, 2);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecommendations.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecommendations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecommendations.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvRecommendations.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvRecommendations.Location = new System.Drawing.Point(43, 696);
            this.dgvRecommendations.MinimumSize = new System.Drawing.Size(279, 39);
            this.dgvRecommendations.MultiSelect = false;
            this.dgvRecommendations.Name = "dgvRecommendations";
            this.dgvRecommendations.ReadOnly = true;
            this.dgvRecommendations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecommendations.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecommendations.RowHeadersVisible = false;
            this.dgvRecommendations.RowHeadersWidth = 82;
            this.dgvRecommendations.RowTemplate.Height = 33;
            this.dgvRecommendations.Size = new System.Drawing.Size(1037, 329);
            this.dgvRecommendations.TabIndex = 29;
            // 
            // RTitle
            // 
            this.RTitle.FillWeight = 99.60938F;
            this.RTitle.HeaderText = "Event Name";
            this.RTitle.MinimumWidth = 10;
            this.RTitle.Name = "RTitle";
            this.RTitle.ReadOnly = true;
            // 
            // RDate
            // 
            this.RDate.FillWeight = 60.43349F;
            this.RDate.HeaderText = "Date";
            this.RDate.MinimumWidth = 10;
            this.RDate.Name = "RDate";
            this.RDate.ReadOnly = true;
            // 
            // RCategory
            // 
            this.RCategory.FillWeight = 109.1248F;
            this.RCategory.HeaderText = "Category";
            this.RCategory.MinimumWidth = 10;
            this.RCategory.Name = "RCategory";
            this.RCategory.ReadOnly = true;
            // 
            // RDescription
            // 
            this.RDescription.FillWeight = 130.8323F;
            this.RDescription.HeaderText = "Description";
            this.RDescription.MinimumWidth = 10;
            this.RDescription.Name = "RDescription";
            this.RDescription.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.Location = new System.Drawing.Point(43, 629);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(390, 39);
            this.label8.TabIndex = 28;
            this.label8.Text = "Recommended for you:";
            // 
            // dgvUpcomingEvents
            // 
            this.dgvUpcomingEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUpcomingEvents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUpcomingEvents.BackgroundColor = System.Drawing.Color.White;
            this.dgvUpcomingEvents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUpcomingEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUpcomingEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcomingEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Date,
            this.Category,
            this.Description});
            this.tableLayoutPanel2.SetColumnSpan(this.dgvUpcomingEvents, 2);
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUpcomingEvents.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUpcomingEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUpcomingEvents.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvUpcomingEvents.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvUpcomingEvents.Location = new System.Drawing.Point(43, 113);
            this.dgvUpcomingEvents.MinimumSize = new System.Drawing.Size(279, 57);
            this.dgvUpcomingEvents.MultiSelect = false;
            this.dgvUpcomingEvents.Name = "dgvUpcomingEvents";
            this.dgvUpcomingEvents.ReadOnly = true;
            this.dgvUpcomingEvents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUpcomingEvents.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUpcomingEvents.RowHeadersVisible = false;
            this.dgvUpcomingEvents.RowHeadersWidth = 82;
            this.dgvUpcomingEvents.RowTemplate.Height = 33;
            this.dgvUpcomingEvents.Size = new System.Drawing.Size(1037, 510);
            this.dgvUpcomingEvents.TabIndex = 27;
            // 
            // Title
            // 
            this.Title.FillWeight = 99.60938F;
            this.Title.HeaderText = "Event Name";
            this.Title.MinimumWidth = 10;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.FillWeight = 60.43349F;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 10;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.FillWeight = 109.1248F;
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 10;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.FillWeight = 130.8323F;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 10;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(43, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(298, 47);
            this.label7.TabIndex = 26;
            this.label7.Text = "Upcoming Events:";
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1601, 1088);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(678, 706);
            this.Name = "EventsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events and Announcements";
            this.Load += new System.EventHandler(this.EventsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecommendations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnApplyFilter;
        private System.Windows.Forms.Label lblSearchItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnClearFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvRecommendations;
        private System.Windows.Forms.DataGridViewTextBoxColumn RTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn RDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn RDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvUpcomingEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Label label7;
    }
}