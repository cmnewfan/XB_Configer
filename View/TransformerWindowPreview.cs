using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using XB_Configer.Model;

namespace XB_Configer.View
{
    public partial class TransformerWindowPreview : MetroFramework.Forms.MetroForm
    {
        IEnumerable<WindTurbineDisplayGroup> displayGroupContents;
        IEnumerable<WindTurbineDisplayGroup> controlGroupContents;
        IEnumerable<WindTurbine> turbines;
        WindTurbine selectedWindTurbine;
        List<String> updateCommands = new List<string>();

        public TransformerWindowPreview()
        {
            InitializeComponent();
        }

        public TransformerWindowPreview(IEnumerable<WindTurbineDisplayGroup> displayContents, IEnumerable<WindTurbineDisplayGroup> controlContents, IEnumerable<WindTurbine> turbineInfo)
        {
            InitializeComponent();
            this.displayGroupContents = displayContents;
            this.controlGroupContents = controlContents;
            this.turbines = turbineInfo;
            this.initTreeView();
            this.initComboBoxes();
            this.win7StyleTreeViewTurbines.NodeMouseClick += win7StyleTreeViewTurbines_NodeMouseClick;
        }

        void win7StyleTreeViewTurbines_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var windTurbine = (WindTurbine)e.Node.Tag;
            if (windTurbine != null)
            {
                this.selectedWindTurbine = windTurbine;
                for (int i = 0; i < this.tableLayoutPanelComboBoxes.ColumnCount; i++)
                {
                    var control = (MetroFramework.Controls.MetroComboBox)this.tableLayoutPanelComboBoxes.GetControlFromPosition(i, 0);
                    if (i == this.tableLayoutPanelComboBoxes.ColumnCount - 1)
                    {
                        control.SelectedIndex = control.Items.IndexOf(windTurbine.controlGroup.getGroupName());
                    }
                    else
                    {
                        control.SelectedIndex = control.Items.IndexOf(windTurbine.displayGroups.ElementAt(i).getGroupName());
                    }
                }
                initGroupContents(windTurbine);
            }
        }

        private void initComboBoxes()
        {
            for (int i = 0; i < this.tableLayoutPanelComboBoxes.ColumnCount; i++)
            {
                var control = (MetroFramework.Controls.MetroComboBox)this.tableLayoutPanelComboBoxes.GetControlFromPosition(i, 0);
                control.SelectedIndexChanged += control_SelectedIndexChanged;
                if (i == this.tableLayoutPanelComboBoxes.ColumnCount - 1)
                {
                    control.Items.AddRange(controlGroupContents.Select(item => item.getGroupName()).ToArray());
                }
                else
                {
                    control.Items.AddRange(displayGroupContents.Select(item => item.getGroupName()).ToArray());
                }
            }
        }

        void control_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ((MetroFramework.Controls.MetroComboBox)sender).SelectedIndex;
            var control_index = this.tableLayoutPanelComboBoxes.GetPositionFromControl(((MetroFramework.Controls.MetroComboBox)sender)).Column;
            if (this.selectedWindTurbine.displayGroups.Count() > control_index)
            {
                this.selectedWindTurbine.displayGroups[control_index] = this.displayGroupContents.ElementAt(index);
                if (control_index == 0)
                {
                    this.updateCommands.Add("update XB_WindDefine set LeftGroupID=" + this.selectedWindTurbine.displayGroups[0].getGroupID() + " ,LeftGroupName='" + this.selectedWindTurbine.displayGroups[0].getGroupName() + "' where WindID=" + this.selectedWindTurbine.getWindTurbineID());
                }
                else if (control_index == 1)
                {
                    this.updateCommands.Add("update XB_WindDefine set RightGroupID=" + this.selectedWindTurbine.displayGroups[1].getGroupID() + " ,RightGroupName='" + this.selectedWindTurbine.displayGroups[1].getGroupName() + "' where WindID=" + this.selectedWindTurbine.getWindTurbineID());
                }
            }
            else
            {
                this.selectedWindTurbine.controlGroup = this.controlGroupContents.ElementAt(index);
                this.updateCommands.Add("update XB_WindDefine set ControlGroupID=" + this.selectedWindTurbine.controlGroup.getGroupID() + " ,ControlGroupName='" + this.selectedWindTurbine.controlGroup.getGroupName() + "' where WindID=" + this.selectedWindTurbine.getWindTurbineID());
            }
            initGroupContents(this.selectedWindTurbine);
        }

        private void initGroupContents(WindTurbine windTurbine)
        {
            this.tableLayoutPanelLeftGroup.Controls.Clear();
            this.tableLayoutPanelLeftGroup.RowCount = 1;
            this.tableLayoutPanelLeftGroup.RowStyles.Clear();
            this.tableLayoutPanelLeftGroup.RowStyles.Add(new RowStyle(SizeType.Absolute, 25.0f));
            this.tableLayoutPanelRightGroup.Controls.Clear();
            this.tableLayoutPanelRightGroup.RowCount = 1;
            this.tableLayoutPanelRightGroup.RowStyles.Clear();
            this.tableLayoutPanelRightGroup.RowStyles.Add(new RowStyle(SizeType.Absolute, 25.0f));
            var leftContents = windTurbine.displayGroups.ElementAt(0).groupItems;
            var rightContents = windTurbine.displayGroups.ElementAt(1).groupItems;
            int rowsLeft = leftContents.Count() / 2 + 2;
            int rowsRight = rightContents.Count() / 2 + 2;
            for (int i = 0; i < leftContents.Count(); i++)
            {
                if (i == 0)
                {
                    if (leftContents.ElementAt(0).getItemDisplayType().Equals("Normal"))
                    {
                        var itemUI = new NormalItemUI(leftContents.ElementAt(0).getItemName(), leftContents.ElementAt(0).getItemID());
                        this.tableLayoutPanelLeftGroup.Controls.Add(itemUI, 0, 0);
                        itemUI.Dock = DockStyle.Fill;
                    }
                    else if (leftContents.ElementAt(0).getItemDisplayType().Equals("Mix"))
                    {
                        this.tableLayoutPanelLeftGroup.RowStyles[this.tableLayoutPanelLeftGroup.RowStyles.Count - 1] = new RowStyle(SizeType.Absolute, 50.0f);
                        var itemUI = new MixItemUI(leftContents.ElementAt(0).getItemName(), leftContents.ElementAt(0).getItemID());
                        this.tableLayoutPanelLeftGroup.Controls.Add(itemUI, 0, 0);
                        itemUI.Dock = DockStyle.Fill;
                    }
                }
                else
                {
                    if (leftContents.ElementAt(i).getItemDisplayType().Equals("Normal"))
                    {
                        var itemUI = new NormalItemUI(leftContents.ElementAt(i).getItemName(), leftContents.ElementAt(i).getItemID());
                        this.tableLayoutPanelLeftGroup.Controls.Add(itemUI, (int)i % 2 == 0 ? 0 : 2, (int)i / 2);
                        itemUI.Dock = DockStyle.Fill;
                        if (i % 2 != 0)
                        {
                            this.tableLayoutPanelLeftGroup.RowCount++;
                            this.tableLayoutPanelLeftGroup.RowStyles.Add(new RowStyle(SizeType.Absolute, 25.0f));
                        }
                    }
                    else if (leftContents.ElementAt(i).getItemDisplayType().Equals("Mix"))
                    {
                        this.tableLayoutPanelLeftGroup.RowStyles[this.tableLayoutPanelLeftGroup.RowStyles.Count - 1] = new RowStyle(SizeType.Absolute, 50.0f);
                        var itemUI = new MixItemUI(leftContents.ElementAt(i).getItemName(), leftContents.ElementAt(i).getItemID());
                        this.tableLayoutPanelLeftGroup.Controls.Add(itemUI, (int)i % 2 == 0 ? 0 : 2, (int)i / 2);
                        itemUI.Dock = DockStyle.Fill;
                        if (i % 2 != 0)
                        {
                            this.tableLayoutPanelLeftGroup.RowCount++;
                            this.tableLayoutPanelLeftGroup.RowStyles.Add(new RowStyle(SizeType.Absolute, 25.0f));
                        }
                    }
                }
            }
            for (int i = 0; i < rightContents.Count(); i++)
            {
                if (i == 0)
                {
                    if (rightContents.ElementAt(0).getItemDisplayType().Equals("Normal"))
                    {
                        var itemUI = new NormalItemUI(rightContents.ElementAt(0).getItemName(), rightContents.ElementAt(0).getItemID());
                        this.tableLayoutPanelRightGroup.Controls.Add(itemUI, 0, 0);
                        itemUI.Dock = DockStyle.Fill;
                    }
                    else if (rightContents.ElementAt(0).getItemDisplayType().Equals("Mix"))
                    {
                        this.tableLayoutPanelRightGroup.RowStyles[this.tableLayoutPanelRightGroup.RowStyles.Count - 1] = new RowStyle(SizeType.Absolute, 50.0f);
                        var itemUI = new MixItemUI(rightContents.ElementAt(0).getItemName(), rightContents.ElementAt(0).getItemID());
                        this.tableLayoutPanelRightGroup.Controls.Add(itemUI, 0, 0);
                        itemUI.Dock = DockStyle.Fill;
                    }
                }
                else
                {
                    if (rightContents.ElementAt(i).getItemDisplayType().Equals("Normal"))
                    {
                        var itemUI = new NormalItemUI(rightContents.ElementAt(i).getItemName(), rightContents.ElementAt(i).getItemID());
                        this.tableLayoutPanelRightGroup.Controls.Add(itemUI, (int)i % 2 == 0 ? 0 : 2, (int)i / 2);
                        itemUI.Dock = DockStyle.Fill;
                        if (i % 2 != 0)
                        {
                            this.tableLayoutPanelRightGroup.RowCount++;
                            this.tableLayoutPanelRightGroup.RowStyles.Add(new RowStyle(SizeType.Absolute, 25.0f));
                        }
                    }
                    else if (rightContents.ElementAt(i).getItemDisplayType().Equals("Mix"))
                    {
                        this.tableLayoutPanelRightGroup.RowStyles[this.tableLayoutPanelRightGroup.RowStyles.Count - 1] = new RowStyle(SizeType.Absolute, 50.0f);
                        var itemUI = new MixItemUI(rightContents.ElementAt(i).getItemName(), rightContents.ElementAt(i).getItemID());
                        this.tableLayoutPanelRightGroup.Controls.Add(itemUI, (int)i % 2 == 0 ? 0 : 2, (int)i / 2);
                        itemUI.Dock = DockStyle.Fill;
                        if (i % 2 != 0)
                        {
                            this.tableLayoutPanelRightGroup.RowCount++;
                            this.tableLayoutPanelRightGroup.RowStyles.Add(new RowStyle(SizeType.Absolute, 25.0f));
                        }
                    }
                }
            }
            this.tableLayoutPanelLeftGroup.RowCount++;
            this.tableLayoutPanelLeftGroup.RowStyles.Add(new RowStyle(SizeType.Absolute, 25.0f));
            this.tableLayoutPanelRightGroup.RowCount++;
            this.tableLayoutPanelRightGroup.RowStyles.Add(new RowStyle(SizeType.Absolute, 25.0f));
        }

        private void initTreeView()
        {
            this.win7StyleTreeViewTurbines.Nodes[0].Nodes.Clear();
            for (int i = 0; i < turbines.Count(); i++)
            {
                TreeNode node = new TreeNode(turbines.ElementAt(i).getWindTurbineName());
                node.Tag = turbines.ElementAt(i);
                this.win7StyleTreeViewTurbines.Nodes[0].Nodes.Add(node);
            }
        }

        private void toolStripButtons_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == this.toolStripButtonExit)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
    }
}
