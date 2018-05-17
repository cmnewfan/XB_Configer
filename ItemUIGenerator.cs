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

namespace XB_Configer
{
    public partial class ItemUIGenerator : MetroFramework.Forms.MetroForm
    {
        public String modeName;

        public ItemUIGenerator()
        {
            InitializeComponent();
            toolStripButtonConfirm.Enabled = false;
            metroComboBoxNormal.SelectedIndex = 1;
            metroComboBoxMixUp.SelectedIndex = 1;
            metroComboBoxMixDown.SelectedIndex = 1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
            }
            else
            {
                radioButton1.Checked = true;
            }
            toolStripButtonConfirm.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
            }
            else
            {
                radioButton2.Checked = true;
            }
            toolStripButtonConfirm.Enabled = true;
        }

        private void metroComboBoxMixUp_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = metroComboBoxMixUp.Items[metroComboBoxMixUp.SelectedIndex].ToString();
            this.label_Value_MixUp.Image = getImage(index);
            this.metroComboBoxMixUp.PromptText = index;
        }

        private Image getImage(String color)
        {
            Image valueImage;
            switch (color) 
            {
                case "红灯":
                    valueImage = (Bitmap)global::XB_Configer.Properties.Resources.button_red.Clone();
                    break;
                case "绿灯":
                    valueImage = (Bitmap)global::XB_Configer.Properties.Resources.button_green.Clone();
                    break;
                case "蓝灯":
                    valueImage = (Bitmap)global::XB_Configer.Properties.Resources.button_blue.Clone();
                    break;
                case "黄灯":
                    valueImage = (Bitmap)global::XB_Configer.Properties.Resources.button_yellow.Clone();
                    break;
                case "白灯":
                    valueImage = (Bitmap)global::XB_Configer.Properties.Resources.button_withe.Clone();
                    break;
                default:
                    valueImage = (Bitmap)global::XB_Configer.Properties.Resources.button_withe.Clone();
                    break;
            }
            return valueImage;
        }

        private void metroComboBoxMixDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = metroComboBoxMixDown.Items[metroComboBoxMixDown.SelectedIndex].ToString();
            this.label_Value_MixDown.Image = getImage(index);
            this.metroComboBoxMixDown.PromptText = index;
        }

        private void metroComboBoxNormal_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = metroComboBoxNormal.Items[metroComboBoxNormal.SelectedIndex].ToString();
            this.label_Value_Normal.Image = getImage(index);
            this.metroComboBoxNormal.PromptText = index;
        }

        private void toolStripButtons_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == this.toolStripButtonCancel)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
            else if (e.ClickedItem == this.toolStripButtonConfirm)
            {
                StringBuilder mode = new StringBuilder();
                if (radioButton1.Checked && !radioButton2.Checked)
                {
                    mode.Append("双格变量-分位");
                    mode.Append(metroComboBoxMixDown.Items[metroComboBoxMixDown.SelectedIndex].ToString().Substring(0, 1));
                    mode.Append("合位");
                    mode.Append(metroComboBoxMixDown.Items[metroComboBoxMixDown.SelectedIndex].ToString().Substring(0, 1));
                    modeName = mode.ToString();
                    DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
                else if (radioButton2.Checked && !radioButton1.Checked)
                {
                    mode.Append("标准变量-");
                    mode.Append(metroComboBoxNormal.Items[metroComboBoxNormal.SelectedIndex].ToString());
                    modeName = mode.ToString();
                    DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
                else
                {
                    modeName = "错误状态";
                    this.DialogResult = System.Windows.Forms.DialogResult.No;
                }
                this.Close();
            }
        }
    }
}
