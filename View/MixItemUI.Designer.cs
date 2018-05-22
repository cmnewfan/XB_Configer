namespace XB_Configer.View
{
    partial class MixItemUI
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
            this.tableLayoutPanelMixItem = new System.Windows.Forms.TableLayoutPanel();
            this.label_Value_MixDown = new System.Windows.Forms.Label();
            this.label_Mix_Down = new System.Windows.Forms.Label();
            this.label_Mix_Up = new System.Windows.Forms.Label();
            this.label_Value_MixUp = new System.Windows.Forms.Label();
            this.label_ItemName = new System.Windows.Forms.Label();
            this.tableLayoutPanelMixItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMixItem
            // 
            this.tableLayoutPanelMixItem.AutoSize = true;
            this.tableLayoutPanelMixItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelMixItem.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanelMixItem.ColumnCount = 3;
            this.tableLayoutPanelMixItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelMixItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMixItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanelMixItem.Controls.Add(this.label_Value_MixDown, 2, 1);
            this.tableLayoutPanelMixItem.Controls.Add(this.label_Mix_Down, 1, 1);
            this.tableLayoutPanelMixItem.Controls.Add(this.label_Mix_Up, 1, 0);
            this.tableLayoutPanelMixItem.Controls.Add(this.label_Value_MixUp, 2, 0);
            this.tableLayoutPanelMixItem.Controls.Add(this.label_ItemName, 0, 0);
            this.tableLayoutPanelMixItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMixItem.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMixItem.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMixItem.Name = "tableLayoutPanelMixItem";
            this.tableLayoutPanelMixItem.RowCount = 2;
            this.tableLayoutPanelMixItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanelMixItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanelMixItem.Size = new System.Drawing.Size(198, 48);
            this.tableLayoutPanelMixItem.TabIndex = 4;
            // 
            // label_Value_MixDown
            // 
            this.label_Value_MixDown.AutoEllipsis = true;
            this.label_Value_MixDown.BackColor = System.Drawing.Color.Transparent;
            this.label_Value_MixDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Value_MixDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Value_MixDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Value_MixDown.Location = new System.Drawing.Point(161, 23);
            this.label_Value_MixDown.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label_Value_MixDown.Name = "label_Value_MixDown";
            this.label_Value_MixDown.Size = new System.Drawing.Size(37, 25);
            this.label_Value_MixDown.TabIndex = 4;
            this.label_Value_MixDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Mix_Down
            // 
            this.label_Mix_Down.AutoEllipsis = true;
            this.label_Mix_Down.BackColor = System.Drawing.Color.Transparent;
            this.label_Mix_Down.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Mix_Down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Mix_Down.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Mix_Down.Location = new System.Drawing.Point(120, 23);
            this.label_Mix_Down.Margin = new System.Windows.Forms.Padding(0);
            this.label_Mix_Down.Name = "label_Mix_Down";
            this.label_Mix_Down.Size = new System.Drawing.Size(40, 25);
            this.label_Mix_Down.TabIndex = 3;
            this.label_Mix_Down.Text = "合位";
            this.label_Mix_Down.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Mix_Up
            // 
            this.label_Mix_Up.AutoEllipsis = true;
            this.label_Mix_Up.BackColor = System.Drawing.Color.Transparent;
            this.label_Mix_Up.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Mix_Up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Mix_Up.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Mix_Up.Location = new System.Drawing.Point(120, 0);
            this.label_Mix_Up.Margin = new System.Windows.Forms.Padding(0);
            this.label_Mix_Up.Name = "label_Mix_Up";
            this.label_Mix_Up.Size = new System.Drawing.Size(40, 23);
            this.label_Mix_Up.TabIndex = 2;
            this.label_Mix_Up.Text = "分位";
            this.label_Mix_Up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Value_MixUp
            // 
            this.label_Value_MixUp.AutoEllipsis = true;
            this.label_Value_MixUp.BackColor = System.Drawing.Color.Transparent;
            this.label_Value_MixUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Value_MixUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Value_MixUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Value_MixUp.Location = new System.Drawing.Point(161, 0);
            this.label_Value_MixUp.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label_Value_MixUp.Name = "label_Value_MixUp";
            this.label_Value_MixUp.Size = new System.Drawing.Size(37, 23);
            this.label_Value_MixUp.TabIndex = 1;
            this.label_Value_MixUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ItemName
            // 
            this.label_ItemName.AutoEllipsis = true;
            this.label_ItemName.BackColor = System.Drawing.Color.Transparent;
            this.label_ItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ItemName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_ItemName.Location = new System.Drawing.Point(0, 0);
            this.label_ItemName.Margin = new System.Windows.Forms.Padding(0);
            this.label_ItemName.Name = "label_ItemName";
            this.tableLayoutPanelMixItem.SetRowSpan(this.label_ItemName, 2);
            this.label_ItemName.Size = new System.Drawing.Size(120, 48);
            this.label_ItemName.TabIndex = 0;
            this.label_ItemName.Text = "变量名";
            this.label_ItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MixItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelMixItem);
            this.Name = "MixItemUI";
            this.Size = new System.Drawing.Size(198, 48);
            this.tableLayoutPanelMixItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMixItem;
        private System.Windows.Forms.Label label_Value_MixDown;
        private System.Windows.Forms.Label label_Mix_Down;
        private System.Windows.Forms.Label label_Mix_Up;
        private System.Windows.Forms.Label label_Value_MixUp;
        private System.Windows.Forms.Label label_ItemName;
    }
}
