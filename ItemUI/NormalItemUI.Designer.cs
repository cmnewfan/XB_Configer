namespace XB_Configer.ItemUI
{
    partial class NormalItemUI
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelNormalItem = new System.Windows.Forms.TableLayoutPanel();
            this.label_ItemName = new System.Windows.Forms.Label();
            this.label_Value_Normal = new System.Windows.Forms.Label();
            this.tableLayoutPanelNormalItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelNormalItem
            // 
            this.tableLayoutPanelNormalItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelNormalItem.AutoSize = true;
            this.tableLayoutPanelNormalItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelNormalItem.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelNormalItem.ColumnCount = 2;
            this.tableLayoutPanelNormalItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelNormalItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelNormalItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNormalItem.Controls.Add(this.label_ItemName, 0, 0);
            this.tableLayoutPanelNormalItem.Controls.Add(this.label_Value_Normal, 1, 0);
            this.tableLayoutPanelNormalItem.Location = new System.Drawing.Point(7, 23);
            this.tableLayoutPanelNormalItem.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelNormalItem.Name = "tableLayoutPanelNormalItem";
            this.tableLayoutPanelNormalItem.RowCount = 1;
            this.tableLayoutPanelNormalItem.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelNormalItem.Size = new System.Drawing.Size(200, 35);
            this.tableLayoutPanelNormalItem.TabIndex = 5;
            // 
            // label_ItemName
            // 
            this.label_ItemName.AutoEllipsis = true;
            this.label_ItemName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_ItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ItemName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_ItemName.Location = new System.Drawing.Point(0, 0);
            this.label_ItemName.Margin = new System.Windows.Forms.Padding(0);
            this.label_ItemName.Name = "label_ItemName";
            this.label_ItemName.Size = new System.Drawing.Size(150, 35);
            this.label_ItemName.TabIndex = 2;
            this.label_ItemName.Text = "变量名";
            this.label_ItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Value_Normal
            // 
            this.label_Value_Normal.AutoEllipsis = true;
            this.label_Value_Normal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_Value_Normal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Value_Normal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Value_Normal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Value_Normal.Location = new System.Drawing.Point(151, 0);
            this.label_Value_Normal.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label_Value_Normal.Name = "label_Value_Normal";
            this.label_Value_Normal.Size = new System.Drawing.Size(49, 35);
            this.label_Value_Normal.TabIndex = 1;
            this.label_Value_Normal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NormalItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelNormalItem);
            this.Name = "NormalItemUI";
            this.Size = new System.Drawing.Size(295, 80);
            this.tableLayoutPanelNormalItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNormalItem;
        private System.Windows.Forms.Label label_ItemName;
        private System.Windows.Forms.Label label_Value_Normal;
    }
}
