using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace XB_Configer
{
    public partial class Form1 : Form
    {
        private SqlConnection mConnection;
        private SqlCommand mCommand;
        private String connectionString = ConfigurationManager.ConnectionStrings["5MW_Config"].ConnectionString;
        private BackgroundWorker mWorker;
        private List<String> sqlCommands = null;
        public Form1()
        {
            InitializeComponent();
            mConnection = new SqlConnection(connectionString);
            try
            {
                mConnection.Open();
                mCommand = new SqlCommand();
                mCommand.Connection = mConnection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            mWorker = new BackgroundWorker();
            mWorker.DoWork += sqlWorker_DoWork;
            mWorker.ProgressChanged += sqlWorker_ProgressChanged;
            mWorker.WorkerReportsProgress = true;
            this.toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            this.dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            this.dataGridView1.DataError += dataGridView1_DataError;
            this.dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            this.dataGridView1.CellClick += dataGridView1_CellClick;
            toolStrip1_ItemClicked(this.toolStrip1, new ToolStripItemClickedEventArgs(this.toolStripButton_New));
        }

        void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.toolStripButton_New.Checked && e.ColumnIndex == 4)
            {
                int itemID = int.Parse(this.dataGridView1[0, e.RowIndex].Value.ToString());
                if (itemID >= 1795 && itemID <= 1800)
                {
                    MessageBox.Show("箱变控制量不能修改样式.","提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else if (itemID >= 1721 && itemID <= 1730)
                {
                    MessageBox.Show("箱变模拟量不能修改样式.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else
                {
                    ItemUIGenerator generatorForm = new ItemUIGenerator();
                    var result = generatorForm.ShowDialog();
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        var newModeName = generatorForm.modeName;
                        StringBuilder sBuilder = new StringBuilder();
                        sBuilder.Append(@"update XB_ItemDefine set ItemValueColor='" + newModeName + @"' where ItemID=" + this.dataGridView1[0, e.RowIndex].ToString());
                        sqlCommands.Add(sBuilder.ToString());
                    }
                }
            }
        }

        void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs ea)
        {
            if (this.dataGridView1.IsCurrentCellDirty)
            {
                this.dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            StringBuilder sBuilder = new StringBuilder();
            if (this.toolStripButton_Item.Checked && !this.toolStripButton_WT.Checked)
            {
                if (this.dataGridView1[1, e.RowIndex].Value == null || this.dataGridView1[1, e.RowIndex].Value.ToString().Equals(""))
                {
                    if (this.dataGridView1[e.ColumnIndex, e.RowIndex].Value.Equals(""))
                    {
                        this.dataGridView1[1, e.RowIndex].Selected = true;
                        return;
                    }
                    MessageBox.Show("不能修改该行.");
                    this.dataGridView1[e.ColumnIndex, e.RowIndex].Value = "";
                    return;
                }
                var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                var id = dataGridView1[0, e.RowIndex].Value.ToString();
                String updateValue =  null;
                if (cell.Value.ToString().Equals("红色"))
                {
                    updateValue = "Red";
                }
                else if (cell.Value.ToString().Equals("绿色"))
                {
                    updateValue = "Green";
                }
                else if (cell.Value.ToString().Equals("分闸绿合闸红"))
                {
                    updateValue = "Mix";
                }
                else if (cell.Value.ToString().Equals("分闸红合闸绿"))
                {
                    updateValue = "MixDesc";
                }
                sBuilder.Append(@"update XB_ItemDefine set ItemValueColor='" + updateValue + @"' where ItemID=" + id);
                sqlCommands.Add(sBuilder.ToString());
            }
            else if (!this.toolStripButton_Item.Checked && this.toolStripButton_WT.Checked)
            {
                if (this.dataGridView1[1, e.RowIndex].Value == null || this.dataGridView1[1, e.RowIndex].Value.ToString().Equals(""))
                {
                    MessageBox.Show("不能修改该行.");
                    this.dataGridView1[e.ColumnIndex, e.RowIndex].Value = "";
                    return;
                }
                var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                bool value1 = false;
                bool value2 = false;
                if (Boolean.TryParse(dataGridView1[3, e.RowIndex].Value.ToString(), out value1))
                {
                    if (Boolean.TryParse(dataGridView1[4, e.RowIndex].Value.ToString(), out value2))
                    {

                    }
                    else
                    {
                        value2 = Convert.ToBoolean(int.Parse(dataGridView1[4, e.RowIndex].Value.ToString()));
                    }

                }
                else
                {
                    value1 = Convert.ToBoolean(int.Parse(dataGridView1[3, e.RowIndex].Value.ToString()));
                    if (Boolean.TryParse(dataGridView1[4, e.RowIndex].Value.ToString(), out value2))
                    {

                    }
                    else
                    {
                        value2 = Convert.ToBoolean(int.Parse(dataGridView1[4, e.RowIndex].Value.ToString()));
                    }
                }
                var id = dataGridView1[0, e.RowIndex].Value.ToString();
                if (!value1 && value2)
                {
                    MessageBox.Show("没有该类型的机组.");
                    if (e.ColumnIndex == 3)
                    {
                        dataGridView1[3, e.RowIndex].Value = "1";
                    }
                    else
                    {
                        dataGridView1[4, e.RowIndex].Value = "0";
                    }
                    return;
                }
                String updateValue = null;
                if (e.ColumnIndex == 3)
                {
                    updateValue = "HasC1";
                }
                else if (e.ColumnIndex == 4)
                {
                    updateValue = "HasC2";
                }
                sBuilder.Append(@"update XB_WindDefine set "+ updateValue + "=" + cell.Value.ToString() + " where WindID=" + id);
                sqlCommands.Add(sBuilder.ToString());
            }
            else if (toolStripButton_New.Checked)
            {
                if (e.ColumnIndex == 1)
                {
                    sBuilder.Append(@"update TotalItemDefine set ItemChineseName='" + dataGridView1[e.ColumnIndex, e.RowIndex].Value + "' where ItemID=" + dataGridView1[0, e.RowIndex].Value);
                }
                else if(e.ColumnIndex == 2)
                {
                    int cell_value = 0;
                    bool value = false;
                    if (!Boolean.TryParse(dataGridView1[2, e.RowIndex].Value.ToString(), out value))
                    {
                        cell_value = int.Parse(dataGridView1[2, e.RowIndex].Value.ToString());
                    }
                    else
                    {
                        cell_value = Convert.ToInt32(value);
                    }
                    sBuilder.Append(@"update TotalItemDefine set IsVirtual=" + Math.Abs(cell_value - 1) + " where ItemID=" + dataGridView1[0, e.RowIndex].Value);
                }
                sqlCommands.Add(sBuilder.ToString());
            }
        }

        void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
            if (cell.Value == null)
            {
                return;
            }
            this.dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
            if (cell.Value.ToString().Equals("Red"))
            {
                cell.Value = "红色";
            }
            else if (cell.Value.ToString().Equals("Green"))
            {
                cell.Value = "绿色";
            }
            else if (cell.Value.ToString().Equals("Mix"))
            {
                cell.Value = "分闸绿合闸红";
            }
            else if (cell.Value.ToString().Equals("MixDesc"))
            {
                cell.Value = "分闸红合闸绿";
            }
            this.dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            return;
        }

        void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }
            if (e.Value.ToString().Equals("Red"))
            {
                e.Value = "红色";
            }
            else if (e.Value.ToString().Equals("Green"))
            {
                e.Value = "绿色";
            }
            else if (e.Value.ToString().Equals("Mix"))
            {
                e.Value = "分闸绿合闸红";
            }
            else if (e.Value.ToString().Equals("MixDesc"))
            {
                e.Value = "分闸红合闸绿";
            }
        }

        void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == this.toolStripButton_Item)
            {
                preapreDoClick();
                this.toolStripButton_Item.Checked = true;
                this.toolStripButton_WT.Checked = false;
                this.toolStripButton_New.Checked = false;
                this.toolStrip1.Enabled = false;
                this.progressPanel1.BringToFront();
                mWorker.RunWorkerAsync(0);
            }
            else if (e.ClickedItem == this.toolStripButton_WT)
            {
                preapreDoClick();
                this.toolStripButton_New.Checked = false;
                this.toolStripButton_Item.Checked = false;
                this.toolStripButton_WT.Checked = true;
                this.progressPanel1.BringToFront();
                mWorker.RunWorkerAsync(1);
            }
            else if (e.ClickedItem == this.toolStripButton_Save)
            {
                this.progressPanel1.BringToFront();
                BackgroundWorker sqlCommandWorker = new BackgroundWorker();
                sqlCommandWorker.DoWork += sqlCommandWorker_DoWork;
                sqlCommandWorker.WorkerReportsProgress = true;
                sqlCommandWorker.ProgressChanged += sqlCommandWorker_ProgressChanged;
                if (this.toolStripButton_Item.Checked && !this.toolStripButton_WT.Checked)
                {
                    sqlCommandWorker.RunWorkerAsync("Item");
                }
                else if (!this.toolStripButton_Item.Checked && this.toolStripButton_WT.Checked)
                {
                    sqlCommandWorker.RunWorkerAsync("WT");
                }
                else if (this.toolStripButton_New.Checked)
                {
                    sqlCommandWorker.RunWorkerAsync("New");
                }
            }
            else if (e.ClickedItem == this.toolStripButton_New)
            {
                preapreDoClick();
                this.toolStripButton_Item.Checked = false;
                this.toolStripButton_WT.Checked = false;
                this.toolStripButton_New.Checked = true;
                this.toolStrip1.Enabled = false;
                this.progressPanel1.BringToFront();
                mWorker.RunWorkerAsync(2);
            }
        }

        private void preapreDoClick()
        {
            if (this.sqlCommands == null)
            {
                this.sqlCommands = new List<string>();
            }
            else if (this.sqlCommands.Count > 0)
            {
                if (MessageBox.Show("你已经修改了部分数据,是否保存修改结果?", "确认修改", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.progressPanel1.BringToFront();
                    BackgroundWorker sqlCommandWorker = new BackgroundWorker();
                    sqlCommandWorker.DoWork += sqlCommandWorker_DoWork;
                    sqlCommandWorker.WorkerReportsProgress = true;
                    sqlCommandWorker.ProgressChanged += sqlCommandWorker_ProgressChanged;
                    sqlCommandWorker.RunWorkerAsync();
                }
                else
                {
                    sqlCommands.Clear();
                }
            }
            this.dataGridView1.Columns.Clear();
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
        }

        void sqlCommandWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.dataGridView1.BringToFront();
            MessageBox.Show("数据修改已完成.");
            if (e.ProgressPercentage == 100)
            {
                toolStrip1_ItemClicked(this.toolStrip1, new ToolStripItemClickedEventArgs(this.toolStripButton_Item));
            }
            else if (e.ProgressPercentage == 101)
            {
                toolStrip1_ItemClicked(this.toolStrip1, new ToolStripItemClickedEventArgs(this.toolStripButton_WT));
            }
            else if (e.ProgressPercentage == 102)
            {
                toolStrip1_ItemClicked(this.toolStrip1, new ToolStripItemClickedEventArgs(this.toolStripButton_New));
            }
        }

        void sqlCommandWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            for (int i = 0; i < sqlCommands.Count; i++)
            {
                mCommand.CommandText = sqlCommands[i];
                mCommand.ExecuteNonQuery();
            }
            sqlCommands.Clear();
            if (e.Argument == null)
            {
                worker.ReportProgress(99);
            }
            else if(e.Argument.ToString().Equals("Item"))
            {
                worker.ReportProgress(100);
            }
            else if (e.Argument.ToString().Equals("WT"))
            {
                worker.ReportProgress(101);
            }
            else if (e.Argument.ToString().Equals("New"))
            {
                worker.ReportProgress(102);
            }
        }

        void sqlWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.toolStrip1.Enabled = true;
            DataSet ds = (DataSet)e.UserState;
            if (e.ProgressPercentage == 0)
            {
                DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                column1.HeaderText = "ItemID";
                this.dataGridView1.Columns.Add(column1);
                DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
                column2.HeaderText = "变量名";
                this.dataGridView1.Columns.Add(column2);
                DataGridViewComboBoxColumn column3 = new DataGridViewComboBoxColumn();
                column3.HeaderText = "指示灯颜色";
                column3.Items.AddRange("红色", "绿色", "分闸绿合闸红", "分闸红合闸绿");
                this.dataGridView1.Columns.Add(column3);
                this.dataGridView1.Columns[0].Width = this.dataGridView1.Width / 3 - 20;
                this.dataGridView1.Columns[1].Width = this.dataGridView1.Width / 3 - 20;
                this.dataGridView1.Columns[2].Width = this.dataGridView1.Width / 3 - 20;
                for (int i = 0; i < ds.Tables["Result"].Rows.Count; i++)
                {
                    var row = ds.Tables["Result"].Rows[i];
                    this.dataGridView1.Rows.Add(new object[] { row[0].ToString(), row[1].ToString(), row[2].ToString() });
                }
                this.dataGridView1.Columns[0].ReadOnly = true;
                this.dataGridView1.Columns[1].ReadOnly = true;
            }
            else if (e.ProgressPercentage == 1)
            {
                DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                column1.HeaderText = "WindID";
                this.dataGridView1.Columns.Add(column1);
                DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
                column2.HeaderText = "风机名";
                this.dataGridView1.Columns.Add(column2);
                DataGridViewCheckBoxColumn column3 = new DataGridViewCheckBoxColumn();
                column3.HeaderText = "V柜";
                column3.FalseValue = "0";
                column3.TrueValue = "1";
                this.dataGridView1.Columns.Add(column3);
                DataGridViewCheckBoxColumn column4 = new DataGridViewCheckBoxColumn();
                column4.HeaderText = "C1柜";
                column4.FalseValue = "0";
                column4.TrueValue = "1";
                this.dataGridView1.Columns.Add(column4);
                DataGridViewCheckBoxColumn column5 = new DataGridViewCheckBoxColumn();
                column5.HeaderText = "C2柜";
                column5.FalseValue = "0";
                column5.TrueValue = "1";
                this.dataGridView1.Columns.Add(column5);
                this.dataGridView1.Columns[0].Width = this.dataGridView1.Width / 5 - 12;
                this.dataGridView1.Columns[1].Width = this.dataGridView1.Width / 5 - 12;
                this.dataGridView1.Columns[2].Width = this.dataGridView1.Width / 5 - 12;
                this.dataGridView1.Columns[3].Width = this.dataGridView1.Width / 5 - 12;
                this.dataGridView1.Columns[4].Width = this.dataGridView1.Width / 5 - 12;
                this.dataGridView1.Columns[0].ReadOnly = true;
                this.dataGridView1.Columns[1].ReadOnly = true;
                this.dataGridView1.Columns[2].ReadOnly = true;
                for (int i = 0; i < ds.Tables["Result"].Rows.Count; i++)
                {
                    var row = ds.Tables["Result"].Rows[i];
                    this.dataGridView1.Rows.Add(new object[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString() });
                }
            }
            else if (e.ProgressPercentage == 2)
            {
                DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                column1.HeaderText = "ItemID";
                this.dataGridView1.Columns.Add(column1);
                DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
                column2.HeaderText = "变量名";
                this.dataGridView1.Columns.Add(column2);
                DataGridViewCheckBoxColumn column3 = new DataGridViewCheckBoxColumn();
                column3.HeaderText = "是否启用";
                column3.FalseValue = "0";
                column3.TrueValue = "1";
                this.dataGridView1.Columns.Add(column3);
                DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
                column4.HeaderText = "变量单位";
                this.dataGridView1.Columns.Add(column4);
                DataGridViewButtonColumn column5 = new DataGridViewButtonColumn();
                column5.HeaderText = "选择样式";
                column5.UseColumnTextForButtonValue = false;
                column5.DefaultCellStyle.NullValue = "未选择样式";
                column5.ToolTipText = "编辑";
                this.dataGridView1.Columns.Add(column5);
                this.dataGridView1.Columns[0].Width = this.dataGridView1.Width / 5 - 12;
                this.dataGridView1.Columns[1].Width = this.dataGridView1.Width / 5 - 12;
                this.dataGridView1.Columns[2].Width = this.dataGridView1.Width / 5 - 12;
                this.dataGridView1.Columns[3].Width = this.dataGridView1.Width / 5 - 12;
                this.dataGridView1.Columns[4].Width = this.dataGridView1.Width / 5 - 12;
                for (int i = 0; i < ds.Tables["Result"].Rows.Count; i++)
                {
                    var row = ds.Tables["Result"].Rows[i];
                    this.dataGridView1.Rows.Add(new object[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString() });
                }
                this.dataGridView1.Columns[0].ReadOnly = true;
            }
            this.dataGridView1.BringToFront();
            this.dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
        }

        void sqlWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            if (int.Parse(e.Argument.ToString()) == 0)
            {
                System.Threading.Thread.Sleep(100);
                mCommand.CommandText = @"update XB_ItemDefine set ItemChineseName=TotalItemDefine.ItemChineseName from TotalItemDefine where XB_ItemDefine.ItemID=TotalItemDefine.ItemID";
                mCommand.ExecuteNonQuery();
                System.Threading.Thread.Sleep(100);
                mCommand.CommandText = @"select * from XB_ItemDefine where ItemID<1721 or (ItemID between 1731 and 1740)";
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = mCommand;
                DataSet ds = new DataSet();
                da.Fill(ds, "Result");
                worker.ReportProgress(0, ds);
            }
            else if (int.Parse(e.Argument.ToString()) == 1)
            {
                System.Threading.Thread.Sleep(100);
                mCommand.CommandText = @"update XB_WindDefine set WindName=WindDefine.WindName from WindDefine where XB_WindDefine.WindID=WindDefine.WindID";
                mCommand.ExecuteNonQuery();
                System.Threading.Thread.Sleep(100);
                mCommand.CommandText = @"select * from XB_WindDefine where WindID<>null or WindID<>''";
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = mCommand;
                DataSet ds = new DataSet();
                da.Fill(ds, "Result");
                worker.ReportProgress(1, ds);
            }
            else if (int.Parse(e.Argument.ToString()) == 2)
            {
                System.Threading.Thread.Sleep(100);
                mCommand.CommandText = @"select ItemID, ItemChineseName, ~IsVirtual, ItemValueUnitName, ItemValueColor from XB_ItemDefine where (ItemID between 1701 and 1740) or (ItemID between 1793 and 1800) order by ItemID";
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = mCommand;
                DataSet ds = new DataSet();
                da.Fill(ds, "Result");
                worker.ReportProgress(2, ds);
            }
        }
    }
}
