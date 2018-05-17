using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XB_Configer
{
    public partial class FormLogin : Form
    {
        int count = 3;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != null)
            {
                if (textBoxPassword.Text.Equals("csichzfd"))
                {
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    count--;
                    if (count == 0)
                    {
                        this.DialogResult = DialogResult.No;
                        this.Close();
                    }
                    label2.Text = "密码输入错误,还有" + count + "次机会.";
                }
            }
            else
            {
                return;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
