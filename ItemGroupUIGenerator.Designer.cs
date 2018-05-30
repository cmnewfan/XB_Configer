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
            this.tableLayoutPanelCenter = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.metroContextMenuTable = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddSingle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddBool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddControl = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.metroContextMenuItem = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditSingle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditBool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditControl = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.metroComboBoxGroups = new MetroFramework.Controls.MetroComboBox();
            this.metroPanelButtons = new MetroFramework.Controls.MetroPanel();
            this.toolStripButtons = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.metroPanelAll = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanelTree.SuspendLayout();
            this.metroPanelMain.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelCenter.SuspendLayout();
            this.metroContextMenuTable.SuspendLayout();
            this.metroContextMenuItem.SuspendLayout();
            this.metroPanelButtons.SuspendLayout();
            this.toolStripButtons.SuspendLayout();
            this.metroPanelAll.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelTree
            // 
            this.metroPanelTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.win7StyleTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.win7StyleTreeView.Size = new System.Drawing.Size(153, 480);
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
            // tableLayoutPanelCenter
            // 
            this.tableLayoutPanelCenter.ColumnCount = 1;
            this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCenter.Controls.Add(this.tableLayoutPanelContent, 0, 0);
            this.tableLayoutPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCenter.Location = new System.Drawing.Point(46, 33);
            this.tableLayoutPanelCenter.Name = "tableLayoutPanelCenter";
            this.tableLayoutPanelCenter.RowCount = 3;
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCenter.Size = new System.Drawing.Size(446, 314);
            this.tableLayoutPanelCenter.TabIndex = 0;
            // 
            // tableLayoutPanelContent
            // 
            this.tableLayoutPanelContent.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanelContent.ColumnCount = 3;
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanelContent.ContextMenuStrip = this.metroContextMenuTable;
            this.tableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContent.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            this.tableLayoutPanelContent.RowCount = 1;
            this.tableLayoutPanelCenter.SetRowSpan(this.tableLayoutPanelContent, 3);
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanelContent.Size = new System.Drawing.Size(440, 308);
            this.tableLayoutPanelContent.TabIndex = 1;
            this.tableLayoutPanelContent.DragDrop += new System.Windows.Forms.DragEventHandler(this.tableLayoutPanelContent_DragDrop);
            this.tableLayoutPanelContent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanelContent_MouseClick);
            // 
            // metroContextMenuTable
            // 
            this.metroContextMenuTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdd,
            this.toolStripSeparator2});
            this.metroContextMenuTable.Name = "metroContextMenuTable";
            this.metroContextMenuTable.Size = new System.Drawing.Size(101, 32);
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddSingle,
            this.toolStripMenuItemAddBool,
            this.toolStripMenuItemAddControl});
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItemAdd.Text = "增加";
            this.toolStripMenuItemAdd.ToolTipText = "增加";
            // 
            // toolStripMenuItemAddSingle
            // 
            this.toolStripMenuItemAddSingle.Name = "toolStripMenuItemAddSingle";
            this.toolStripMenuItemAddSingle.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemAddSingle.Text = "模拟量";
            // 
            // toolStripMenuItemAddBool
            // 
            this.toolStripMenuItemAddBool.Name = "toolStripMenuItemAddBool";
            this.toolStripMenuItemAddBool.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemAddBool.Text = "布尔量";
            // 
            // toolStripMenuItemAddControl
            // 
            this.toolStripMenuItemAddControl.Name = "toolStripMenuItemAddControl";
            this.toolStripMenuItemAddControl.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemAddControl.Text = "控制量";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(97, 6);
            // 
            // metroContextMenuItem
            // 
            this.metroContextMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEdit,
            this.toolStripSeparator3,
            this.toolStripMenuItemDel,
            this.toolStripSeparator4});
            this.metroContextMenuItem.Name = "metroContextMenuContent";
            this.metroContextMenuItem.Size = new System.Drawing.Size(101, 60);
            this.metroContextMenuItem.VisibleChanged += new System.EventHandler(this.metroContextMenuContent_VisibleChanged);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditSingle,
            this.toolStripMenuItemEditBool,
            this.toolStripMenuItemEditControl});
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItemEdit.Text = "替换";
            this.toolStripMenuItemEdit.ToolTipText = "替换";
            // 
            // toolStripMenuItemEditSingle
            // 
            this.toolStripMenuItemEditSingle.Name = "toolStripMenuItemEditSingle";
            this.toolStripMenuItemEditSingle.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemEditSingle.Text = "模拟量";
            // 
            // toolStripMenuItemEditBool
            // 
            this.toolStripMenuItemEditBool.Name = "toolStripMenuItemEditBool";
            this.toolStripMenuItemEditBool.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemEditBool.Text = "布尔量";
            // 
            // toolStripMenuItemEditControl
            // 
            this.toolStripMenuItemEditControl.Name = "toolStripMenuItemEditControl";
            this.toolStripMenuItemEditControl.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemEditControl.Text = "控制量";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(97, 6);
            // 
            // toolStripMenuItemDel
            // 
            this.toolStripMenuItemDel.Name = "toolStripMenuItemDel";
            this.toolStripMenuItemDel.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItemDel.Text = "删除";
            this.toolStripMenuItemDel.ToolTipText = "删除";
            this.toolStripMenuItemDel.Click += new System.EventHandler(this.toolStripMenuItemDel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(97, 6);
            // 
            // metroComboBoxGroups
            // 
            this.metroComboBoxGroups.BackColor = System.Drawing.SystemColors.Window;
            this.metroComboBoxGroups.FormattingEnabled = true;
            this.metroComboBoxGroups.ItemHeight = 23;
            this.metroComboBoxGroups.Items.AddRange(new object[] {
            "5MW箱变通用",
            "5MW箱变V柜_C1柜_C2柜",
            "5MW箱变V柜_C1柜",
            "5MW箱变V柜",
            "5MW箱变控制"});
            this.metroComboBoxGroups.Location = new System.Drawing.Point(202, 18);
            this.metroComboBoxGroups.Name = "metroComboBoxGroups";
            this.metroComboBoxGroups.PromptText = "选择分组";
            this.metroComboBoxGroups.Size = new System.Drawing.Size(135, 29);
            this.metroComboBoxGroups.TabIndex = 3;
            this.metroComboBoxGroups.UseSelectable = true;
            this.metroComboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxGroups_SelectedIndexChanged);
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
            this.toolStripButtons.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripButtons_ItemClicked);
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
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroComboBoxGroups);
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
            this.metroContextMenuTable.ResumeLayout(false);
            this.metroContextMenuItem.ResumeLayout(false);
            this.metroPanelButtons.ResumeLayout(false);
            this.metroPanelButtons.PerformLayout();
            this.toolStripButtons.ResumeLayout(false);
            this.toolStripButtons.PerformLayout();
            this.metroPanelAll.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelTree;
        private Kesoft.Windows.Forms.Win7StyleTreeView.Win7StyleTreeView win7StyleTreeView;
        private MetroFramework.Controls.MetroPanel metroPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private MetroFramework.Controls.MetroComboBox metroComboBoxGroups;
        private MetroFramework.Controls.MetroPanel metroPanelButtons;
        private System.Windows.Forms.ToolStrip toolStripButtons;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private MetroFramework.Controls.MetroPanel metroPanelAll;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCenter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContent;
        private MetroFramework.Controls.MetroContextMenu metroContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddSingle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddBool;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddControl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditSingle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditBool;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditControl;
        private MetroFramework.Controls.MetroContextMenu metroContextMenuTable;

    }
}