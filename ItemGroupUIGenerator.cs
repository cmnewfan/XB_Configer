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
using XB_Configer.View;

namespace XB_Configer
{
    public partial class ItemGroupUIGenerator : MetroFramework.Forms.MetroForm
    {
        public List<String> updateCommands = new List<string>();
        private Dictionary<String, List<XB_Item>> groupContents;
        private IEnumerable<XB_Item> singleItems;
        private IEnumerable<XB_Item> boolItems;
        private IEnumerable<XB_Item> controlItems;
        private Point mouseLocation;
        private List<String> contentBoolItems = new List<string>();
        private List<String> contentSingleItems = new List<string>();
        private List<String> contentControlItems = new List<string>();
        private Boolean isChanged = false;
        private int lastSelectedIndex = 0;

        public ItemGroupUIGenerator()
        {
            InitializeComponent();
        }

        public ItemGroupUIGenerator(List<XB_Item> singleItem, IEnumerable<XB_Item> boolItem, IEnumerable<XB_Item> controlItem, Dictionary<String, List<XB_Item>> contents)
        {
            InitializeComponent();
            this.singleItems = singleItem;
            this.boolItems = boolItem;
            this.controlItems = controlItem;
            if (singleItems != null && singleItems.Count() > 0 && boolItems != null && boolItems.Count() > 0 && controlItems!=null && controlItems.Count()>0)
            {
                for (int i = 0; i < singleItems.Count(); i++)
                {
                    this.win7StyleTreeView.Nodes[0].Nodes.Add(singleItems.ElementAt(i).getItemName());
                }
                for (int i = 0; i < boolItems.Count(); i++)
                {
                    this.win7StyleTreeView.Nodes[1].Nodes.Add(boolItems.ElementAt(i).getItemName());
                }
                for (int i = 0; i < controlItems.Count(); i++)
                {
                    this.win7StyleTreeView.Nodes[2].Nodes.Add(controlItems.ElementAt(i).getItemName());
                }
            }
            this.groupContents = contents;
            this.metroComboBoxGroups.Items.Clear();
            for (int i = 0; i < groupContents.Keys.Count; i++)
            {
                this.metroComboBoxGroups.Items.Add(groupContents.Keys.ElementAt(i));
            }
            this.metroComboBoxGroups.SelectedIndex = 0;
        }

        private void metroComboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lastSelectedIndex!=this.metroComboBoxGroups.SelectedIndex && isChanged)
            {
                switch (lastSelectedIndex)
                {
                    case 0:
                        this.updateCommands.Add(@"delete from ItemGroupDefine where ItemGroupID=303");
                        generateUpdateCommands(lastSelectedIndex);
                        break;
                    case 1:
                        this.updateCommands.Add(@"delete from ItemGroupDefine where ItemGroupID=304");
                        generateUpdateCommands(lastSelectedIndex);
                        break;
                    case 2:
                        this.updateCommands.Add(@"delete from ItemGroupDefine where ItemGroupID=305");
                        generateUpdateCommands(lastSelectedIndex);
                        break;
                    case 3:
                        this.updateCommands.Add(@"delete from ItemGroupDefine where ItemGroupID=306");
                        generateUpdateCommands(lastSelectedIndex);
                        break;
                    case 4:
                        this.updateCommands.Add(@"delete from ItemGroupDefine where ItemGroupID=307");
                        generateUpdateCommands(lastSelectedIndex);
                        break;
                    case 5:
                        this.updateCommands.Add(@"delete from ItemGroupDefine where ItemGroupID=308");
                        generateUpdateCommands(lastSelectedIndex);
                        break;
                    case 6:
                        this.updateCommands.Add(@"delete from ItemGroupDefine where ItemGroupID=309");
                        generateUpdateCommands(lastSelectedIndex);
                        break;
                    default:
                        break;
                }
            }
            initGroupContents(this.metroComboBoxGroups.SelectedIndex);
            this.isChanged = false;
        }

        private void generateUpdateCommands(int tableIndex)
        {
            switch (tableIndex)
            {
                case 0:
                    this.updateCommands.Add(@"delete from ItemGroupDefine where ItemGroupID=303");
                    break;
                case 1:
                    this.updateCommands.Add(@"delete from ItemGroupDefine where ItemGroupID=304");
                    break;
                case 2:
                    this.updateCommands.Add(@"delete from ItemGroupDefine where ItemGroupID=305");
                    break;
                case 3:
                    this.updateCommands.Add(@"delete from ItemGroupDefine where ItemGroupID=306");
                    break;
                case 4:
                    this.updateCommands.Add(@"delete from ItemGroupDefine where ItemGroupID=307");
                    break;
                case 5:
                    this.updateCommands.Add(@"delete from ItemGroupDefine where ItemGroupID=308");
                    break;
                case 6:
                    this.updateCommands.Add(@"delete from ItemGroupDefine where ItemGroupID=309");
                    break;
                default:
                    break;
            }
            for (int i = 0; i < this.tableLayoutPanelContent.RowCount; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        var item = this.tableLayoutPanelContent.GetControlFromPosition(0, i);
                        if (item is NormalItemUI)
                        {
                            this.updateCommands.Add(@"insert into ItemGroupDefine values (303," + ((NormalItemUI)item).getItemID() + @",0)");
                        }
                        else if (item is MixItemUI)
                        {
                            this.updateCommands.Add(@"insert into ItemGroupDefine values (303," + ((MixItemUI)item).getItemID() + @",0)");
                        }
                    }
                }
            }
        }

        private void initGroupContents(int selectedIndex)
        {
            contentBoolItems.Clear();
            contentSingleItems.Clear();
            contentControlItems.Clear();
            this.tableLayoutPanelContent.Controls.Clear();
            this.tableLayoutPanelContent.RowCount = 1;
            this.tableLayoutPanelContent.RowStyles.Clear();
            this.tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 25.0f));
            var contents = this.groupContents.Values.ElementAt(selectedIndex);
            if (selectedIndex >= 4)
            {
                foreach (XB_Item item in contents)
                {
                    contentControlItems.Add(item.getItemName());
                }
            }
            int rows = contents.Count() / 2 + 2;
            for (int i = 0; i < contents.Count(); i++)
            {
                if (i == 0)
                {
                    if (contents.ElementAt(0).getItemDisplayType().Equals("Normal"))
                    {
                        var itemUI = new NormalItemUI(contents.ElementAt(0).getItemName(), contents.ElementAt(0).getItemID());
                        this.tableLayoutPanelContent.Controls.Add(itemUI, 0, 0);
                        itemUI.Dock = DockStyle.Fill;
                        itemUI.ContextMenuStrip = this.metroContextMenuItem;
                        initContentItems(contents.ElementAt(0).getItemUnitType(), contents.ElementAt(0).getItemName());
                    }
                    else if (contents.ElementAt(0).getItemDisplayType().Equals("Mix"))
                    {
                        this.tableLayoutPanelContent.RowStyles[this.tableLayoutPanelContent.RowStyles.Count - 1] = new RowStyle(SizeType.Absolute, 50.0f);
                        var itemUI = new MixItemUI(contents.ElementAt(0).getItemName(), contents.ElementAt(0).getItemID());
                        this.tableLayoutPanelContent.Controls.Add(itemUI, 0, 0);
                        itemUI.Dock = DockStyle.Fill;
                        itemUI.ContextMenuStrip = this.metroContextMenuItem;
                        initContentItems(contents.ElementAt(0).getItemUnitType(), contents.ElementAt(0).getItemName());
                    }
                }
                else
                {
                    if (contents.ElementAt(i).getItemDisplayType().Equals("Normal"))
                    {
                        var itemUI = new NormalItemUI(contents.ElementAt(i).getItemName(), contents.ElementAt(i).getItemID());
                        this.tableLayoutPanelContent.Controls.Add(itemUI, (int)i % 2 == 0 ? 0 : 2, (int)i / 2);
                        itemUI.Dock = DockStyle.Fill;
                        itemUI.ContextMenuStrip = this.metroContextMenuItem;
                        //itemUI.ContextMenuStrip.Items[0].Visible = false;
                        if (i % 2 != 0)
                        {
                            this.tableLayoutPanelContent.RowCount++;
                            this.tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 25.0f));
                        }
                        initContentItems(contents.ElementAt(i).getItemUnitType(), contents.ElementAt(i).getItemName());
                    }
                    else if (contents.ElementAt(i).getItemDisplayType().Equals("Mix"))
                    {
                        this.tableLayoutPanelContent.RowStyles[this.tableLayoutPanelContent.RowStyles.Count - 1] = new RowStyle(SizeType.Absolute, 50.0f);
                        var itemUI = new MixItemUI(contents.ElementAt(i).getItemName(), contents.ElementAt(i).getItemID());
                        this.tableLayoutPanelContent.Controls.Add(itemUI, (int)i % 2 == 0 ? 0 : 2, (int)i / 2);
                        itemUI.Dock = DockStyle.Fill;
                        itemUI.ContextMenuStrip = this.metroContextMenuItem;
                        //itemUI.ContextMenuStrip.Items[0].Visible = false;
                        if (i % 2 != 0)
                        {
                            this.tableLayoutPanelContent.RowCount++;
                            this.tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 25.0f));
                        }
                        initContentItems(contents.ElementAt(i).getItemUnitType(), contents.ElementAt(i).getItemName());
                    }
                }
            }
            this.tableLayoutPanelContent.RowCount++;
            this.tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 25.0f));
            updateTreeAndContext();
        }

        private void toolStripButtons_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == this.toolStripButtonExit)
            {
                if (isChanged)
                {
                    generateUpdateCommands(this.metroComboBoxGroups.SelectedIndex);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void initContentItems(String itemType, String itemName)
        {
            if (itemType.Equals(""))
            {
                this.contentBoolItems.Add(itemName);
            }
            else
            {
                this.contentSingleItems.Add(itemName);
            }
        }

        private void tableLayoutPanelContent_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void toolStripMenuItemDel_Click(object sender, EventArgs e)
        {
            var parentControl = this.metroContextMenuItem.SourceControl;
            if (parentControl is NormalItemUI || parentControl is MixItemUI)
            {
                var position = this.tableLayoutPanelContent.GetCellPosition(parentControl);
                this.tableLayoutPanelContent.Controls.Remove(parentControl);
                Label nullLabel = new Label();
                this.tableLayoutPanelContent.Controls.Add(nullLabel, position.Column, position.Row);
                nullLabel.Dock = DockStyle.Fill;
                nullLabel.Text = "";
                nullLabel.ContextMenuStrip = this.metroContextMenuTable;
                updateTreeAndContext();
                this.isChanged = true;
            }
        }

        private void tableLayoutPanelContent_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && !this.metroContextMenuItem.Created)
            {
                this.tableLayoutPanelContent.ContextMenuStrip.Items[0].Visible = true;
            }
        }

        private void updateTreeAndContext()
        {
            this.win7StyleTreeView.Nodes[0].Nodes.Clear();
            this.win7StyleTreeView.Nodes[1].Nodes.Clear();
            this.win7StyleTreeView.Nodes[2].Nodes.Clear();
            this.toolStripMenuItemAddSingle.DropDownItems.Clear();
            this.toolStripMenuItemEditSingle.DropDownItems.Clear();
            this.toolStripMenuItemAddBool.DropDownItems.Clear();
            this.toolStripMenuItemEditBool.DropDownItems.Clear();
            this.toolStripMenuItemAddControl.DropDownItems.Clear();
            this.toolStripMenuItemEditControl.DropDownItems.Clear();
            var leftBoolItems = boolItems.Select(item => item.getItemName()).Except(contentBoolItems).ToArray();
            var leftSingleItems = singleItems.Select(item => item.getItemName()).Except(contentSingleItems).ToArray();
            var leftControlItems = controlItems.Select(item => item.getItemName()).Except(contentControlItems).ToArray();
            foreach (String itemName in leftSingleItems)
            {
                this.win7StyleTreeView.Nodes[0].Nodes.Add(itemName);
                ToolStripMenuItem itemForAdd = new ToolStripMenuItem(itemName);
                itemForAdd.Click += item_Click;
                this.toolStripMenuItemAddSingle.DropDownItems.Add(itemForAdd);
                ToolStripMenuItem itemForEdit = new ToolStripMenuItem(itemName);
                itemForEdit.Click += item_Click;
                this.toolStripMenuItemEditSingle.DropDownItems.Add(itemForEdit);
            }
            foreach (String itemName in leftBoolItems)
            {
                this.win7StyleTreeView.Nodes[1].Nodes.Add(itemName);
                ToolStripMenuItem itemForAdd = new ToolStripMenuItem(itemName);
                itemForAdd.Click += item_Click;
                this.toolStripMenuItemAddBool.DropDownItems.Add(itemForAdd);
                ToolStripMenuItem itemForEdit = new ToolStripMenuItem(itemName);
                itemForEdit.Click += item_Click;
                this.toolStripMenuItemEditBool.DropDownItems.Add(itemForEdit);
            }
            foreach (String itemName in leftControlItems)
            {
                this.win7StyleTreeView.Nodes[2].Nodes.Add(itemName);
                ToolStripMenuItem itemForAdd = new ToolStripMenuItem(itemName);
                itemForAdd.Click += item_Click;
                this.toolStripMenuItemAddControl.DropDownItems.Add(itemForAdd);
                ToolStripMenuItem itemForEdit = new ToolStripMenuItem(itemName);
                itemForEdit.Click += item_Click;
                this.toolStripMenuItemEditControl.DropDownItems.Add(itemForEdit);
            }
        }

        void item_Click(object sender, EventArgs e)
        {
            var clickedItem = (ToolStripMenuItem)sender;
            var clickedItemType = clickedItem.OwnerItem.Text;
            var clickedType = clickedItem.OwnerItem.OwnerItem.Text;
            if (clickedType.Equals("增加"))
            {
                var parentControl = this.metroContextMenuItem.SourceControl;
                if (parentControl == null)
                {
                    addClickedToolStripMenuItem(clickedItem, clickedItemType);
                }
                else if (parentControl is Label)
                {
                    var position = this.tableLayoutPanelContent.GetCellPosition(parentControl);
                    this.tableLayoutPanelContent.Controls.Remove(parentControl);
                    addClickedToolStripMenuItem(clickedItem, clickedItemType, position.Column, position.Row);
                }
                this.isChanged = true;
            }
            else if (clickedType.Equals("替换"))
            {
                var parentControl = this.metroContextMenuItem.SourceControl;
                if (parentControl is NormalItemUI || parentControl is MixItemUI)
                {
                    var position = this.tableLayoutPanelContent.GetCellPosition(parentControl);
                    this.tableLayoutPanelContent.Controls.Remove(parentControl);
                    addClickedToolStripMenuItem(clickedItem, clickedItemType, position.Column, position.Row);
                    updateTreeAndContext();
                    this.isChanged = true;
                }
            }
        }

        private void addClickedToolStripMenuItem(ToolStripMenuItem clickedItem, string clickedItemType, int column = -1, int row = -1)
        {
            var targetItem = getSelectedItemByName(clickedItemType, clickedItem.Text);
            if (targetItem.getItemDisplayType().Equals("Normal"))
            {
                var targetItemUI = new NormalItemUI(targetItem.getItemName(), targetItem.getItemID());
                int i = this.tableLayoutPanelContent.Controls.Count;
                if (column == -1 && row == -1)
                {
                    this.tableLayoutPanelContent.Controls.Add(targetItemUI, (int)i % 2 == 0 ? 0 : 2, (int)i / 2);
                }
                else
                {
                    this.tableLayoutPanelContent.Controls.Add(targetItemUI, column, row);
                }
                targetItemUI.Dock = DockStyle.Fill;
                targetItemUI.ContextMenuStrip = this.metroContextMenuItem;
                if (i % 2 != 0)
                {
                    this.tableLayoutPanelContent.RowCount++;
                    this.tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 25.0f));
                }
                initContentItems(targetItem.getItemUnitType(), targetItem.getItemName());
            }
            else if (targetItem.getItemDisplayType().Equals("Mix"))
            {
                var targetItemUI = new MixItemUI(targetItem.getItemName(), targetItem.getItemID());
                int i = this.tableLayoutPanelContent.Controls.Count;
                this.tableLayoutPanelContent.RowStyles[this.tableLayoutPanelContent.RowStyles.Count - 1] = new RowStyle(SizeType.Absolute, 50.0f);
                if (column == -1 && row == -1)
                {
                    this.tableLayoutPanelContent.Controls.Add(targetItemUI, (int)i % 2 == 0 ? 0 : 2, (int)i / 2);
                }
                else
                {
                    this.tableLayoutPanelContent.Controls.Add(targetItemUI, column, row);
                }
                targetItemUI.Dock = DockStyle.Fill;
                targetItemUI.ContextMenuStrip = this.metroContextMenuItem;
                if (i % 2 != 0)
                {
                    this.tableLayoutPanelContent.RowCount++;
                    this.tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 25.0f));
                }
                initContentItems(targetItem.getItemUnitType(), targetItem.getItemName());
            }
        }

        private XB_Item getSelectedItemByName(String itemType, String itemName)
        {
            switch (itemType)
            {
                case "模拟量":
                    return singleItems.First(item => item.getItemName().Equals(itemName));
                case "布尔量":
                    return boolItems.First(item => item.getItemName().Equals(itemName));
                case "控制量":
                    return controlItems.First(item => item.getItemName().Equals(itemName));
                default:
                    return null;
            }
        }

        private void metroContextMenuContent_VisibleChanged(object sender, EventArgs e)
        {
            if (this.metroContextMenuItem.Visible)
            {
                if (this.metroContextMenuItem.SourceControl is NormalItemUI || this.metroContextMenuItem.SourceControl is MixItemUI)
                {
                    this.metroContextMenuItem.Items[0].Visible = false;
                }
                else
                {
                    this.metroContextMenuItem.Items[0].Visible = true;
                }
            }
        }
    }
}
