namespace XB_Configer
{
    partial class ItemGroupUIGenerator
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("模拟量");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("布尔量");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("控制量");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemGroupUIGenerator));
            this.metroPanelTree = new MetroFramework.Controls.MetroPanel();
            this.win7StyleTreeView = new Kesoft.Windows.Forms.Win7StyleTreeView.Win7StyleTreeView(this.components);
            this.metroPanelMain = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.metroComboBoxGroups = new MetroFramework.Controls.MetroComboBox();
            this.tableLayoutPanelCenter = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.labelGroupTitle = new System.Windows.Forms.Label();
            this.metroPanelButtons = new MetroFramework.Controls.MetroPanel();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.metroPanelAll = new MetroFramework.Controls.MetroPanel();
            this.toolStripButtons = new System.Windows.Forms.ToolStrip();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.metroPanelTree.SuspendLayout();
            this.metroPanelMain.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelCenter.SuspendLayout();
            this.metroPanelButtons.SuspendLayout();
            this.metroPanelAll.SuspendLayout();
            this.toolStripButtons.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelTree
            // 
            this.metroPanelTree.Controls.Add(this.win7StyleTreeView);
            this.metroPanelTree.HorizontalScrollbarBarColor = true;
            this.metroPanelTree.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelTree.HorizontalScrollbarSize = 10;
            this.metroPanelTree.Location = new System.Drawing.Point(0, 0);
            this.metroPanelTree.Name = "metroPanelTree";
            this.metroPanelTree.Size = new System.Drawing.Size(155, 482);
            this.metroPanelTree.TabIndex = 2;
            this.metroPanelTree.VerticalScrollbarBarColor = true;
            this.metroPanelTree.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelTree.VerticalScrollbarSize = 10;
            // 
            // win7StyleTreeView
            // 
            this.win7StyleTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.win7StyleTreeView.HotTracking = true;
            this.win7StyleTreeView.Location = new System.Drawing.Point(0, 0);
            this.win7StyleTreeView.Name = "win7StyleTreeView";
            treeNode1.Name = "节点0";
            treeNode1.Text = "模拟量";
            treeNode1.ToolTipText = "模拟量";
            treeNode2.Name = "节点1";
            treeNode2.Text = "布尔量";
            treeNode2.ToolTipText = "布尔量";
            treeNode3.Name = "节点0";
            treeNode3.Text = "控制量";
            treeNode3.ToolTipText = "控制量";
            this.win7StyleTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.win7StyleTreeView.ShowLines = false;
            this.win7StyleTreeView.Size = new System.Drawing.Size(155, 482);
            this.win7StyleTreeView.TabIndex = 2;
            // 
            // metroPanelMain
            // 
            this.metroPanelMain.Controls.Add(this.tableLayoutPanelMain);
            this.metroPanelMain.HorizontalScrollbarBarColor = true;
            this.metroPanelMain.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelMain.HorizontalScrollbarSize = 10;
            this.metroPanelMain.Location = new System.Drawing.Point(154, 64);
            this.metroPanelMain.Name = "metroPanelMain";
            this.metroPanelMain.Size = new System.Drawing.Size(539, 382);
            this.metroPanelMain.TabIndex = 4;
            this.metroPanelMain.VerticalScrollbarBarColor = true;
            this.metroPanelMain.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelMain.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelCenter, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.metroComboBoxGroups, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(539, 382);
            this.tableLayoutPanelMain.TabIndex = 2;
            // 
            // metroComboBoxGroups
            // 
            this.metroComboBoxGroups.BackColor = System.Drawing.SystemColors.Window;
            this.metroComboBoxGroups.FormattingEnabled = true;
            this.metroComboBoxGroups.ItemHeight = 23;
            this.metroComboBoxGroups.Items.AddRange(new object[] {
            "5MW箱变V柜",
            "5MW箱变C1柜",
            "5MW箱变C2柜"});
            this.metroComboBoxGroups.Location = new System.Drawing.Point(46, 3);
            this.metroComboBoxGroups.Name = "metroComboBoxGroups";
            this.metroComboBoxGroups.PromptText = "选择分组";
            this.metroComboBoxGroups.Size = new System.Drawing.Size(95, 29);
            this.metroComboBoxGroups.TabIndex = 3;
            this.metroComboBoxGroups.UseSelectable = true;
            // 
            // tableLayoutPanelCenter
            // 
            this.tableLayoutPanelCenter.ColumnCount = 1;
            this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCenter.Controls.Add(this.labelGroupTitle, 0, 0);
            this.tableLayoutPanelCenter.Controls.Add(this.tableLayoutPanelContent, 0, 1);
            this.tableLayoutPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCenter.Location = new System.Drawing.Point(46, 33);
            this.tableLayoutPanelCenter.Name = "tableLayoutPanelCenter";
            this.tableLayoutPanelCenter.RowCount = 2;
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanelCenter.Size = new System.Drawing.Size(446, 314);
            this.tableLayoutPanelCenter.TabIndex = 0;
            // 
            // tableLayoutPanelContent
            // 
            this.tableLayoutPanelContent.ColumnCount = 3;
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContent.Location = new System.Drawing.Point(3, 40);
            this.tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            this.tableLayoutPanelContent.RowCount = 1;
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanelContent.Size = new System.Drawing.Size(440, 271);
            this.tableLayoutPanelContent.TabIndex = 1;
            // 
            // labelGroupTitle
            // 
            this.labelGroupTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.labelGroupTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGroupTitle.Location = new System.Drawing.Point(3, 0);
            this.labelGroupTitle.Name = "labelGroupTitle";
            this.labelGroupTitle.Size = new System.Drawing.Size(440, 37);
            this.labelGroupTitle.TabIndex = 0;
            this.labelGroupTitle.Text = "GroupTitle";
            this.labelGroupTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroPanelButtons
            // 
            this.metroPanelButtons.Controls.Add(this.toolStripButtons);
            this.metroPanelButtons.HorizontalScrollbarBarColor = true;
            this.metroPanelButtons.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelButtons.HorizontalScrollbarSize = 10;
            this.metroPanelButtons.Location = new System.Drawing.Point(154, 446);
            this.metroPanelButtons.Name = "metroPanelButtons";
            this.metroPanelButtons.Size = new System.Drawing.Size(539, 36);
            this.metroPanelButtons.TabIndex = 5;
            this.metroPanelButtons.VerticalScrollbarBarColor = true;
            this.metroPanelButtons.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelButtons.VerticalScrollbarSize = 10;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.miniToolStrip.Size = new System.Drawing.Size(539, 36);
            this.miniToolStrip.TabIndex = 2;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExit.Image")));
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(36, 33);
            this.toolStripButtonExit.Text = "退出";
            // 
            // metroPanelAll
            // 
            this.metroPanelAll.Controls.Add(this.metroPanel1);
            this.metroPanelAll.Controls.Add(this.metroPanelButtons);
            this.metroPanelAll.Controls.Add(this.metroPanelMain);
            this.metroPanelAll.Controls.Add(this.metroPanelTree);
            this.metroPanelAll.HorizontalScrollbarBarColor = true;
            this.metroPanelAll.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAll.HorizontalScrollbarSize = 10;
            this.metroPanelAll.Location = new System.Drawing.Point(0, -1);
            this.metroPanelAll.Name = "metroPanelAll";
            this.metroPanelAll.Size = new System.Drawing.Size(693, 482);
            this.metroPanelAll.TabIndex = 0;
            this.metroPanelAll.VerticalScrollbarBarColor = true;
            this.metroPanelAll.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAll.VerticalScrollbarSize = 10;
            // 
            // toolStripButtons
            // 
            this.toolStripButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButtonExit});
            this.toolStripButtons.Location = new System.Drawing.Point(0, 0);
            this.toolStripButtons.Name = "toolStripButtons";
            this.toolStripButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButtons.Size = new System.Drawing.Size(539, 36);
            this.toolStripButtons.TabIndex = 2;
            this.toolStripButtons.Text = "toolStrip1";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTabControl1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(154, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(539, 65);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Controls.Add(this.tabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(539, 65);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(531, 23);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "界面1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(531, 23);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "界面2";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(531, 23);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "界面3";
            // 
            // ItemGroupUIGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 483);
            this.Controls.Add(this.metroPanelAll);
            this.Name = "ItemGroupUIGenerator";
            this.metroPanelTree.ResumeLayout(false);
            this.metroPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelCenter.ResumeLayout(false);
            this.metroPanelButtons.ResumeLayout(false);
            this.metroPanelButtons.PerformLayout();
            this.metroPanelAll.ResumeLayout(false);
            this.toolStripButtons.ResumeLayout(false);
            this.toolStripButtons.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelTree;
        private Kesoft.Windows.Forms.Win7StyleTreeView.Win7StyleTreeView win7StyleTreeView;
        private MetroFramework.Controls.MetroPanel metroPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCenter;
        private System.Windows.Forms.Label labelGroupTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContent;
        private MetroFramework.Controls.MetroComboBox metroComboBoxGroups;
        private MetroFramework.Controls.MetroPanel metroPanelButtons;
        private System.Windows.Forms.ToolStrip toolStripButtons;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private MetroFramework.Controls.MetroPanel metroPanelAll;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;

    }
}