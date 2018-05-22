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

namespace XB_Configer.View
{
    public partial class InputDialog : MetroFramework.Forms.MetroForm
    {
        public String text;

        public InputDialog()
        {
            InitializeComponent();
        }

        public InputDialog(String labelText)
        {
            InitializeComponent();
            this.metroLabelName.Text = labelText;
        }

        private void toolStripButtons_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == this.toolStripButtonCancel)
            {
                this.DialogResult = DialogResult.Cancel;
                this.text = null;
                this.Close();
            }
            else if (e.ClickedItem == this.toolStripButtonConfirm)
            {
                this.DialogResult = DialogResult.OK;
                this.text = this.metroTextBoxInput.Text;
                this.Close();
            }
        }


    }
}
