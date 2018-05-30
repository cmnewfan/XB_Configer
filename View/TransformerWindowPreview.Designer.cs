namespace XB_Configer.View
{
    partial class TransformerWindowPreview
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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("节点1");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("节点2");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("节点3");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("选择风机", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransformerWindowPreview));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanelAll = new MetroFramework.Controls.MetroPanel();
            this.panel_display_2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_display_2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_dis2_tips = new System.Windows.Forms.TableLayoutPanel();
            this.label_tips2_status_not_trigger = new System.Windows.Forms.Label();
            this.label_tips2_warning_not_trigger = new System.Windows.Forms.Label();
            this.label_tips2_status_trigger = new System.Windows.Forms.Label();
            this.label_tips2_warning_trigger = new System.Windows.Forms.Label();
            this.tableLayoutPanelRightGroup = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabelRightGroup = new MetroFramework.Controls.MetroLabel();
            this.panel_display_1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_display_1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_dis1_tips = new System.Windows.Forms.TableLayoutPanel();
            this.label_tips1_normal = new System.Windows.Forms.Label();
            this.label_tips1_not_start = new System.Windows.Forms.Label();
            this.label_tips1_warning = new System.Windows.Forms.Label();
            this.label_tips1_start = new System.Windows.Forms.Label();
            this.tableLayoutPanelLeftGroup = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabelLeftGroup = new MetroFramework.Controls.MetroLabel();
            this.panel_Control = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_control = new System.Windows.Forms.TableLayoutPanel();
            this.label_warning = new System.Windows.Forms.Label();
            this.tableLayoutPanel_XB_control = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_C2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_C1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_v = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_ui_name = new System.Windows.Forms.Label();
            this.win7StyleTreeViewTurbines = new Kesoft.Windows.Forms.Win7StyleTreeView.Win7StyleTreeView(this.components);
            this.tableLayoutPanelComboBoxes = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxGroupSelect1 = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxGroupSelect2 = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxGroupSelect3 = new MetroFramework.Controls.MetroComboBox();
            this.toolStripButtons = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanelMain.SuspendLayout();
            this.metroPanelAll.SuspendLayout();
            this.panel_display_2.SuspendLayout();
            this.tableLayoutPanel_display_2.SuspendLayout();
            this.tableLayoutPanel_dis2_tips.SuspendLayout();
            this.tableLayoutPanelRightGroup.SuspendLayout();
            this.panel_display_1.SuspendLayout();
            this.tableLayoutPanel_display_1.SuspendLayout();
            this.tableLayoutPanel_dis1_tips.SuspendLayout();
            this.tableLayoutPanelLeftGroup.SuspendLayout();
            this.panel_Control.SuspendLayout();
            this.tableLayoutPanel_control.SuspendLayout();
            this.tableLayoutPanel_XB_control.SuspendLayout();
            this.tableLayoutPanel_C2.SuspendLayout();
            this.tableLayoutPanel_C1.SuspendLayout();
            this.tableLayoutPanel_v.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelComboBoxes.SuspendLayout();
            this.toolStripButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanelMain.Controls.Add(this.metroPanelAll, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.win7StyleTreeViewTurbines, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelComboBoxes, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.toolStripButtons, 1, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1215, 740);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // metroPanelAll
            // 
            this.metroPanelAll.Controls.Add(this.panel_display_2);
            this.metroPanelAll.Controls.Add(this.panel_display_1);
            this.metroPanelAll.Controls.Add(this.panel_Control);
            this.metroPanelAll.Controls.Add(this.panel1);
            this.metroPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelAll.HorizontalScrollbarBarColor = true;
            this.metroPanelAll.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAll.HorizontalScrollbarSize = 10;
            this.metroPanelAll.Location = new System.Drawing.Point(88, 77);
            this.metroPanelAll.Name = "metroPanelAll";
            this.metroPanelAll.Size = new System.Drawing.Size(1124, 623);
            this.metroPanelAll.TabIndex = 3;
            this.metroPanelAll.VerticalScrollbarBarColor = true;
            this.metroPanelAll.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAll.VerticalScrollbarSize = 10;
            // 
            // panel_display_2
            // 
            this.panel_display_2.BackColor = System.Drawing.Color.White;
            this.panel_display_2.Controls.Add(this.tableLayoutPanel_display_2);
            this.panel_display_2.Location = new System.Drawing.Point(563, 32);
            this.panel_display_2.Name = "panel_display_2";
            this.panel_display_2.Size = new System.Drawing.Size(562, 488);
            this.panel_display_2.TabIndex = 7;
            // 
            // tableLayoutPanel_display_2
            // 
            this.tableLayoutPanel_display_2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_display_2.ColumnCount = 1;
            this.tableLayoutPanel_display_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_display_2.Controls.Add(this.tableLayoutPanel_dis2_tips, 0, 1);
            this.tableLayoutPanel_display_2.Controls.Add(this.tableLayoutPanelRightGroup, 0, 0);
            this.tableLayoutPanel_display_2.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel_display_2.Name = "tableLayoutPanel_display_2";
            this.tableLayoutPanel_display_2.RowCount = 2;
            this.tableLayoutPanel_display_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel_display_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_display_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_display_2.Size = new System.Drawing.Size(557, 482);
            this.tableLayoutPanel_display_2.TabIndex = 1;
            // 
            // tableLayoutPanel_dis2_tips
            // 
            this.tableLayoutPanel_dis2_tips.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_dis2_tips.ColumnCount = 2;
            this.tableLayoutPanel_dis2_tips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_dis2_tips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_dis2_tips.Controls.Add(this.label_tips2_status_not_trigger, 0, 0);
            this.tableLayoutPanel_dis2_tips.Controls.Add(this.label_tips2_warning_not_trigger, 1, 0);
            this.tableLayoutPanel_dis2_tips.Controls.Add(this.label_tips2_status_trigger, 0, 1);
            this.tableLayoutPanel_dis2_tips.Controls.Add(this.label_tips2_warning_trigger, 1, 1);
            this.tableLayoutPanel_dis2_tips.Location = new System.Drawing.Point(4, 436);
            this.tableLayoutPanel_dis2_tips.Name = "tableLayoutPanel_dis2_tips";
            this.tableLayoutPanel_dis2_tips.RowCount = 2;
            this.tableLayoutPanel_dis2_tips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel_dis2_tips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel_dis2_tips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_dis2_tips.Size = new System.Drawing.Size(549, 41);
            this.tableLayoutPanel_dis2_tips.TabIndex = 0;
            // 
            // label_tips2_status_not_trigger
            // 
            this.label_tips2_status_not_trigger.AutoSize = true;
            this.label_tips2_status_not_trigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tips2_status_not_trigger.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tips2_status_not_trigger.Image = global::XB_Configer.Properties.Resources.button_blue_alt;
            this.label_tips2_status_not_trigger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_tips2_status_not_trigger.Location = new System.Drawing.Point(4, 1);
            this.label_tips2_status_not_trigger.Name = "label_tips2_status_not_trigger";
            this.label_tips2_status_not_trigger.Size = new System.Drawing.Size(267, 20);
            this.label_tips2_status_not_trigger.TabIndex = 0;
            this.label_tips2_status_not_trigger.Text = "   :未触发";
            this.label_tips2_status_not_trigger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_tips2_warning_not_trigger
            // 
            this.label_tips2_warning_not_trigger.AutoSize = true;
            this.label_tips2_warning_not_trigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tips2_warning_not_trigger.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tips2_warning_not_trigger.Image = global::XB_Configer.Properties.Resources.button_blue_alt;
            this.label_tips2_warning_not_trigger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_tips2_warning_not_trigger.Location = new System.Drawing.Point(278, 1);
            this.label_tips2_warning_not_trigger.Name = "label_tips2_warning_not_trigger";
            this.label_tips2_warning_not_trigger.Size = new System.Drawing.Size(267, 20);
            this.label_tips2_warning_not_trigger.TabIndex = 1;
            this.label_tips2_warning_not_trigger.Text = "   :未触发";
            this.label_tips2_warning_not_trigger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_tips2_status_trigger
            // 
            this.label_tips2_status_trigger.AutoSize = true;
            this.label_tips2_status_trigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tips2_status_trigger.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tips2_status_trigger.Image = global::XB_Configer.Properties.Resources.button_green;
            this.label_tips2_status_trigger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_tips2_status_trigger.Location = new System.Drawing.Point(4, 22);
            this.label_tips2_status_trigger.Name = "label_tips2_status_trigger";
            this.label_tips2_status_trigger.Size = new System.Drawing.Size(267, 18);
            this.label_tips2_status_trigger.TabIndex = 2;
            this.label_tips2_status_trigger.Text = "   :触发";
            this.label_tips2_status_trigger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_tips2_warning_trigger
            // 
            this.label_tips2_warning_trigger.AutoSize = true;
            this.label_tips2_warning_trigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tips2_warning_trigger.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tips2_warning_trigger.Image = global::XB_Configer.Properties.Resources.button_red;
            this.label_tips2_warning_trigger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_tips2_warning_trigger.Location = new System.Drawing.Point(278, 22);
            this.label_tips2_warning_trigger.Name = "label_tips2_warning_trigger";
            this.label_tips2_warning_trigger.Size = new System.Drawing.Size(267, 18);
            this.label_tips2_warning_trigger.TabIndex = 3;
            this.label_tips2_warning_trigger.Text = "   :触发";
            this.label_tips2_warning_trigger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelRightGroup
            // 
            this.tableLayoutPanelRightGroup.ColumnCount = 3;
            this.tableLayoutPanelRightGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanelRightGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRightGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 269F));
            this.tableLayoutPanelRightGroup.Controls.Add(this.metroLabelRightGroup, 0, 0);
            this.tableLayoutPanelRightGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRightGroup.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanelRightGroup.Name = "tableLayoutPanelRightGroup";
            this.tableLayoutPanelRightGroup.RowCount = 2;
            this.tableLayoutPanelRightGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelRightGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelRightGroup.Size = new System.Drawing.Size(549, 425);
            this.tableLayoutPanelRightGroup.TabIndex = 1;
            // 
            // metroLabelRightGroup
            // 
            this.metroLabelRightGroup.AutoSize = true;
            this.tableLayoutPanelRightGroup.SetColumnSpan(this.metroLabelRightGroup, 3);
            this.metroLabelRightGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabelRightGroup.Location = new System.Drawing.Point(3, 0);
            this.metroLabelRightGroup.Name = "metroLabelRightGroup";
            this.metroLabelRightGroup.Size = new System.Drawing.Size(543, 42);
            this.metroLabelRightGroup.TabIndex = 0;
            this.metroLabelRightGroup.Text = "metroLabel1";
            this.metroLabelRightGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_display_1
            // 
            this.panel_display_1.BackColor = System.Drawing.Color.White;
            this.panel_display_1.Controls.Add(this.tableLayoutPanel_display_1);
            this.panel_display_1.Location = new System.Drawing.Point(-1, 32);
            this.panel_display_1.Name = "panel_display_1";
            this.panel_display_1.Size = new System.Drawing.Size(558, 488);
            this.panel_display_1.TabIndex = 6;
            // 
            // tableLayoutPanel_display_1
            // 
            this.tableLayoutPanel_display_1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_display_1.ColumnCount = 1;
            this.tableLayoutPanel_display_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_display_1.Controls.Add(this.tableLayoutPanel_dis1_tips, 0, 1);
            this.tableLayoutPanel_display_1.Controls.Add(this.tableLayoutPanelLeftGroup, 0, 0);
            this.tableLayoutPanel_display_1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel_display_1.Name = "tableLayoutPanel_display_1";
            this.tableLayoutPanel_display_1.RowCount = 2;
            this.tableLayoutPanel_display_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel_display_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_display_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_display_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_display_1.Size = new System.Drawing.Size(555, 482);
            this.tableLayoutPanel_display_1.TabIndex = 0;
            // 
            // tableLayoutPanel_dis1_tips
            // 
            this.tableLayoutPanel_dis1_tips.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_dis1_tips.ColumnCount = 2;
            this.tableLayoutPanel_dis1_tips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_dis1_tips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_dis1_tips.Controls.Add(this.label_tips1_normal, 0, 0);
            this.tableLayoutPanel_dis1_tips.Controls.Add(this.label_tips1_not_start, 1, 0);
            this.tableLayoutPanel_dis1_tips.Controls.Add(this.label_tips1_warning, 0, 1);
            this.tableLayoutPanel_dis1_tips.Controls.Add(this.label_tips1_start, 1, 1);
            this.tableLayoutPanel_dis1_tips.Location = new System.Drawing.Point(4, 436);
            this.tableLayoutPanel_dis1_tips.Name = "tableLayoutPanel_dis1_tips";
            this.tableLayoutPanel_dis1_tips.RowCount = 2;
            this.tableLayoutPanel_dis1_tips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_dis1_tips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_dis1_tips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_dis1_tips.Size = new System.Drawing.Size(547, 41);
            this.tableLayoutPanel_dis1_tips.TabIndex = 0;
            // 
            // label_tips1_normal
            // 
            this.label_tips1_normal.AutoSize = true;
            this.label_tips1_normal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tips1_normal.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tips1_normal.Image = global::XB_Configer.Properties.Resources.button_blue_alt;
            this.label_tips1_normal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_tips1_normal.Location = new System.Drawing.Point(4, 1);
            this.label_tips1_normal.Name = "label_tips1_normal";
            this.label_tips1_normal.Size = new System.Drawing.Size(266, 19);
            this.label_tips1_normal.TabIndex = 0;
            this.label_tips1_normal.Text = "   :正常";
            this.label_tips1_normal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_tips1_not_start
            // 
            this.label_tips1_not_start.AutoSize = true;
            this.label_tips1_not_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tips1_not_start.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tips1_not_start.Image = global::XB_Configer.Properties.Resources.button_blue_alt;
            this.label_tips1_not_start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_tips1_not_start.Location = new System.Drawing.Point(277, 1);
            this.label_tips1_not_start.Name = "label_tips1_not_start";
            this.label_tips1_not_start.Size = new System.Drawing.Size(266, 19);
            this.label_tips1_not_start.TabIndex = 1;
            this.label_tips1_not_start.Text = "   :未启动";
            this.label_tips1_not_start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_tips1_warning
            // 
            this.label_tips1_warning.AutoSize = true;
            this.label_tips1_warning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tips1_warning.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tips1_warning.Image = global::XB_Configer.Properties.Resources.button_red;
            this.label_tips1_warning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_tips1_warning.Location = new System.Drawing.Point(4, 21);
            this.label_tips1_warning.Name = "label_tips1_warning";
            this.label_tips1_warning.Size = new System.Drawing.Size(266, 19);
            this.label_tips1_warning.TabIndex = 2;
            this.label_tips1_warning.Text = "   :报警";
            this.label_tips1_warning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_tips1_start
            // 
            this.label_tips1_start.AutoSize = true;
            this.label_tips1_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tips1_start.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tips1_start.Image = global::XB_Configer.Properties.Resources.button_green;
            this.label_tips1_start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_tips1_start.Location = new System.Drawing.Point(277, 21);
            this.label_tips1_start.Name = "label_tips1_start";
            this.label_tips1_start.Size = new System.Drawing.Size(266, 19);
            this.label_tips1_start.TabIndex = 3;
            this.label_tips1_start.Text = "   :启动";
            this.label_tips1_start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelLeftGroup
            // 
            this.tableLayoutPanelLeftGroup.ColumnCount = 3;
            this.tableLayoutPanelLeftGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanelLeftGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelLeftGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanelLeftGroup.Controls.Add(this.metroLabelLeftGroup, 0, 0);
            this.tableLayoutPanelLeftGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeftGroup.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanelLeftGroup.Name = "tableLayoutPanelLeftGroup";
            this.tableLayoutPanelLeftGroup.RowCount = 2;
            this.tableLayoutPanelLeftGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelLeftGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelLeftGroup.Size = new System.Drawing.Size(547, 425);
            this.tableLayoutPanelLeftGroup.TabIndex = 1;
            // 
            // metroLabelLeftGroup
            // 
            this.metroLabelLeftGroup.AutoSize = true;
            this.tableLayoutPanelLeftGroup.SetColumnSpan(this.metroLabelLeftGroup, 3);
            this.metroLabelLeftGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabelLeftGroup.Location = new System.Drawing.Point(3, 0);
            this.metroLabelLeftGroup.Name = "metroLabelLeftGroup";
            this.metroLabelLeftGroup.Size = new System.Drawing.Size(541, 42);
            this.metroLabelLeftGroup.TabIndex = 0;
            this.metroLabelLeftGroup.Text = "metroLabel1";
            this.metroLabelLeftGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Control
            // 
            this.panel_Control.BackColor = System.Drawing.Color.White;
            this.panel_Control.Controls.Add(this.tableLayoutPanel_control);
            this.panel_Control.Location = new System.Drawing.Point(-1, 526);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(1126, 73);
            this.panel_Control.TabIndex = 5;
            // 
            // tableLayoutPanel_control
            // 
            this.tableLayoutPanel_control.ColumnCount = 1;
            this.tableLayoutPanel_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_control.Controls.Add(this.label_warning, 0, 1);
            this.tableLayoutPanel_control.Controls.Add(this.tableLayoutPanel_XB_control, 0, 0);
            this.tableLayoutPanel_control.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_control.Name = "tableLayoutPanel_control";
            this.tableLayoutPanel_control.RowCount = 2;
            this.tableLayoutPanel_control.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_control.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_control.Size = new System.Drawing.Size(1126, 72);
            this.tableLayoutPanel_control.TabIndex = 0;
            // 
            // label_warning
            // 
            this.label_warning.AutoSize = true;
            this.label_warning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_warning.ForeColor = System.Drawing.Color.Red;
            this.label_warning.Location = new System.Drawing.Point(3, 57);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(1120, 15);
            this.label_warning.TabIndex = 0;
            this.label_warning.Text = "注意:该项操作会导致高压开关分闸/合闸，请谨慎操作！";
            // 
            // tableLayoutPanel_XB_control
            // 
            this.tableLayoutPanel_XB_control.ColumnCount = 3;
            this.tableLayoutPanel_XB_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel_XB_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel_XB_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel_XB_control.Controls.Add(this.tableLayoutPanel_C2, 2, 0);
            this.tableLayoutPanel_XB_control.Controls.Add(this.tableLayoutPanel_C1, 1, 0);
            this.tableLayoutPanel_XB_control.Controls.Add(this.tableLayoutPanel_v, 0, 0);
            this.tableLayoutPanel_XB_control.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_XB_control.Name = "tableLayoutPanel_XB_control";
            this.tableLayoutPanel_XB_control.RowCount = 1;
            this.tableLayoutPanel_XB_control.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_XB_control.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel_XB_control.Size = new System.Drawing.Size(1120, 51);
            this.tableLayoutPanel_XB_control.TabIndex = 1;
            // 
            // tableLayoutPanel_C2
            // 
            this.tableLayoutPanel_C2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_C2.ColumnCount = 3;
            this.tableLayoutPanel_C2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.86447F));
            this.tableLayoutPanel_C2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.13553F));
            this.tableLayoutPanel_C2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel_C2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel_C2.Location = new System.Drawing.Point(752, 3);
            this.tableLayoutPanel_C2.Name = "tableLayoutPanel_C2";
            this.tableLayoutPanel_C2.RowCount = 2;
            this.tableLayoutPanel_C2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_C2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_C2.Size = new System.Drawing.Size(365, 45);
            this.tableLayoutPanel_C2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(4, 1);
            this.label7.Name = "label7";
            this.tableLayoutPanel_C2.SetRowSpan(this.label7, 2);
            this.label7.Size = new System.Drawing.Size(206, 43);
            this.label7.TabIndex = 0;
            this.label7.Text = "C2柜高压负荷开关控制";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_C1
            // 
            this.tableLayoutPanel_C1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_C1.ColumnCount = 3;
            this.tableLayoutPanel_C1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.86447F));
            this.tableLayoutPanel_C1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.13553F));
            this.tableLayoutPanel_C1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel_C1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel_C1.Location = new System.Drawing.Point(383, 3);
            this.tableLayoutPanel_C1.Name = "tableLayoutPanel_C1";
            this.tableLayoutPanel_C1.RowCount = 2;
            this.tableLayoutPanel_C1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_C1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_C1.Size = new System.Drawing.Size(363, 45);
            this.tableLayoutPanel_C1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Name = "label4";
            this.tableLayoutPanel_C1.SetRowSpan(this.label4, 2);
            this.label4.Size = new System.Drawing.Size(205, 43);
            this.label4.TabIndex = 0;
            this.label4.Text = "C1柜高压负荷开关控制";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_v
            // 
            this.tableLayoutPanel_v.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_v.ColumnCount = 3;
            this.tableLayoutPanel_v.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.86447F));
            this.tableLayoutPanel_v.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.13553F));
            this.tableLayoutPanel_v.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel_v.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel_v.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_v.Name = "tableLayoutPanel_v";
            this.tableLayoutPanel_v.RowCount = 2;
            this.tableLayoutPanel_v.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel_v.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel_v.Size = new System.Drawing.Size(374, 45);
            this.tableLayoutPanel_v.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.tableLayoutPanel_v.SetRowSpan(this.label1, 2);
            this.label1.Size = new System.Drawing.Size(212, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "V柜断路器控制";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label_ui_name);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 34);
            this.panel1.TabIndex = 4;
            // 
            // label_ui_name
            // 
            this.label_ui_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ui_name.AutoSize = true;
            this.label_ui_name.BackColor = System.Drawing.Color.Transparent;
            this.label_ui_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ui_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_ui_name.Location = new System.Drawing.Point(486, 9);
            this.label_ui_name.Name = "label_ui_name";
            this.label_ui_name.Size = new System.Drawing.Size(161, 16);
            this.label_ui_name.TabIndex = 0;
            this.label_ui_name.Text = "箱变数据显示及控制";
            // 
            // win7StyleTreeViewTurbines
            // 
            this.win7StyleTreeViewTurbines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.win7StyleTreeViewTurbines.HotTracking = true;
            this.win7StyleTreeViewTurbines.Location = new System.Drawing.Point(3, 3);
            this.win7StyleTreeViewTurbines.Name = "win7StyleTreeViewTurbines";
            treeNode5.Name = "节点1";
            treeNode5.Text = "节点1";
            treeNode6.Name = "节点2";
            treeNode6.Text = "节点2";
            treeNode7.Name = "节点3";
            treeNode7.Text = "节点3";
            treeNode8.Name = "节点0";
            treeNode8.Text = "选择风机";
            this.win7StyleTreeViewTurbines.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.tableLayoutPanelMain.SetRowSpan(this.win7StyleTreeViewTurbines, 3);
            this.win7StyleTreeViewTurbines.ShowLines = false;
            this.win7StyleTreeViewTurbines.Size = new System.Drawing.Size(79, 734);
            this.win7StyleTreeViewTurbines.TabIndex = 0;
            // 
            // tableLayoutPanelComboBoxes
            // 
            this.tableLayoutPanelComboBoxes.ColumnCount = 3;
            this.tableLayoutPanelComboBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelComboBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanelComboBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelComboBoxes.Controls.Add(this.comboBoxGroupSelect1, 0, 0);
            this.tableLayoutPanelComboBoxes.Controls.Add(this.comboBoxGroupSelect2, 1, 0);
            this.tableLayoutPanelComboBoxes.Controls.Add(this.comboBoxGroupSelect3, 2, 0);
            this.tableLayoutPanelComboBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelComboBoxes.Location = new System.Drawing.Point(88, 3);
            this.tableLayoutPanelComboBoxes.Name = "tableLayoutPanelComboBoxes";
            this.tableLayoutPanelComboBoxes.RowCount = 1;
            this.tableLayoutPanelComboBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelComboBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanelComboBoxes.Size = new System.Drawing.Size(1124, 68);
            this.tableLayoutPanelComboBoxes.TabIndex = 1;
            // 
            // comboBoxGroupSelect1
            // 
            this.comboBoxGroupSelect1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxGroupSelect1.FormattingEnabled = true;
            this.comboBoxGroupSelect1.ItemHeight = 23;
            this.comboBoxGroupSelect1.Location = new System.Drawing.Point(114, 19);
            this.comboBoxGroupSelect1.Name = "comboBoxGroupSelect1";
            this.comboBoxGroupSelect1.Size = new System.Drawing.Size(142, 29);
            this.comboBoxGroupSelect1.TabIndex = 0;
            this.comboBoxGroupSelect1.UseSelectable = true;
            // 
            // comboBoxGroupSelect2
            // 
            this.comboBoxGroupSelect2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxGroupSelect2.FormattingEnabled = true;
            this.comboBoxGroupSelect2.ItemHeight = 23;
            this.comboBoxGroupSelect2.Location = new System.Drawing.Point(490, 19);
            this.comboBoxGroupSelect2.Name = "comboBoxGroupSelect2";
            this.comboBoxGroupSelect2.Size = new System.Drawing.Size(142, 29);
            this.comboBoxGroupSelect2.TabIndex = 1;
            this.comboBoxGroupSelect2.UseSelectable = true;
            // 
            // comboBoxGroupSelect3
            // 
            this.comboBoxGroupSelect3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxGroupSelect3.FormattingEnabled = true;
            this.comboBoxGroupSelect3.ItemHeight = 23;
            this.comboBoxGroupSelect3.Location = new System.Drawing.Point(867, 19);
            this.comboBoxGroupSelect3.Name = "comboBoxGroupSelect3";
            this.comboBoxGroupSelect3.Size = new System.Drawing.Size(142, 29);
            this.comboBoxGroupSelect3.TabIndex = 2;
            this.comboBoxGroupSelect3.UseSelectable = true;
            // 
            // toolStripButtons
            // 
            this.toolStripButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButtonExit});
            this.toolStripButtons.Location = new System.Drawing.Point(85, 703);
            this.toolStripButtons.Name = "toolStripButtons";
            this.toolStripButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButtons.Size = new System.Drawing.Size(1130, 37);
            this.toolStripButtons.TabIndex = 2;
            this.toolStripButtons.Text = "toolStrip1";
            this.toolStripButtons.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripButtons_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExit.Image")));
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(36, 34);
            this.toolStripButtonExit.Text = "退出";
            // 
            // TransformerWindowPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 820);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransformerWindowPreview";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.metroPanelAll.ResumeLayout(false);
            this.panel_display_2.ResumeLayout(false);
            this.tableLayoutPanel_display_2.ResumeLayout(false);
            this.tableLayoutPanel_dis2_tips.ResumeLayout(false);
            this.tableLayoutPanel_dis2_tips.PerformLayout();
            this.tableLayoutPanelRightGroup.ResumeLayout(false);
            this.tableLayoutPanelRightGroup.PerformLayout();
            this.panel_display_1.ResumeLayout(false);
            this.tableLayoutPanel_display_1.ResumeLayout(false);
            this.tableLayoutPanel_dis1_tips.ResumeLayout(false);
            this.tableLayoutPanel_dis1_tips.PerformLayout();
            this.tableLayoutPanelLeftGroup.ResumeLayout(false);
            this.tableLayoutPanelLeftGroup.PerformLayout();
            this.panel_Control.ResumeLayout(false);
            this.tableLayoutPanel_control.ResumeLayout(false);
            this.tableLayoutPanel_control.PerformLayout();
            this.tableLayoutPanel_XB_control.ResumeLayout(false);
            this.tableLayoutPanel_C2.ResumeLayout(false);
            this.tableLayoutPanel_C2.PerformLayout();
            this.tableLayoutPanel_C1.ResumeLayout(false);
            this.tableLayoutPanel_C1.PerformLayout();
            this.tableLayoutPanel_v.ResumeLayout(false);
            this.tableLayoutPanel_v.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanelComboBoxes.ResumeLayout(false);
            this.toolStripButtons.ResumeLayout(false);
            this.toolStripButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private Kesoft.Windows.Forms.Win7StyleTreeView.Win7StyleTreeView win7StyleTreeViewTurbines;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelComboBoxes;
        private MetroFramework.Controls.MetroComboBox comboBoxGroupSelect1;
        private MetroFramework.Controls.MetroComboBox comboBoxGroupSelect2;
        private MetroFramework.Controls.MetroComboBox comboBoxGroupSelect3;
        private System.Windows.Forms.ToolStrip toolStripButtons;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private MetroFramework.Controls.MetroPanel metroPanelAll;
        private System.Windows.Forms.Panel panel_display_2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_display_2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_dis2_tips;
        private System.Windows.Forms.Label label_tips2_status_not_trigger;
        private System.Windows.Forms.Label label_tips2_warning_not_trigger;
        private System.Windows.Forms.Label label_tips2_status_trigger;
        private System.Windows.Forms.Label label_tips2_warning_trigger;
        private System.Windows.Forms.Panel panel_display_1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_display_1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_dis1_tips;
        private System.Windows.Forms.Label label_tips1_normal;
        private System.Windows.Forms.Label label_tips1_not_start;
        private System.Windows.Forms.Label label_tips1_warning;
        private System.Windows.Forms.Label label_tips1_start;
        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_control;
        private System.Windows.Forms.Label label_warning;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_XB_control;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_C2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_C1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_v;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_ui_name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRightGroup;
        private MetroFramework.Controls.MetroLabel metroLabelRightGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeftGroup;
        private MetroFramework.Controls.MetroLabel metroLabelLeftGroup;


    }
}