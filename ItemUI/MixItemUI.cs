using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace XB_Configer.ItemUI
{
    public partial class MixItemUI : MetroFramework.Controls.MetroUserControl
    {
        private Image trueValueImageUp;
        private Image falseValueImageUp;
        private Image trueValueImageDown;
        private Image falseValueImageDown;

        public MixItemUI()
        {
            InitializeComponent();
        }

        public MixItemUI(Image trueImageUp, Image falseImageUp, Image trueImageDown, Image falseImageDown, String name)
        {
            this.label_ItemName.Text = name;
            this.trueValueImageUp = trueImageUp;
            this.falseValueImageUp = falseImageUp;
            this.trueValueImageDown = trueImageDown;
            this.falseValueImageDown = falseImageDown;
        }

        public abstract void update(Boolean upValue, Boolean downValue)
        {
            if (trueValueImageUp != null && falseValueImageUp != null && trueValueImageDown != null && falseValueImageDown != null && upValue != null && downValue != null)
            {
                if (upValue)
                {
                    this.label_Value_MixUp.Image = trueValueImageUp;
                }
                else
                {
                    this.label_Value_MixUp.Image = falseValueImageUp;
                }
                if (downValue)
                {
                    this.label_Value_MixDown.Image = trueValueImageDown;
                }
                else
                {
                    this.label_Value_MixDown.Image = falseValueImageDown;
                }
            }
        }
    }
}
