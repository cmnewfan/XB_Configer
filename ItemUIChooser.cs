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
    public partial class ItemUIChooser : Form
    {
        public ItemUIChooser()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
            }
            else
            {
                radioButton1.Checked = true;
            }
        }

        private void toolStripButtons_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
