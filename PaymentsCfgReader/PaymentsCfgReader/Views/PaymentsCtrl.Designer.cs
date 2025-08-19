namespace DependencyScan.Views
{
    partial class PaymentsCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentsCtrl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainerTop = new System.Windows.Forms.SplitContainer();
            this.groupBoxAcc = new System.Windows.Forms.GroupBox();
            this.listViewMain = new System.Windows.Forms.ListView();
            this.imageListTop = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxText = new System.Windows.Forms.GroupBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripdependencies = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemShowReferences = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripRichText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).BeginInit();
            this.splitContainerTop.Panel1.SuspendLayout();
            this.splitContainerTop.Panel2.SuspendLayout();
            this.splitContainerTop.SuspendLayout();
            this.groupBoxAcc.SuspendLayout();
            this.groupBoxText.SuspendLayout();
            this.contextMenuStripdependencies.SuspendLayout();
            this.contextMenuStripRichText.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainerTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 809);
            this.panel1.TabIndex = 0;
            // 
            // splitContainerTop
            // 
            this.splitContainerTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.splitContainerTop.Name = "splitContainerTop";
            // 
            // splitContainerTop.Panel1
            // 
            this.splitContainerTop.Panel1.Controls.Add(this.groupBoxAcc);
            // 
            // splitContainerTop.Panel2
            // 
            this.splitContainerTop.Panel2.Controls.Add(this.groupBoxText);
            this.splitContainerTop.Size = new System.Drawing.Size(1129, 809);
            this.splitContainerTop.SplitterDistance = 408;
            this.splitContainerTop.SplitterWidth = 7;
            this.splitContainerTop.TabIndex = 1;
            // 
            // groupBoxAcc
            // 
            this.groupBoxAcc.Controls.Add(this.listViewMain);
            this.groupBoxAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAcc.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAcc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxAcc.Name = "groupBoxAcc";
            this.groupBoxAcc.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxAcc.Size = new System.Drawing.Size(408, 809);
            this.groupBoxAcc.TabIndex = 2;
            this.groupBoxAcc.TabStop = false;
            this.groupBoxAcc.Text = "Accounts";
            // 
            // listViewMain
            // 
            this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName});
            this.listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMain.FullRowSelect = true;
            this.listViewMain.GridLines = true;
            this.listViewMain.HideSelection = false;
            this.listViewMain.Location = new System.Drawing.Point(6, 28);
            this.listViewMain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listViewMain.MultiSelect = false;
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(396, 775);
            this.listViewMain.TabIndex = 0;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            this.listViewMain.SelectedIndexChanged += new System.EventHandler(this.listViewMain_SelectedIndexChanged);
            // 
            // imageListTop
            // 
            this.imageListTop.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTop.ImageStream")));
            this.imageListTop.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTop.Images.SetKeyName(0, "Warn");
            this.imageListTop.Images.SetKeyName(1, "Ok");
            // 
            // groupBoxText
            // 
            this.groupBoxText.Controls.Add(this.richTextBox);
            this.groupBoxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxText.Location = new System.Drawing.Point(0, 0);
            this.groupBoxText.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxText.Name = "groupBoxText";
            this.groupBoxText.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxText.Size = new System.Drawing.Size(714, 809);
            this.groupBoxText.TabIndex = 1;
            this.groupBoxText.TabStop = false;
            this.groupBoxText.Text = "Current selection";
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(6, 28);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(702, 775);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox_LinkClicked);
            // 
            // contextMenuStripdependencies
            // 
            this.contextMenuStripdependencies.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStripdependencies.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShowReferences});
            this.contextMenuStripdependencies.Name = "contextMenuStripRichText";
            this.contextMenuStripdependencies.Size = new System.Drawing.Size(256, 40);
            // 
            // toolStripMenuItemShowReferences
            // 
            this.toolStripMenuItemShowReferences.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemShowReferences.Image")));
            this.toolStripMenuItemShowReferences.Name = "toolStripMenuItemShowReferences";
            this.toolStripMenuItemShowReferences.Size = new System.Drawing.Size(255, 36);
            this.toolStripMenuItemShowReferences.Text = "Show References";
            this.toolStripMenuItemShowReferences.Click += new System.EventHandler(this.toolStripMenuItemShowReferences_Click);
            // 
            // contextMenuStripRichText
            // 
            this.contextMenuStripRichText.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStripRichText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStripRichText.Name = "contextMenuStripRichText";
            this.contextMenuStripRichText.Size = new System.Drawing.Size(355, 40);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(354, 36);
            this.copyToolStripMenuItem.Text = "Copy Contents to Clipboard";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // colName
            // 
            this.colName.Text = "Account Name";
            this.colName.Width = 367;
            // 
            // PaymentsCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PaymentsCtrl";
            this.Size = new System.Drawing.Size(1129, 809);
            this.panel1.ResumeLayout(false);
            this.splitContainerTop.Panel1.ResumeLayout(false);
            this.splitContainerTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).EndInit();
            this.splitContainerTop.ResumeLayout(false);
            this.groupBoxAcc.ResumeLayout(false);
            this.groupBoxText.ResumeLayout(false);
            this.contextMenuStripdependencies.ResumeLayout(false);
            this.contextMenuStripRichText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.SplitContainer splitContainerTop;
        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.GroupBox groupBoxText;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ImageList imageListTop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRichText;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripdependencies;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowReferences;
        private System.Windows.Forms.GroupBox groupBoxAcc;
        private System.Windows.Forms.ColumnHeader colName;
    }
}
