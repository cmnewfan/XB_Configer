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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 2000;
            timer.Elapsed += timer_Elapsed;
            timer.AutoReset = false;
            timer.Start();
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                FormLogin login = new FormLogin();
                var result = login.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    Form1 form = new Form1();
                    form.Show();
                    this.Visible = false;
                }
                else
                {
                    this.Close();
                }
            });
        }
    }
}
