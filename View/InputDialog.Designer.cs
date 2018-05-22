namespace XB_Configer.View
{
    partial class InputDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputDialog));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabelName = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxInput = new MetroFramework.Controls.MetroTextBox();
            this.toolStripButtons = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonConfirm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStripButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.metroLabelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroTextBoxInput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStripButtons, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.77165F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.47244F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.75591F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 68);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroLabelName
            // 
            this.metroLabelName.AutoSize = true;
            this.metroLabelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabelName.Location = new System.Drawing.Point(3, 0);
            this.metroLabelName.Name = "metroLabelName";
            this.metroLabelName.Size = new System.Drawing.Size(295, 18);
            this.metroLabelName.TabIndex = 0;
            this.metroLabelName.Text = "metroLabel1";
            // 
            // metroTextBoxInput
            // 
            // 
            // 
            // 
            this.metroTextBoxInput.CustomButton.Image = null;
            this.metroTextBoxInput.CustomButton.Location = new System.Drawing.Point(275, 2);
            this.metroTextBoxInput.CustomButton.Name = "";
            this.metroTextBoxInput.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBoxInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxInput.CustomButton.TabIndex = 1;
            this.metroTextBoxInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxInput.CustomButton.UseSelectable = true;
            this.metroTextBoxInput.CustomButton.Visible = false;
            this.metroTextBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTextBoxInput.Lines = new string[0];
            this.metroTextBoxInput.Location = new System.Drawing.Point(3, 21);
            this.metroTextBoxInput.MaxLength = 32767;
            this.metroTextBoxInput.Name = "metroTextBoxInput";
            this.metroTextBoxInput.PasswordChar = '\0';
            this.metroTextBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxInput.SelectedText = "";
            this.metroTextBoxInput.SelectionLength = 0;
            this.metroTextBoxInput.SelectionStart = 0;
            this.metroTextBoxInput.ShortcutsEnabled = true;
            this.metroTextBoxInput.Size = new System.Drawing.Size(295, 22);
            this.metroTextBoxInput.TabIndex = 1;
            this.metroTextBoxInput.UseSelectable = true;
            this.metroTextBoxInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // toolStripButtons
            // 
            this.toolStripButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButtonCancel,
            this.toolStripSeparator2,
            this.toolStripButtonConfirm,
            this.toolStripSeparator3});
            this.toolStripButtons.Location = new System.Drawing.Point(0, 46);
            this.toolStripButtons.Name = "toolStripButtons";
            this.toolStripButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButtons.Size = new System.Drawing.Size(301, 22);
            this.toolStripButtons.TabIndex = 2;
            this.toolStripButtons.Text = "toolStrip1";
            this.toolStripButtons.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripButtons_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 22);
            // 
            // toolStripButtonConfirm
            // 
            this.toolStripButtonConfirm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonConfirm.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonConfirm.Image")));
            this.toolStripButtonConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConfirm.Name = "toolStripButtonConfirm";
            this.toolStripButtonConfirm.Size = new System.Drawing.Size(36, 19);
            this.toolStripButtonConfirm.Text = "确认";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 22);
            // 
            // toolStripButtonCancel
            // 
            this.toolStripButtonCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancel.Image")));
            this.toolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancel.Name = "toolStripButtonCancel";
            this.toolStripButtonCancel.Size = new System.Drawing.Size(36, 19);
            this.toolStripButtonCancel.Text = "取消";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 22);
            // 
            // InputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 72);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InputDialog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStripButtons.ResumeLayout(false);
            this.toolStripButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabelName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxInput;
        private System.Windows.Forms.ToolStrip toolStripButtons;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonConfirm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

    }
}