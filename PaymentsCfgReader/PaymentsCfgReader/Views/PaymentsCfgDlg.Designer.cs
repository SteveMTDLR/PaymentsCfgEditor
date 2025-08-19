namespace PaymentCFG
{
    partial class PaymentsCfgDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentsCfgDlg));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStripRichText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonShowModified = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxFilter = new System.Windows.Forms.ToolStripTextBox();
            this.tsDropDownOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsAccountName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMid = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCustomerId = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAccountId = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUserName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.tssecretKey = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonClearFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewAccounts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStripRichText.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListMain
            // 
            this.imageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMain.ImageStream")));
            this.imageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMain.Images.SetKeyName(0, "form.scale-100.png");
            this.imageListMain.Images.SetKeyName(1, "editpage.png");
            // 
            // contextMenuStripRichText
            // 
            this.contextMenuStripRichText.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStripRichText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStripRichText.Name = "contextMenuStripRichText";
            this.contextMenuStripRichText.Size = new System.Drawing.Size(235, 38);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.copyToolStripMenuItem.Text = "Copy Contents to Clipboard";
            // 
            // toolStripMain
            // 
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripSeparator1,
            this.toolStripButtonReload,
            this.toolStripSeparator2,
            this.toolStripButtonShowModified,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.tsFilter,
            this.toolStripTextBoxFilter,
            this.tsDropDownOptions,
            this.toolStripSeparator6,
            this.toolStripButtonClearFilter});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMain.Size = new System.Drawing.Size(867, 27);
            this.toolStripMain.TabIndex = 2;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Enabled = false;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(55, 24);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonReload
            // 
            this.toolStripButtonReload.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReload.Image")));
            this.toolStripButtonReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReload.Name = "toolStripButtonReload";
            this.toolStripButtonReload.Size = new System.Drawing.Size(88, 24);
            this.toolStripButtonReload.Text = "Reload File";
            this.toolStripButtonReload.ToolTipText = "Reload File";
            this.toolStripButtonReload.Click += new System.EventHandler(this.toolStripButtonReloadFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonShowModified
            // 
            this.toolStripButtonShowModified.Enabled = false;
            this.toolStripButtonShowModified.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowModified.Image")));
            this.toolStripButtonShowModified.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowModified.Name = "toolStripButtonShowModified";
            this.toolStripButtonShowModified.Size = new System.Drawing.Size(111, 24);
            this.toolStripButtonShowModified.Text = "Show Modified";
            this.toolStripButtonShowModified.Click += new System.EventHandler(this.toolStripButtonShowModified_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tsFilter
            // 
            this.tsFilter.Image = ((System.Drawing.Image)(resources.GetObject("tsFilter.Image")));
            this.tsFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFilter.Name = "tsFilter";
            this.tsFilter.Size = new System.Drawing.Size(57, 24);
            this.tsFilter.Text = "Filter";
            this.tsFilter.Click += new System.EventHandler(this.toolStripButtonFilter_Click);
            // 
            // toolStripTextBoxFilter
            // 
            this.toolStripTextBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxFilter.Name = "toolStripTextBoxFilter";
            this.toolStripTextBoxFilter.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBoxFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxFilter_KeyDown);
            // 
            // tsDropDownOptions
            // 
            this.tsDropDownOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDropDownOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAccountName,
            this.tsMid,
            this.tsCustomerId,
            this.tsAccountId,
            this.tsUserName,
            this.tsPwd,
            this.tssecretKey});
            this.tsDropDownOptions.Image = ((System.Drawing.Image)(resources.GetObject("tsDropDownOptions.Image")));
            this.tsDropDownOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDropDownOptions.Name = "tsDropDownOptions";
            this.tsDropDownOptions.Size = new System.Drawing.Size(91, 24);
            this.tsDropDownOptions.Text = "Filter Options";
            this.tsDropDownOptions.Click += new System.EventHandler(this.tsDropDownOptions_Click);
            // 
            // tsAccountName
            // 
            this.tsAccountName.Checked = true;
            this.tsAccountName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsAccountName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsAccountName.Name = "tsAccountName";
            this.tsAccountName.Size = new System.Drawing.Size(237, 22);
            this.tsAccountName.Tag = "accountName";
            this.tsAccountName.Text = "AccountName (accountName)";
            // 
            // tsMid
            // 
            this.tsMid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMid.Name = "tsMid";
            this.tsMid.Size = new System.Drawing.Size(237, 22);
            this.tsMid.Tag = "mid";
            this.tsMid.Text = "Merchent ID (mid)";
            // 
            // tsCustomerId
            // 
            this.tsCustomerId.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsCustomerId.Name = "tsCustomerId";
            this.tsCustomerId.Size = new System.Drawing.Size(237, 22);
            this.tsCustomerId.Tag = "customerId";
            this.tsCustomerId.Text = "Customer Id (customerId)";
            // 
            // tsAccountId
            // 
            this.tsAccountId.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsAccountId.Name = "tsAccountId";
            this.tsAccountId.Size = new System.Drawing.Size(237, 22);
            this.tsAccountId.Tag = "accountId";
            this.tsAccountId.Text = "Account Id (accountId)";
            // 
            // tsUserName
            // 
            this.tsUserName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsUserName.Name = "tsUserName";
            this.tsUserName.Size = new System.Drawing.Size(237, 22);
            this.tsUserName.Tag = "userName";
            this.tsUserName.Text = "User Name (userName)";
            // 
            // tsPwd
            // 
            this.tsPwd.Name = "tsPwd";
            this.tsPwd.Size = new System.Drawing.Size(237, 22);
            this.tsPwd.Tag = "pwd";
            this.tsPwd.Text = "Password (pwd)";
            // 
            // tssecretKey
            // 
            this.tssecretKey.Name = "tssecretKey";
            this.tssecretKey.Size = new System.Drawing.Size(237, 22);
            this.tssecretKey.Tag = "secretKey";
            this.tssecretKey.Text = "Secret Key (secretKey)";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonClearFilter
            // 
            this.toolStripButtonClearFilter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearFilter.Image")));
            this.toolStripButtonClearFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClearFilter.Name = "toolStripButtonClearFilter";
            this.toolStripButtonClearFilter.Size = new System.Drawing.Size(87, 24);
            this.toolStripButtonClearFilter.Text = "Clear Filter";
            this.toolStripButtonClearFilter.Click += new System.EventHandler(this.toolStripButtonClearFilter_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Location = new System.Drawing.Point(0, 473);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(867, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopy,
            this.toolStripMenuItemDelete});
            this.contextMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(116, 64);
            // 
            // toolStripMenuItemCopy
            // 
            this.toolStripMenuItemCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopy.Image")));
            this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            this.toolStripMenuItemCopy.Size = new System.Drawing.Size(115, 30);
            this.toolStripMenuItemCopy.Text = "Copy";
            this.toolStripMenuItemCopy.Click += new System.EventHandler(this.toolStripMenuItemCopy_Click);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemDelete.Image")));
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(115, 30);
            this.toolStripMenuItemDelete.Text = "Delete";
            this.toolStripMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuItemDelete_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(867, 446);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewAccounts);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(218, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accounts";
            // 
            // listViewAccounts
            // 
            this.listViewAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAccounts.GridLines = true;
            this.listViewAccounts.HideSelection = false;
            this.listViewAccounts.LargeImageList = this.imageListMain;
            this.listViewAccounts.Location = new System.Drawing.Point(2, 24);
            this.listViewAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.listViewAccounts.MultiSelect = false;
            this.listViewAccounts.Name = "listViewAccounts";
            this.listViewAccounts.Size = new System.Drawing.Size(214, 420);
            this.listViewAccounts.SmallImageList = this.imageListMain;
            this.listViewAccounts.StateImageList = this.imageListMain;
            this.listViewAccounts.TabIndex = 0;
            this.listViewAccounts.UseCompatibleStateImageBehavior = false;
            this.listViewAccounts.View = System.Windows.Forms.View.Details;
            this.listViewAccounts.Click += new System.EventHandler(this.listViewAccounts_Click);
            this.listViewAccounts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewAccounts_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Applications";
            this.columnHeader1.Width = 376;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewMain);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(647, 446);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.AllowUserToResizeRows = false;
            this.dataGridViewMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnValue});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMain.Location = new System.Drawing.Point(2, 24);
            this.dataGridViewMain.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMain.MultiSelect = false;
            this.dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.RowHeadersWidth = 72;
            this.dataGridViewMain.RowTemplate.Height = 31;
            this.dataGridViewMain.Size = new System.Drawing.Size(643, 420);
            this.dataGridViewMain.TabIndex = 0;
            this.dataGridViewMain.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellEndEdit);
            this.dataGridViewMain.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellValueChanged);
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MaxInputLength = 150;
            this.ColumnName.MinimumWidth = 9;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnValue
            // 
            this.ColumnValue.HeaderText = "Value";
            this.ColumnValue.MaxInputLength = 1500;
            this.ColumnValue.MinimumWidth = 9;
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.Width = 500;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // PaymentsCfgDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 495);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(543, 129);
            this.Name = "PaymentsCfgDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DependencyDlg_FormClosing);
            this.Load += new System.EventHandler(this.DependencyDlg_Load);
            this.Shown += new System.EventHandler(this.DependencyDlg_Shown);
            this.contextMenuStripRichText.ResumeLayout(false);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsFilter;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRichText;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListView listViewAccounts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowModified;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton tsDropDownOptions;
        private System.Windows.Forms.ToolStripMenuItem tsAccountName;
        private System.Windows.Forms.ToolStripMenuItem tsMid;
        private System.Windows.Forms.ToolStripMenuItem tsCustomerId;
        private System.Windows.Forms.ToolStripMenuItem tsAccountId;
        private System.Windows.Forms.ToolStripMenuItem tsUserName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonClearFilter;
        private System.Windows.Forms.ToolStripMenuItem tsPwd;
        private System.Windows.Forms.ToolStripMenuItem tssecretKey;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}

